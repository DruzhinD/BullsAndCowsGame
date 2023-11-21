using System;
using System.IO;
using System.Windows.Forms;

namespace BullsAndCows
{
    public partial class StatisticsForm : Form
    {
        /// <summary>поле для хранения статистики</summary>
        private Statistics _statistics;

        public StatisticsForm()
        {
            InitializeComponent();
        }

        /// <param name="statistics">Класс Statistics, содержащий статистику</param>
        public StatisticsForm(Statistics statistics)
        {
            _statistics = statistics;
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            LoadAndShowStatistics();
        }

        /// <summary>загрузка и отображение статистики</summary>
        private void LoadAndShowStatistics()
        {
            _statistics.DeserializeJson();
            _statistics.Container.Sort();
            if (_statistics.Container != null)
            {
                foreach (GameInfoContainer line in _statistics.Container)
                {
                    dataGridStatistics.Rows.Add(
                         $"{line.dateTime:g}", line.attempts, line.combination, $"{line.timeSpan:N1} с");
                }
            }
        }

        private void buttonClearStats_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(
                "Вы точно хотите безвозвратно удалить статистику?", "Очистка", MessageBoxButtons.YesNo))
            {
                //очистка файла сериализации
                using (StreamWriter sw = new StreamWriter(_statistics.path, false))
                {
                    sw.Write("");
                }

                //очистка таблицы
                if (dataGridStatistics.Rows.Count > 0)
                    dataGridStatistics.Rows.Clear();
            }
            else
            {
                return;
            }
        }
    }
}
