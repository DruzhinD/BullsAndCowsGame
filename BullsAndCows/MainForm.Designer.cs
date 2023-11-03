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
            this.информацияОбИграхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какИгратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputCommandsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelInputInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNextAttempt = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewGameInfo)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.InputCommandsPanel.SuspendLayout();
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
            this.labelTimespan.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimespan.Location = new System.Drawing.Point(618, 0);
            this.labelTimespan.Name = "labelTimespan";
            this.labelTimespan.Size = new System.Drawing.Size(46, 23);
            this.labelTimespan.TabIndex = 1;
            this.labelTimespan.Text = "time";
            this.labelTimespan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCongratulation
            // 
            this.labelCongratulation.AutoSize = true;
            this.labelCongratulation.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCongratulation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCongratulation.Location = new System.Drawing.Point(0, 0);
            this.labelCongratulation.Name = "labelCongratulation";
            this.labelCongratulation.Size = new System.Drawing.Size(82, 23);
            this.labelCongratulation.TabIndex = 1;
            this.labelCongratulation.Text = "congrats";
            this.labelCongratulation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.menuStrip.Size = new System.Drawing.Size(666, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.информацияОбИграхToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.играToolStripMenuItem.Text = "игра";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.новаяИграToolStripMenuItem.Text = "новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // информацияОбИграхToolStripMenuItem
            // 
            this.информацияОбИграхToolStripMenuItem.Name = "информацияОбИграхToolStripMenuItem";
            this.информацияОбИграхToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.информацияОбИграхToolStripMenuItem.Text = "информация об играх";
            this.информацияОбИграхToolStripMenuItem.Click += new System.EventHandler(this.информацияОбИграхToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какИгратьToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.помощьToolStripMenuItem.Text = "помощь";
            // 
            // какИгратьToolStripMenuItem
            // 
            this.какИгратьToolStripMenuItem.Name = "какИгратьToolStripMenuItem";
            this.какИгратьToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.какИгратьToolStripMenuItem.Text = "Как играть?";
            this.какИгратьToolStripMenuItem.Click += new System.EventHandler(this.какИгратьToolStripMenuItem_Click);
            // 
            // InputCommandsPanel
            // 
            this.InputCommandsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(157)))), ((int)(((byte)(125)))));
            this.InputCommandsPanel.ColumnCount = 3;
            this.InputCommandsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.InputCommandsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.InputCommandsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.InputCommandsPanel.Controls.Add(this.textBoxInput, 1, 0);
            this.InputCommandsPanel.Controls.Add(this.labelInputInfo, 0, 0);
            this.InputCommandsPanel.Controls.Add(this.panel1, 2, 0);
            this.InputCommandsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputCommandsPanel.Location = new System.Drawing.Point(0, 24);
            this.InputCommandsPanel.Name = "InputCommandsPanel";
            this.InputCommandsPanel.RowCount = 1;
            this.InputCommandsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InputCommandsPanel.Size = new System.Drawing.Size(666, 68);
            this.InputCommandsPanel.TabIndex = 3;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInput.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(143)))), ((int)(((byte)(112)))));
            this.textBoxInput.Location = new System.Drawing.Point(225, 12);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(216, 43);
            this.textBoxInput.TabIndex = 2;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
            // 
            // labelInputInfo
            // 
            this.labelInputInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelInputInfo.AutoSize = true;
            this.labelInputInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInputInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(97)))), ((int)(((byte)(67)))));
            this.labelInputInfo.Location = new System.Drawing.Point(7, 15);
            this.labelInputInfo.Name = "labelInputInfo";
            this.labelInputInfo.Size = new System.Drawing.Size(212, 37);
            this.labelInputInfo.TabIndex = 0;
            this.labelInputInfo.Text = "Введите число";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNextAttempt);
            this.panel1.Controls.Add(this.buttonNewGame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(447, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 62);
            this.panel1.TabIndex = 3;
            // 
            // buttonNextAttempt
            // 
            this.buttonNextAttempt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonNextAttempt.BackColor = System.Drawing.Color.Bisque;
            this.buttonNextAttempt.Location = new System.Drawing.Point(18, 5);
            this.buttonNextAttempt.Name = "buttonNextAttempt";
            this.buttonNextAttempt.Size = new System.Drawing.Size(146, 58);
            this.buttonNextAttempt.TabIndex = 1;
            this.buttonNextAttempt.Text = "Проверить";
            this.buttonNextAttempt.UseVisualStyleBackColor = false;
            this.buttonNextAttempt.Click += new System.EventHandler(this.buttonNextAttempt_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonNewGame.Location = new System.Drawing.Point(3, 7);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(146, 58);
            this.buttonNewGame.TabIndex = 2;
            this.buttonNewGame.Text = "новая игра";
            this.buttonNewGame.UseVisualStyleBackColor = false;
            this.buttonNewGame.Visible = false;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(86)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(666, 327);
            this.Controls.Add(this.InputCommandsPanel);
            this.Controls.Add(this.dataviewGameInfo);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.menuStrip);
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
            this.InputCommandsPanel.ResumeLayout(false);
            this.InputCommandsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel InputCommandsPanel;
        private System.Windows.Forms.Button buttonNextAttempt;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelInputInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn attempt;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn bulls;
        private System.Windows.Forms.DataGridViewTextBoxColumn cows;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNewGame;
    }
}

