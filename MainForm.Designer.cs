namespace HeshProj
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModeButtonText = new System.Windows.Forms.RadioButton();
            this.ModeButtonFile = new System.Windows.Forms.RadioButton();
            this.FileSave = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Hash = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HeshBox = new System.Windows.Forms.TextBox();
            this.PassFrase = new System.Windows.Forms.CheckBox();
            this.PassFraseSettingBut = new System.Windows.Forms.Button();
            this.PassFraseBox2 = new System.Windows.Forms.TextBox();
            this.PassFraseBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OuFile = new System.Windows.Forms.TextBox();
            this.BrowseInf = new System.Windows.Forms.Button();
            this.InFile = new System.Windows.Forms.TextBox();
            this.Verify = new System.Windows.Forms.Button();
            this.BrowseOuf = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // InText
            // 
            this.InText.Enabled = false;
            this.InText.Location = new System.Drawing.Point(156, 191);
            this.InText.Multiline = true;
            this.InText.Name = "InText";
            this.InText.Size = new System.Drawing.Size(442, 59);
            this.InText.TabIndex = 40;
            this.InText.TextChanged += new System.EventHandler(this.InText_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Текст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Исходный  файл";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ModeButtonText);
            this.groupBox1.Controls.Add(this.ModeButtonFile);
            this.groupBox1.Location = new System.Drawing.Point(33, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 62);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим работы";
            // 
            // ModeButtonText
            // 
            this.ModeButtonText.AutoSize = true;
            this.ModeButtonText.Location = new System.Drawing.Point(123, 28);
            this.ModeButtonText.Name = "ModeButtonText";
            this.ModeButtonText.Size = new System.Drawing.Size(100, 21);
            this.ModeButtonText.TabIndex = 1;
            this.ModeButtonText.TabStop = true;
            this.ModeButtonText.Text = "Текстовый";
            this.ModeButtonText.UseVisualStyleBackColor = true;
            this.ModeButtonText.CheckedChanged += new System.EventHandler(this.ModeButtonText_CheckedChanged);
            // 
            // ModeButtonFile
            // 
            this.ModeButtonFile.AutoSize = true;
            this.ModeButtonFile.Location = new System.Drawing.Point(7, 28);
            this.ModeButtonFile.Name = "ModeButtonFile";
            this.ModeButtonFile.Size = new System.Drawing.Size(99, 21);
            this.ModeButtonFile.TabIndex = 0;
            this.ModeButtonFile.TabStop = true;
            this.ModeButtonFile.Text = "Файловый";
            this.ModeButtonFile.UseVisualStyleBackColor = true;
            this.ModeButtonFile.CheckedChanged += new System.EventHandler(this.ModeButtonFile_CheckedChanged);
            // 
            // FileSave
            // 
            this.FileSave.AutoSize = true;
            this.FileSave.Location = new System.Drawing.Point(36, 258);
            this.FileSave.Name = "FileSave";
            this.FileSave.Size = new System.Drawing.Size(149, 21);
            this.FileSave.TabIndex = 36;
            this.FileSave.Text = "Сохранить в файл";
            this.FileSave.UseVisualStyleBackColor = true;
            this.FileSave.CheckedChanged += new System.EventHandler(this.FileSave_CheckedChanged);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(468, 463);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 35;
            this.button4.Text = "Закрыть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Hash
            // 
            this.Hash.AutoSize = true;
            this.Hash.Enabled = false;
            this.Hash.Location = new System.Drawing.Point(83, 463);
            this.Hash.Name = "Hash";
            this.Hash.Size = new System.Drawing.Size(102, 27);
            this.Hash.TabIndex = 34;
            this.Hash.Text = "Хешировать";
            this.Hash.UseVisualStyleBackColor = true;
            this.Hash.Click += new System.EventHandler(this.Hash_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Хеш-значение";
            // 
            // HeshBox
            // 
            this.HeshBox.Enabled = false;
            this.HeshBox.Location = new System.Drawing.Point(226, 385);
            this.HeshBox.Multiline = true;
            this.HeshBox.Name = "HeshBox";
            this.HeshBox.ReadOnly = true;
            this.HeshBox.Size = new System.Drawing.Size(372, 72);
            this.HeshBox.TabIndex = 32;
            this.HeshBox.TextChanged += new System.EventHandler(this.HeshBox_TextChanged);
            // 
            // PassFrase
            // 
            this.PassFrase.AutoSize = true;
            this.PassFrase.Location = new System.Drawing.Point(36, 329);
            this.PassFrase.Name = "PassFrase";
            this.PassFrase.Size = new System.Drawing.Size(149, 21);
            this.PassFrase.TabIndex = 31;
            this.PassFrase.Text = "Парольная фраза";
            this.PassFrase.UseVisualStyleBackColor = true;
            this.PassFrase.CheckedChanged += new System.EventHandler(this.PassFrase_CheckedChanged);
            // 
            // PassFraseSettingBut
            // 
            this.PassFraseSettingBut.AutoSize = true;
            this.PassFraseSettingBut.Enabled = false;
            this.PassFraseSettingBut.Location = new System.Drawing.Point(468, 327);
            this.PassFraseSettingBut.Name = "PassFraseSettingBut";
            this.PassFraseSettingBut.Size = new System.Drawing.Size(95, 27);
            this.PassFraseSettingBut.TabIndex = 30;
            this.PassFraseSettingBut.Text = "Параметры";
            this.PassFraseSettingBut.UseVisualStyleBackColor = true;
            this.PassFraseSettingBut.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // PassFraseBox2
            // 
            this.PassFraseBox2.Enabled = false;
            this.PassFraseBox2.Location = new System.Drawing.Point(226, 357);
            this.PassFraseBox2.Multiline = true;
            this.PassFraseBox2.Name = "PassFraseBox2";
            this.PassFraseBox2.PasswordChar = '*';
            this.PassFraseBox2.Size = new System.Drawing.Size(236, 22);
            this.PassFraseBox2.TabIndex = 29;
            // 
            // PassFraseBox1
            // 
            this.PassFraseBox1.Enabled = false;
            this.PassFraseBox1.Location = new System.Drawing.Point(226, 329);
            this.PassFraseBox1.Multiline = true;
            this.PassFraseBox1.Name = "PassFraseBox1";
            this.PassFraseBox1.PasswordChar = '*';
            this.PassFraseBox1.Size = new System.Drawing.Size(236, 22);
            this.PassFraseBox1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Подтверждение ";
            // 
            // OuFile
            // 
            this.OuFile.Enabled = false;
            this.OuFile.Location = new System.Drawing.Point(226, 256);
            this.OuFile.Multiline = true;
            this.OuFile.Name = "OuFile";
            this.OuFile.Size = new System.Drawing.Size(372, 22);
            this.OuFile.TabIndex = 26;
            this.OuFile.TextChanged += new System.EventHandler(this.OuFile_TextChanged);
            // 
            // BrowseInf
            // 
            this.BrowseInf.AutoSize = true;
            this.BrowseInf.Enabled = false;
            this.BrowseInf.Location = new System.Drawing.Point(159, 157);
            this.BrowseInf.Name = "BrowseInf";
            this.BrowseInf.Size = new System.Drawing.Size(120, 28);
            this.BrowseInf.TabIndex = 25;
            this.BrowseInf.Text = "Выбор файла";
            this.BrowseInf.UseVisualStyleBackColor = true;
            this.BrowseInf.Click += new System.EventHandler(this.BrowseInf_Click);
            // 
            // InFile
            // 
            this.InFile.Enabled = false;
            this.InFile.Location = new System.Drawing.Point(159, 129);
            this.InFile.Multiline = true;
            this.InFile.Name = "InFile";
            this.InFile.Size = new System.Drawing.Size(439, 22);
            this.InFile.TabIndex = 24;
            this.InFile.TextChanged += new System.EventHandler(this.FileModeBox_TextChanged);
            // 
            // Verify
            // 
            this.Verify.AutoSize = true;
            this.Verify.Location = new System.Drawing.Point(246, 463);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(170, 27);
            this.Verify.TabIndex = 41;
            this.Verify.Text = "Проверка целостности";
            this.Verify.UseVisualStyleBackColor = true;
            this.Verify.Click += new System.EventHandler(this.Verify_Click);
            // 
            // BrowseOuf
            // 
            this.BrowseOuf.AutoSize = true;
            this.BrowseOuf.Enabled = false;
            this.BrowseOuf.Location = new System.Drawing.Point(226, 281);
            this.BrowseOuf.Name = "BrowseOuf";
            this.BrowseOuf.Size = new System.Drawing.Size(108, 27);
            this.BrowseOuf.TabIndex = 42;
            this.BrowseOuf.Text = "Выбор файла";
            this.BrowseOuf.UseVisualStyleBackColor = true;
            this.BrowseOuf.Click += new System.EventHandler(this.BrowseOuf_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 502);
            this.Controls.Add(this.BrowseOuf);
            this.Controls.Add(this.Verify);
            this.Controls.Add(this.InText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FileSave);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Hash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeshBox);
            this.Controls.Add(this.PassFrase);
            this.Controls.Add(this.PassFraseSettingBut);
            this.Controls.Add(this.PassFraseBox2);
            this.Controls.Add(this.PassFraseBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OuFile);
            this.Controls.Add(this.BrowseInf);
            this.Controls.Add(this.InFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовой проект Курбанов А.К.";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TextBox InText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ModeButtonText;
        private System.Windows.Forms.RadioButton ModeButtonFile;
        private System.Windows.Forms.CheckBox FileSave;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Hash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeshBox;
        private System.Windows.Forms.CheckBox PassFrase;
        private System.Windows.Forms.Button PassFraseSettingBut;
        private System.Windows.Forms.TextBox PassFraseBox2;
        private System.Windows.Forms.TextBox PassFraseBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OuFile;
        private System.Windows.Forms.Button BrowseInf;
        private System.Windows.Forms.TextBox InFile;
        private System.Windows.Forms.Button Verify;
        private System.Windows.Forms.Button BrowseOuf;
    }
}

