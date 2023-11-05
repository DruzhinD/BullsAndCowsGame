namespace BullsAndCows
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.labelTimespan = new System.Windows.Forms.Label();
            this.labelCongratulation = new System.Windows.Forms.Label();
            this.dataviewGameInfo = new System.Windows.Forms.DataGridView();
            this.attempt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bulls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьОтветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОбИграхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какИгратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNextAttempt = new BullsAndCows.RoundedButton();
            this.buttonNewGame = new BullsAndCows.RoundedButton();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewGameInfo)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(113)))), ((int)(((byte)(105)))));
            this.bottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomPanel.Controls.Add(this.labelTimespan);
            this.bottomPanel.Controls.Add(this.labelCongratulation);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 288);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(666, 39);
            this.bottomPanel.TabIndex = 0;
            // 
            // labelTimespan
            // 
            this.labelTimespan.AutoSize = true;
            this.labelTimespan.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTimespan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimespan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(135)))), ((int)(((byte)(114)))));
            this.labelTimespan.Location = new System.Drawing.Point(613, 0);
            this.labelTimespan.Name = "labelTimespan";
            this.labelTimespan.Size = new System.Drawing.Size(51, 25);
            this.labelTimespan.TabIndex = 1;
            this.labelTimespan.Text = "time";
            this.labelTimespan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTimespan.Visible = false;
            // 
            // labelCongratulation
            // 
            this.labelCongratulation.AutoSize = true;
            this.labelCongratulation.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCongratulation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCongratulation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(135)))), ((int)(((byte)(114)))));
            this.labelCongratulation.Location = new System.Drawing.Point(0, 0);
            this.labelCongratulation.Name = "labelCongratulation";
            this.labelCongratulation.Size = new System.Drawing.Size(90, 25);
            this.labelCongratulation.TabIndex = 1;
            this.labelCongratulation.Text = "congrats";
            this.labelCongratulation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCongratulation.Visible = false;
            // 
            // dataviewGameInfo
            // 
            this.dataviewGameInfo.AllowUserToAddRows = false;
            this.dataviewGameInfo.AllowUserToDeleteRows = false;
            this.dataviewGameInfo.AllowUserToResizeColumns = false;
            this.dataviewGameInfo.AllowUserToResizeRows = false;
            this.dataviewGameInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataviewGameInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(175)))), ((int)(((byte)(164)))));
            this.dataviewGameInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataviewGameInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(52)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(91)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(52)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(91)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataviewGameInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataviewGameInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewGameInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attempt,
            this.number,
            this.bulls,
            this.cows});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(158)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(75)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(133)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataviewGameInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataviewGameInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataviewGameInfo.EnableHeadersVisualStyles = false;
            this.dataviewGameInfo.GridColor = System.Drawing.Color.DarkGray;
            this.dataviewGameInfo.Location = new System.Drawing.Point(0, 92);
            this.dataviewGameInfo.Name = "dataviewGameInfo";
            this.dataviewGameInfo.ReadOnly = true;
            this.dataviewGameInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataviewGameInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataviewGameInfo.RowHeadersVisible = false;
            this.dataviewGameInfo.RowHeadersWidth = 82;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.dataviewGameInfo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataviewGameInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataviewGameInfo.Size = new System.Drawing.Size(666, 196);
            this.dataviewGameInfo.TabIndex = 1;
            // 
            // attempt
            // 
            this.attempt.HeaderText = "Попытка";
            this.attempt.MinimumWidth = 10;
            this.attempt.Name = "attempt";
            this.attempt.ReadOnly = true;
            // 
            // number
            // 
            this.number.HeaderText = "Число";
            this.number.MinimumWidth = 10;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // bulls
            // 
            this.bulls.HeaderText = "Быки";
            this.bulls.MinimumWidth = 10;
            this.bulls.Name = "bulls";
            this.bulls.ReadOnly = true;
            // 
            // cows
            // 
            this.cows.HeaderText = "Коровы";
            this.cows.MinimumWidth = 10;
            this.cows.Name = "cows";
            this.cows.ReadOnly = true;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(114)))), ((int)(((byte)(70)))));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(666, 27);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.показатьОтветToolStripMenuItem,
            this.информацияОбИграхToolStripMenuItem});
            this.играToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.играToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.играToolStripMenuItem.Text = "игра";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(114)))), ((int)(((byte)(70)))));
            this.новаяИграToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.новаяИграToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.новаяИграToolStripMenuItem.Text = "новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.NewGameEvent_Click);
            // 
            // показатьОтветToolStripMenuItem
            // 
            this.показатьОтветToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(114)))), ((int)(((byte)(70)))));
            this.показатьОтветToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.показатьОтветToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.показатьОтветToolStripMenuItem.Name = "показатьОтветToolStripMenuItem";
            this.показатьОтветToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.показатьОтветToolStripMenuItem.Text = "показать ответ";
            this.показатьОтветToolStripMenuItem.Click += new System.EventHandler(this.показатьОтветToolStripMenuItem_Click);
            // 
            // информацияОбИграхToolStripMenuItem
            // 
            this.информацияОбИграхToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(114)))), ((int)(((byte)(70)))));
            this.информацияОбИграхToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.информацияОбИграхToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.информацияОбИграхToolStripMenuItem.Name = "информацияОбИграхToolStripMenuItem";
            this.информацияОбИграхToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.информацияОбИграхToolStripMenuItem.Text = "информация об играх";
            this.информацияОбИграхToolStripMenuItem.Click += new System.EventHandler(this.информацияОбИграхToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какИгратьToolStripMenuItem});
            this.помощьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.помощьToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.помощьToolStripMenuItem.Text = "помощь";
            // 
            // какИгратьToolStripMenuItem
            // 
            this.какИгратьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(114)))), ((int)(((byte)(70)))));
            this.какИгратьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.какИгратьToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(62)))), ((int)(((byte)(37)))));
            this.какИгратьToolStripMenuItem.Name = "какИгратьToolStripMenuItem";
            this.какИгратьToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.какИгратьToolStripMenuItem.Text = "Как играть?";
            this.какИгратьToolStripMenuItem.Click += new System.EventHandler(this.какИгратьToolStripMenuItem_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(143)))), ((int)(((byte)(112)))));
            this.textBoxInput.Location = new System.Drawing.Point(3, 13);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(327, 36);
            this.textBoxInput.TabIndex = 2;
            this.textBoxInput.Text = "Введите число";
            this.textBoxInput.Enter += new System.EventHandler(this.textBoxInput_Enter);
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
            this.textBoxInput.Leave += new System.EventHandler(this.textBoxInput_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(157)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.buttonNextAttempt);
            this.panel1.Controls.Add(this.textBoxInput);
            this.panel1.Controls.Add(this.buttonNewGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 65);
            this.panel1.TabIndex = 0;
            // 
            // buttonNextAttempt
            // 
            this.buttonNextAttempt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonNextAttempt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(126)))), ((int)(((byte)(90)))));
            this.buttonNextAttempt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(126)))), ((int)(((byte)(90)))));
            this.buttonNextAttempt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.buttonNextAttempt.BorderRadius = 40;
            this.buttonNextAttempt.BorderSize = 4;
            this.buttonNextAttempt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextAttempt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextAttempt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(77)))), ((int)(((byte)(60)))));
            this.buttonNextAttempt.Location = new System.Drawing.Point(336, 3);
            this.buttonNextAttempt.Name = "buttonNextAttempt";
            this.buttonNextAttempt.Size = new System.Drawing.Size(146, 59);
            this.buttonNextAttempt.TabIndex = 1;
            this.buttonNextAttempt.Text = "Проверить";
            this.buttonNextAttempt.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(77)))), ((int)(((byte)(60)))));
            this.buttonNextAttempt.UseVisualStyleBackColor = false;
            this.buttonNextAttempt.Click += new System.EventHandler(this.buttonNextAttempt_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(126)))), ((int)(((byte)(90)))));
            this.buttonNewGame.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(126)))), ((int)(((byte)(90)))));
            this.buttonNewGame.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(94)))), ((int)(((byte)(66)))));
            this.buttonNewGame.BorderRadius = 40;
            this.buttonNewGame.BorderSize = 4;
            this.buttonNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGame.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(77)))), ((int)(((byte)(60)))));
            this.buttonNewGame.Location = new System.Drawing.Point(499, 3);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(146, 59);
            this.buttonNewGame.TabIndex = 2;
            this.buttonNewGame.Text = "новая игра";
            this.buttonNewGame.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(77)))), ((int)(((byte)(60)))));
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Click += new System.EventHandler(this.NewGameEvent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(53)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 327);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataviewGameInfo);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Быки и коровы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewGameInfo)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label labelCongratulation;
        private System.Windows.Forms.Label labelTimespan;
        private System.Windows.Forms.DataGridView dataviewGameInfo;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОбИграхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какИгратьToolStripMenuItem;
        private BullsAndCows.RoundedButton buttonNextAttempt;
        private System.Windows.Forms.DataGridViewTextBoxColumn attempt;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulls;
        private System.Windows.Forms.DataGridViewTextBoxColumn cows;
        private BullsAndCows.RoundedButton buttonNewGame;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem показатьОтветToolStripMenuItem;
    }
}

