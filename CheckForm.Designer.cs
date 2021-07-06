namespace HeshProj
{
    partial class CheckForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowseInf = new System.Windows.Forms.Button();
            this.InFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BrowseOuf = new System.Windows.Forms.Button();
            this.OuFile = new System.Windows.Forms.TextBox();
            this.VerifyBut = new System.Windows.Forms.Button();
            this.PassFrase = new System.Windows.Forms.CheckBox();
            this.PassFraseText = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Результат проверки";
            // 
            // CheckResult
            // 
            this.CheckResult.Location = new System.Drawing.Point(186, 219);
            this.CheckResult.Name = "CheckResult";
            this.CheckResult.ReadOnly = true;
            this.CheckResult.Size = new System.Drawing.Size(432, 22);
            this.CheckResult.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Исходный  файл";
            // 
            // BrowseInf
            // 
            this.BrowseInf.AutoSize = true;
            this.BrowseInf.Location = new System.Drawing.Point(142, 77);
            this.BrowseInf.Name = "BrowseInf";
            this.BrowseInf.Size = new System.Drawing.Size(166, 28);
            this.BrowseInf.TabIndex = 40;
            this.BrowseInf.Text = "Выбор файла";
            this.BrowseInf.UseVisualStyleBackColor = true;
            this.BrowseInf.Click += new System.EventHandler(this.BrowseInf_Click);
            // 
            // InFile
            // 
            this.InFile.Location = new System.Drawing.Point(142, 49);
            this.InFile.Multiline = true;
            this.InFile.Name = "InFile";
            this.InFile.Size = new System.Drawing.Size(476, 22);
            this.InFile.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Файл с хэш";
            // 
            // BrowseOuf
            // 
            this.BrowseOuf.AutoSize = true;
            this.BrowseOuf.Location = new System.Drawing.Point(142, 139);
            this.BrowseOuf.Name = "BrowseOuf";
            this.BrowseOuf.Size = new System.Drawing.Size(166, 28);
            this.BrowseOuf.TabIndex = 43;
            this.BrowseOuf.Text = "Выбор файла";
            this.BrowseOuf.UseVisualStyleBackColor = true;
            this.BrowseOuf.Click += new System.EventHandler(this.BrowseOuf_Click);
            // 
            // OuFile
            // 
            this.OuFile.Location = new System.Drawing.Point(142, 111);
            this.OuFile.Multiline = true;
            this.OuFile.Name = "OuFile";
            this.OuFile.Size = new System.Drawing.Size(476, 22);
            this.OuFile.TabIndex = 42;
            // 
            // VerifyBut
            // 
            this.VerifyBut.Location = new System.Drawing.Point(233, 258);
            this.VerifyBut.Name = "VerifyBut";
            this.VerifyBut.Size = new System.Drawing.Size(99, 25);
            this.VerifyBut.TabIndex = 45;
            this.VerifyBut.Text = "Проверить";
            this.VerifyBut.UseVisualStyleBackColor = true;
            this.VerifyBut.Click += new System.EventHandler(this.VerifyBut_Click);
            // 
            // PassFrase
            // 
            this.PassFrase.AutoSize = true;
            this.PassFrase.Location = new System.Drawing.Point(23, 183);
            this.PassFrase.Name = "PassFrase";
            this.PassFrase.Size = new System.Drawing.Size(149, 21);
            this.PassFrase.TabIndex = 46;
            this.PassFrase.Text = "Парольная фраза";
            this.PassFrase.UseVisualStyleBackColor = true;
            this.PassFrase.CheckedChanged += new System.EventHandler(this.PassFrase_CheckedChanged);
            // 
            // PassFraseText
            // 
            this.PassFraseText.Enabled = false;
            this.PassFraseText.Location = new System.Drawing.Point(178, 182);
            this.PassFraseText.Name = "PassFraseText";
            this.PassFraseText.PasswordChar = '*';
            this.PassFraseText.Size = new System.Drawing.Size(179, 22);
            this.PassFraseText.TabIndex = 47;
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 295);
            this.Controls.Add(this.PassFraseText);
            this.Controls.Add(this.PassFrase);
            this.Controls.Add(this.VerifyBut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BrowseOuf);
            this.Controls.Add(this.OuFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BrowseInf);
            this.Controls.Add(this.InFile);
            this.Controls.Add(this.CheckResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CheckForm";
            this.Text = "Проверка целостности";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CheckResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BrowseInf;
        private System.Windows.Forms.TextBox InFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BrowseOuf;
        private System.Windows.Forms.TextBox OuFile;
        private System.Windows.Forms.Button VerifyBut;
        private System.Windows.Forms.CheckBox PassFrase;
        private System.Windows.Forms.TextBox PassFraseText;
    }
}