using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    public partial class Form1 : Form
    {
        ///<summary>искомая комбинация</summary>
        public string SecretCombination { get; private set; }

        /// <summary>Длина комбинации</summary>
        public const int CombinationLength = 4;

        /// <summary>счетчик попыток</summary>
        public int attempts = 0;

        /// <summary>системное время, при котором началась игра</summary>
        private DateTime startTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //генерация комбинации
            List<char> numbers = new List<char> {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };
            Random rnd = new Random();
            
            for (int i = 0; i < CombinationLength; i++)
            {
                char chosenNum = numbers[rnd.Next(numbers.Count)];
                numbers.Remove(chosenNum);
                SecretCombination += chosenNum;
            }
            labelCongratulation.Text = SecretCombination;

            startTime = DateTime.Now;
        }

        /// <summary>
        /// обработка клика на кнопке следующей попытки
        /// </summary>
        private void buttonNextAttempt_Click(object sender, EventArgs e)
        {
            string userCombination = textBoxInput.Text;
            if (!IsCorrectInput(userCombination))
                return;

            attempts++;
            int bulls = CalculateBullsCount(userCombination);
            int cows = CalculateCowsCount(userCombination);

            dataviewGameInfo.Rows.Add(attempts, userCombination, bulls, cows);

            if (bulls == CombinationLength)
            {
                GameOverBottomInfo();

                MessageBox.Show("Ура! победа");
                buttonNextAttempt.Enabled = false;
                buttonNextAttempt.Visible = false;
                ShowButtonNewGame();
            }
        }

        /// <summary>
        /// Информация, которая выводится внизу формы после завершения игры
        /// </summary>
        private void GameOverBottomInfo()
        {
            labelCongratulation.Text = $"Вы победили, используя {attempts} попытку(-ок)!";
            TimeSpan timeSpan = DateTime.Now - startTime;
            labelTimespan.Text = $"{timeSpan.TotalSeconds:N1} c";
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

        /// <summary>
        /// Проверка на корректный ввод пользователем комбинации чисел
        /// </summary>
        /// <param name="userWord">комбинация, введенная пользователем</param>
        /// <returns>true - комбинация соответсвует требованиям, иначе - false</returns>
        private bool IsCorrectInput(string userWord)
        {
            if (userWord.Length != CombinationLength)
            {
                MessageBox.Show("Число должно состоять из 4 цифр!");
                return false;
            }

            for (int i = 0; i < userWord.Length; i++)
            {
                if (!char.IsDigit(userWord[i]))
                {
                    MessageBox.Show("В этой игре можно использовать только цифры!");
                    return false;
                }
            }

            for (int i = 0; i < userWord.Length; i++)
            {
                for (int j = i + 1; j < userWord.Length; j++)
                {
                    if (userWord[i] == userWord[j])
                    {
                        MessageBox.Show("Цифры не должны повторяться!");
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Подсчет количества быков
        /// </summary>
        /// <param name="userWord"></param>
        /// <returns></returns>
        private int CalculateBullsCount(string userWord)
        {
            int bullsCount = 0;

            for (int i = 0; i < CombinationLength; i++)
            {
                if (SecretCombination[i] == userWord[i])
                {
                    bullsCount++;
                }
            }
            return bullsCount;
        }

        /// <summary>
        /// Подсчет количества коров
        /// </summary>
        /// <param name="userWord"></param>
        /// <returns></returns>
        private int CalculateCowsCount(string userWord)
        {
            int cowsCount = 0;
            //char[] splitCombNums = new char[CombinationLength];
            //for (int i = 0; i < CombinationLength; i++)
            //    splitCombNums[i] = SecretCombination[i];

            //foreach (char splitUserWord in userWord)
            //{
            //    if (splitCombNums.Contains(splitUserWord))
            //        cowsCount++;
            //}

            for (int i = 0; i < CombinationLength; i++)
            {
                for (int j = 0; j < CombinationLength; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if (SecretCombination[i] == userWord[j])
                    {
                        cowsCount++;
                    }
                }
            }
            return cowsCount;
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
    }
}
