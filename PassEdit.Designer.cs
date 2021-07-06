namespace HeshProj
{
    partial class PassEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.KeyLen = new System.Windows.Forms.DomainUpDown();
            this.DigitB = new System.Windows.Forms.CheckBox();
            this.UpperB = new System.Windows.Forms.CheckBox();
            this.LowerB = new System.Windows.Forms.CheckBox();
            this.SymbolB = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(350, 30);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Минимальная длина фразы";
            // 
            // KeyLen
            // 
            this.KeyLen.Items.Add("20");
            this.KeyLen.Items.Add("18");
            this.KeyLen.Items.Add("16");
            this.KeyLen.Items.Add("14");
            this.KeyLen.Items.Add("12");
            this.KeyLen.Items.Add("10");
            this.KeyLen.Items.Add("8");
            this.KeyLen.Location = new System.Drawing.Point(131, 64);
            this.KeyLen.Name = "KeyLen";
            this.KeyLen.Size = new System.Drawing.Size(96, 22);
            this.KeyLen.TabIndex = 2;
            this.KeyLen.SelectedItemChanged += new System.EventHandler(this.KeyLen_SelectedItemChanged);
            // 
            // DigitB
            // 
            this.DigitB.AutoSize = true;
            this.DigitB.Location = new System.Drawing.Point(218, 106);
            this.DigitB.Name = "DigitB";
            this.DigitB.Size = new System.Drawing.Size(78, 21);
            this.DigitB.TabIndex = 3;
            this.DigitB.Text = "Цифры";
            this.DigitB.UseVisualStyleBackColor = true;
            this.DigitB.CheckedChanged += new System.EventHandler(this.DigitB_CheckedChanged);
            // 
            // UpperB
            // 
            this.UpperB.AutoSize = true;
            this.UpperB.Location = new System.Drawing.Point(32, 133);
            this.UpperB.Name = "UpperB";
            this.UpperB.Size = new System.Drawing.Size(140, 21);
            this.UpperB.TabIndex = 4;
            this.UpperB.Text = "Верхний регистр";
            this.UpperB.UseVisualStyleBackColor = true;
            this.UpperB.CheckedChanged += new System.EventHandler(this.UpperB_CheckedChanged);
            // 
            // LowerB
            // 
            this.LowerB.AutoSize = true;
            this.LowerB.Location = new System.Drawing.Point(32, 106);
            this.LowerB.Name = "LowerB";
            this.LowerB.Size = new System.Drawing.Size(136, 21);
            this.LowerB.TabIndex = 5;
            this.LowerB.Text = "Нижний регистр";
            this.LowerB.UseVisualStyleBackColor = true;
            this.LowerB.CheckedChanged += new System.EventHandler(this.LowerB_CheckedChanged);
            // 
            // SymbolB
            // 
            this.SymbolB.AutoSize = true;
            this.SymbolB.Location = new System.Drawing.Point(218, 133);
            this.SymbolB.Name = "SymbolB";
            this.SymbolB.Size = new System.Drawing.Size(89, 21);
            this.SymbolB.TabIndex = 6;
            this.SymbolB.Text = "Символы";
            this.SymbolB.UseVisualStyleBackColor = true;
            this.SymbolB.CheckedChanged += new System.EventHandler(this.SymbolB_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SymbolB);
            this.Controls.Add(this.LowerB);
            this.Controls.Add(this.UpperB);
            this.Controls.Add(this.DigitB);
            this.Controls.Add(this.KeyLen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PassEdit";
            this.Text = "Параметры";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DomainUpDown KeyLen;
        public System.Windows.Forms.CheckBox DigitB;
        public System.Windows.Forms.CheckBox UpperB;
        public System.Windows.Forms.CheckBox LowerB;
        public System.Windows.Forms.CheckBox SymbolB;
    }
}