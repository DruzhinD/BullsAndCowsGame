using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    public partial class MainForm : Form
    {
        ///<summary>искомая комбинация</summary>
        public string SecretCombination { get; private set; } = string.Empty;

        /// <summary>Длина комбинации</summary>
        public const int CombinationLength = 4;

        /// <summary>счетчик попыток</summary>
        public int attempts = 0;

        /// <summary>системное время, при котором началась игра</summary>
        private DateTime _startTime;

        /// <summary>промежуток времени, за который была завершена игра</summary>
        private TimeSpan _timeSpan;

        /// <summary>поле для хранения статистики</summary>
        private Statistics _statistics = new Statistics();

        string path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\", "statistics.json"));

        public MainForm()
        {
            InitializeComponent();
        }

        //вызывается каждый раз при открытии формы (из свернутого состояния), но это неточно
        private void Form1_Load(object sender, EventArgs e)
        {
            //генерация комбинации
            SecretCombination = GameLogic.GenCombination(CombinationLength);
            labelCongratulation.Text = SecretCombination;

            _startTime = DateTime.Now;
        }

        /// <summary>
        /// проверка на соответствие введенного числа загаданной комбинации
        /// с последующей записью результата в таблицу вывода dataGridViewInfo
        /// </summary>
        private void CheckAnswer()
        {
            string userCombination = textBoxInput.Text;

            string message = GameLogic.IsCorrectInput(userCombination);
            if (message != "0")
            {
                MessageBox.Show(message);
                return;
            }

            attempts++;
            int bulls = GameLogic.CalculateBullsCount(userCombination, SecretCombination);
            int cows = GameLogic.CalculateCowsCount(userCombination, SecretCombination);

            dataviewGameInfo.Rows.Add(attempts, userCombination, bulls, cows);

            if (bulls == CombinationLength)
            {
                GameOverBottomInfo();
                UploadStatistics();

                MessageBox.Show("Ура! победа");
                buttonNextAttempt.Enabled = false;
                buttonNextAttempt.Visible = false;
                ShowButtonNewGame();
            }
        }

        /// <summary>сериализация статистики после завершения игры</summary>
        private void UploadStatistics()
        {
            GameInfoContainer gameInfo = new GameInfoContainer(attempts, int.Parse(SecretCombination), _timeSpan.TotalSeconds);
            _statistics.Container.Add(gameInfo);
            _statistics.SerializeJson(path);
        }

        /// <summary>
        /// обработка клика на кнопке следующей попытки
        /// </summary>
        private void buttonNextAttempt_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        /// <summary>
        /// эквивалентно нажатию кнопки buttonNextAttempt
        /// </summary>
        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CheckAnswer();
        }

        /// <summary>
        /// Информация, которая выводится внизу формы после завершения игры
        /// </summary>
        private void GameOverBottomInfo()
        {
            labelCongratulation.Text = $"Вы победили, используя {attempts} попытку(-ок)!";
            _timeSpan = DateTime.Now - _startTime;
            labelTimespan.Text = $"{_timeSpan.TotalSeconds:N1} c";
        }

        /// <summary>
        /// Отображение кнопки для начала новой игры после завершения текущей
        /// </summary>
        private void ShowButtonNewGame()
        {
            buttonNewGame.Enabled = true;
            buttonNewGame.Visible = true;
            buttonNewGame.BringToFront();
        }

        /// <summary>
        /// обработка клика по кнопке начала новой игры
        /// </summary>
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Вы точно хотите начать заново?", "Перезапуск", MessageBoxButtons.OKCancel))
            {
                Application.Restart();
            }
        }

        private void какИгратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string howToPlay = "Необходимо отгадать четырехзначное число,\r\n" +
                "в котором цифры не повторяются.\r\n" +
                "1 бык означает, что была отгадана одна цифра вплоть до позиции\r\n" +
                "1 корова - была отгадана одна цифра, но указана не своей позиции\r\n" +
                "соответственно с большим количество быков и коров аналогично.\r\n" +
                "Если после очередной попытки отображено 4 быка, то вы победили!\r\n" +
                "Удачи!";
            MessageBox.Show(howToPlay);
        }

        private void информацияОбИграхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm(_statistics);
            statisticsForm.Show(this);
        }
    }
}
