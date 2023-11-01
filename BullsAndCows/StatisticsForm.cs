﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string path = Path.GetFullPath(Path.Combine(
                Directory.GetCurrentDirectory(), @"..\..\", "statistics.json"));
            _statistics.DeserializeJson(path);
            if (_statistics.Container != null)
            {
                foreach (GameInfoContainer line in _statistics.Container)
                {
                    dataGridStatistics.Rows.Add(line.attempts, line.combination);
                }
            }
        }
    }
}
