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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridStatistics = new System.Windows.Forms.DataGridView();
            this.dateOfGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attempts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSpan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStatistics
            // 
            this.dataGridStatistics.AllowUserToAddRows = false;
            this.dataGridStatistics.AllowUserToDeleteRows = false;
            this.dataGridStatistics.AllowUserToResizeColumns = false;
            this.dataGridStatistics.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridStatistics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStatistics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(180)))), ((int)(((byte)(162)))));
            this.dataGridStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridStatistics.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridStatistics.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(44)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(82)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(58)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateOfGame,
            this.Attempts,
            this.Combination,
            this.timeSpan});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridStatistics.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridStatistics.EnableHeadersVisualStyles = false;
            this.dataGridStatistics.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridStatistics.Location = new System.Drawing.Point(0, 0);
            this.dataGridStatistics.Name = "dataGridStatistics";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridStatistics.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridStatistics.RowHeadersVisible = false;
            this.dataGridStatistics.RowHeadersWidth = 82;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(121)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(156)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(156)))), ((int)(((byte)(128)))));
            this.dataGridStatistics.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridStatistics.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(121)))), ((int)(((byte)(99)))));
            this.dataGridStatistics.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridStatistics.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(156)))), ((int)(((byte)(128)))));
            this.dataGridStatistics.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(87)))));
            this.dataGridStatistics.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(156)))), ((int)(((byte)(128)))));
            this.dataGridStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridStatistics.Size = new System.Drawing.Size(684, 429);
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
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(180)))), ((int)(((byte)(162)))));
            this.ClientSize = new System.Drawing.Size(684, 429);
            this.Controls.Add(this.dataGridStatistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(700, 485);
            this.MinimumSize = new System.Drawing.Size(600, 284);
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
    }
}