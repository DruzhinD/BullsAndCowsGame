using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullsAndCows
{
    ///<summary>Статический класс, содержащий в себе всю игровую логику</summary>    
    internal static class GameLogic
    {
        /// <summary>
        /// генерация числовой комбинации
        /// </summary>
        /// <param name="length">длина комбинации (по ум. = 4)</param>
        /// <returns>комбинация заданной величины в формате строки</returns>
        internal static string GenCombination(int length = 4)
        {
            string combination = string.Empty; //генерируемая комбинация
            List<int> numbers = new List<int>()
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int chosenNum = numbers[rnd.Next(numbers.Count)];
                numbers.Remove(chosenNum);
                combination += chosenNum;
            }

            return combination;
        }

        /// <summary>
        /// подсчет количества быков во введенной пользователем комбинации
        /// </summary>
        /// <param name="userCombination">ввод пользователя</param>
        /// <param name="secretCombination">сгенерированная комбинация</param>
        /// <returns>количество быков</returns>
        internal static int CalculateBullsCount(string userCombination, string secretCombination)
        {
            int bullsCount = 0;

            for (int i = 0; i < secretCombination.Length; i++)
            {
                if (secretCombination[i] == userCombination[i])
                {
                    bullsCount++;
                }
            }
            return bullsCount;
        }

        /// <summary>
        /// подсчет количества коров во введенной пользователем комбинации
        /// </summary>
        /// <param name="userCombination">ввод пользователя</param>
        /// <param name="secretCombination">сгенерированная комбинация</param>
        /// <returns>количество коров</returns>
        internal static int CalculateCowsCount(string userCombination, string secretCombination)
        {
            int cowsCount = 0;
            foreach (char num in userCombination)
            {
                //проверка на содержание цифры (только коровы)
                if (secretCombination.Contains(num))
                {
                    //проверка на быков.
                    //причем достоверно известно, что комбинация содержит итерируемый символ,
                    //это следует из предыдущего условия
                    if (secretCombination.IndexOf(num) != userCombination.IndexOf(num))
                        cowsCount++;
                }
            }
            return cowsCount;
        }

        /// <summary>
        /// Проверка введенного пользователем числа
        /// </summary>
        /// <param name="userCombination">ввод пользователя</param>
        /// <param name="length">длина комбинации</param>
        /// <returns>0 - в случае успешной проверки всех условий,
        /// иначе - сообщение для вывода пользователю, т.е. ошибки ввода</returns>
        internal static string IsCorrectInput(string userCombination, int length = 4)
        {
            if (userCombination.Length != length)
                return "Число должно состоять из 4 цифр!";

            foreach (char num in userCombination)
            {
                if (!char.IsDigit(num))
                    return "В этой игре можно использовать только цифры!";
            }

            for (int i = 0; i < userCombination.Length; i++)
            {
                for (int j = i + 1; j < userCombination.Length; j++)
                {
                    if (userCombination[i] == userCombination[j])
                        return "Цифры не должны повторяться!";
                }
            }
            return "0";
        }
    }
}
