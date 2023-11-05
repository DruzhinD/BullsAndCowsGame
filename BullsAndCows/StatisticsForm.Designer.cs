using BullsAndCows.Properties;

namespace BullsAndCows
{
    partial class StatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.dataGridStatistics = new System.Windows.Forms.DataGridView();
            this.dateOfGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attempts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSpan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClearStats = new BullsAndCows.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStatistics
            // 
            this.dataGridStatistics.AllowUserToAddRows = false;
            this.dataGridStatistics.AllowUserToDeleteRows = false;
            this.dataGridStatistics.AllowUserToResizeColumns = false;
            this.dataGridStatistics.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridStatistics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStatistics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(180)))), ((int)(((byte)(162)))));
            this.dataGridStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridStatistics.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridStatistics.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(71)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(101)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(58)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateOfGame,
            this.Attempts,
            this.Combination,
            this.timeSpan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStatistics.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridStatistics.EnableHeadersVisualStyles = false;
            this.dataGridStatistics.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridStatistics.Location = new System.Drawing.Point(0, 65);
            this.dataGridStatistics.Name = "dataGridStatistics";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStatistics.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridStatistics.RowHeadersVisible = false;
            this.dataGridStatistics.RowHeadersWidth = 82;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(121)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(156)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(156)))), ((int)(((byte)(128)))));
            this.dataGridStatistics.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridStatistics.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(121)))), ((int)(((byte)(99)))));
            this.dataGridStatistics.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridStatistics.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(156)))), ((int)(((byte)(128)))));
            this.dataGridStatistics.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(87)))));
            this.dataGridStatistics.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(156)))), ((int)(((byte)(128)))));
            this.dataGridStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridStatistics.Size = new System.Drawing.Size(684, 364);
            this.dataGridStatistics.TabIndex = 0;
            // 
            // dateOfGame
            // 
            this.dateOfGame.HeaderText = "Дата игры";
            this.dateOfGame.Name = "dateOfGame";
            this.dateOfGame.ReadOnly = true;
            // 
            // Attempts
            // 
            this.Attempts.HeaderText = "попытки";
            this.Attempts.MinimumWidth = 10;
            this.Attempts.Name = "Attempts";
            // 
            // Combination
            // 
            this.Combination.HeaderText = "комбинация";
            this.Combination.MinimumWidth = 10;
            this.Combination.Name = "Combination";
            // 
            // timeSpan
            // 
            this.timeSpan.HeaderText = "время";
            this.timeSpan.Name = "timeSpan";
            this.timeSpan.ReadOnly = true;
            // 
            // buttonClearStats
            // 
            this.buttonClearStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(126)))), ((int)(((byte)(90)))));
            this.buttonClearStats.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(126)))), ((int)(((byte)(90)))));
            this.buttonClearStats.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.buttonClearStats.BorderRadius = 40;
            this.buttonClearStats.BorderSize = 5;
            this.buttonClearStats.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClearStats.FlatAppearance.BorderSize = 0;
            this.buttonClearStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearStats.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(77)))), ((int)(((byte)(60)))));
            this.buttonClearStats.Location = new System.Drawing.Point(0, 0);
            this.buttonClearStats.Name = "buttonClearStats";
            this.buttonClearStats.Size = new System.Drawing.Size(195, 65);
            this.buttonClearStats.TabIndex = 1;
            this.buttonClearStats.Text = "Очистить статистику";
            this.buttonClearStats.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(77)))), ((int)(((byte)(60)))));
            this.buttonClearStats.UseVisualStyleBackColor = false;
            this.buttonClearStats.Click += new System.EventHandler(this.buttonClearStats_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(56)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(684, 429);
            this.Controls.Add(this.buttonClearStats);
            this.Controls.Add(this.dataGridStatistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 485);
            this.MinimumSize = new System.Drawing.Size(650, 284);
            this.Name = "StatisticsForm";
            this.Text = "Игровая статистика";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attempts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combination;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSpan;
        private RoundedButton buttonClearStats;
    }
}