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
        private const int CombinationLength = 4;

        /// <summary>счетчик попыток</summary>
        private int attempts = 0;

        /// <summary>системное время, при котором началась игра</summary>
        private DateTime _startTime;

        /// <summary>промежуток времени, за который была завершена игра</summary>
        private TimeSpan _timeSpan;

        static readonly string path = Path.GetFullPath(Path.Combine(
            Directory.GetCurrentDirectory(), @"..\..\", "statistics.json"));
        /// <summary>поле для хранения статистики</summary>
        private Statistics _statistics = new Statistics(path);

        /// <summary>флаг окончания игры</summary>
        private bool flagGameOver = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //генерация комбинации
            SecretCombination = GameLogic.GenCombination(CombinationLength);
            //сохранение времени начала игры
            _startTime = DateTime.Now;
        }

        /// <summary>
        /// проверка на соответствие введенного числа загаданной комбинации
        /// с последующей записью результата в таблицу вывода dataGridViewInfo
        /// </summary>
        private void CheckAnswer()
        {
            string userCombination = textBoxInput.Text;
            textBoxInput.Text = string.Empty; //очистка поля ввода

            //проверка ввода
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

            //проверка победы
            if (bulls == CombinationLength)
            {
                flagGameOver = true;
                GameOverBottomInfo(false); //пользователь завершил игру, угадав ответ
                UploadStatistics();

                MessageBox.Show("Ура! победа");
            }
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
            //ввод ответа
            if (e.KeyCode == Keys.Enter & flagGameOver != true)
            {
                e.SuppressKeyPress = true;
                CheckAnswer();
            }
            //перевод фокуса на кнопку
            else if (e.KeyCode == Keys.Escape)
            {
                buttonNextAttempt.Focus();
                e.SuppressKeyPress = true;
            }
        }

        /// <summary>
        /// Информация, которая выводится внизу формы после завершения игры.
        /// А также отключение кнопки следующей попытки
        /// </summary>
        /// <param name="giveUp">false - игра завершена, если пользователь угадал комбинацию,
        /// true - если воспользовался возможностью посмотреть ответ</param>
        private void GameOverBottomInfo(bool giveUp)
        {
            buttonNextAttempt.Enabled = false; //отключаем кнопку следующей попытки
            //если игрок сдался
            if (giveUp)
            {
                labelCongratulation.Visible = true;
                labelCongratulation.Text = "Игра окончена";
                labelTimespan.Visible = true;
                labelTimespan.Text = $"Комбинация: {SecretCombination}";
            }
            //если игрок угадал комбинацию
            else
            {
                string wordAttempt = string.Empty;
                //for (int i = 0; i <= 9; i++)
                //{
                //if (attempts.ToString().EndsWith(i.ToString()) )

                //}

                labelCongratulation.Visible = true;
                labelCongratulation.Text = $"Вы победили, используя {attempts} {WordByAmountAttempts()}!";
                _timeSpan = DateTime.Now - _startTime;
                labelTimespan.Visible = true;
                labelTimespan.Text = $"{_timeSpan.TotalSeconds:N1} c";
            }
        }

        private string WordByAmountAttempts()
        {
            string wordAttempt = string.Empty;
            //какой цифрой оканчивается
            int endSymd = int.Parse(attempts.ToString()[attempts.ToString().Length - 1].ToString());

            //особая проверка для чисел от 11 до 19
            for (int i = 11; i <= 19; i++)
            {
                if (attempts == i)
                    return "попыток";
            }

            if (endSymd == 0)
                return "попыток";
            //1 попытка
            else if (endSymd == 1)
                return "попытку";
            
            //от 2 до 4
            for (int i = 2; i <= 4; i++)
            {
                if (endSymd == i)
                    return "попытки";
            }
            //от 5 до 9
            for (int i = 5; i <= 9; i++)
            {
                if (endSymd == i)
                    return "попыток";
            }
            //заглушка для ошибки
            return "попыток";
        }

        /// <summary>сериализация статистики после завершения игры</summary>
        private void UploadStatistics()
        {
            _statistics.DeserializeJson();
            GameInfoContainer gameInfo = new GameInfoContainer(
                attempts, int.Parse(SecretCombination), _timeSpan.TotalSeconds, DateTime.Now);
            _statistics.Container.Add(gameInfo);
            _statistics.SerializeJson();
        }

        /// <summary>
        /// обработка клика для начала новой игры
        /// </summary>
        private void NewGameEvent_Click(object sender, EventArgs eventArgs)
        {
            if (DialogResult.OK == MessageBox.Show("Вы точно хотите начать заново?", "Перезапуск", MessageBoxButtons.OKCancel))
            {
                Application.Restart();
            }
        }

        /// <summary>
        /// узнать ответ, при этом завершив игру поражением
        /// </summary>
        private void показатьОтветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //если игра завершена, то ответ уже известен, пользователь получит соответствующий вывод
            if (flagGameOver)
            {
                MessageBox.Show("Игра уже окончена!", "Ответ");
                return;
            }
            //конец игры
            if (DialogResult.Yes == MessageBox.Show("Вы точно хотите узнать ответ?\n" +
                "Если узнать его не доиграв, вы проиграете!", "Ответ", MessageBoxButtons.YesNo))
            {
                string message = $"комбинация: {SecretCombination}\n" +
                    $"Игра окончена :(\n" +
                    $"В следующий раз обязательно получится!";
                MessageBox.Show(message, "ответ");
                flagGameOver = true;
                GameOverBottomInfo(true); //игрок сдался
            }
            //продолжение игры
            else
            {
                return;
            }
        }
        private void информацияОбИграхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm(_statistics);
            statisticsForm.Show();
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

        #region текст, отображаемый на поле ввода до взаимодействия с пользователем (водяной знак)
        private const string waterMark = "Введите число";
        private void textBoxInput_Enter(object sender, EventArgs e)
        {
            if (textBoxInput.Text == waterMark)
                textBoxInput.Text = string.Empty;
        }

        private void textBoxInput_Leave(object sender, EventArgs e)
        {
            if (textBoxInput.Text == string.Empty)
                textBoxInput.Text = waterMark;
        }
        #endregion

    }
}
