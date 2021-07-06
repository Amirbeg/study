using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeshProj
{
    public partial class PassEdit : Form
    {
        public PassEdit()
        { 
            InitializeComponent();
            //Инициализация данных по умолчанию
            DigitB.Checked = MainForm.Dig;
            UpperB.Checked = MainForm.Up;
            LowerB.Checked = MainForm.Down;
            SymbolB.Checked = MainForm.Mat;
            KeyLen.Text = Convert.ToString(MainForm.KeyLength);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KeyLen_SelectedItemChanged(object sender, EventArgs e)
        {
            MainForm.KeyLength = Convert.ToInt32(KeyLen.Text);
        }

        private void DigitB_CheckedChanged(object sender, EventArgs e)
        {
            if (DigitB.Checked) MainForm.Dig = true;
            else MainForm.Dig = false;
        }

        private void UpperB_CheckedChanged(object sender, EventArgs e)
        {
            if (UpperB.Checked) MainForm.Up = true;
            else MainForm.Up= false;
        }

        private void LowerB_CheckedChanged(object sender, EventArgs e)
        {
            if (LowerB.Checked) MainForm.Down = true;
            else MainForm.Down  = false;
            
        }

        private void SymbolB_CheckedChanged(object sender, EventArgs e)
        {
            if (SymbolB.Checked) MainForm.Mat = true;
            else MainForm.Mat = false;
        }
    }
}
