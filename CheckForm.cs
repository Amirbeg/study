using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;
using CryptoPro.Sharpei;

namespace HeshProj
{
    public partial class CheckForm : Form
    {
        OpenFileDialog openFileDialog1;
        OpenFileDialog openFileDialog2;

        ArgumentException ex;
        public CheckForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //Выбор файла с данными для хеширования
        private void BrowseInf_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Все файлы (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                InFile.Text = openFileDialog1.FileName;
        }


        //Выбор файла с уже вычисленным хэш-значением и случайной примесью, при наличии
        private void BrowseOuf_Click(object sender, EventArgs e)
        {
            openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Filter = "Все файлы (*.*)|*.*";
            openFileDialog2.CheckFileExists = true;
            openFileDialog2.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog2.RestoreDirectory = true;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
                OuFile.Text = openFileDialog2.FileName;
        }


        //Проверка целостности файла
        private void VerifyBut_Click(object sender, EventArgs e)
        {
            string sourceFile = InFile.Text;
            string sourceFile1 = OuFile.Text;
            byte[] buffer = null;
            byte[] randBytes = new byte[8];
            byte[] hashValue;
            HashAlgorithm myhash = HashAlgorithm.Create("GOST3411");
            if (InFile.Text.Length > 0 && OuFile.Text.Length > 0 && File.Exists(InFile.Text) && File.Exists(OuFile.Text))
            {
                using (FileStream inStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                {
                    if (PassFrase.Checked)
                    {
                        //Считывание случаной примеси
                        using (FileStream inStream1 = new FileStream(sourceFile1, FileMode.Open, FileAccess.Read))
                        {
                            inStream1.Read(randBytes, 0, 8);
                        }

                        //Генерация ключа из парольной фразы и примеси
                        Gost28147CryptoServiceProvider gostCSP = new
                        Gost28147CryptoServiceProvider();
                        byte[] pwd = Encoding.UTF8.GetBytes(PassFraseText.Text);
                        byte[] bufkey = new byte[pwd.Length + randBytes.Length];
                        pwd.CopyTo(bufkey, 0);
                        randBytes.CopyTo(bufkey, pwd.Length);
                        gostCSP.ByDeriveBytes(bufkey);
                        buffer = new byte[inStream.Length + bufkey.Length];
                        bufkey.CopyTo(buffer, 0);
                        inStream.Read(buffer, bufkey.Length, (int)inStream.Length);

                        //вычисление хэш-значения
                        hashValue = myhash.ComputeHash(buffer);
                    }
                    else
                    {
                        //вычисление хэш при отсутствии примеси и парольной фразы
                        buffer = new byte[inStream.Length];
                        inStream.Read(buffer, 0, (int)inStream.Length);
                        hashValue = myhash.ComputeHash(buffer);
                    }
                    string hashnew = "";
                    string oldhashv = "";

                    //Преобразование данных 
                    for (int i = 0; i < hashValue.Length; i++)
                        hashnew += Convert.ToString(hashValue[i], 16);
                    StreamReader sr = new StreamReader(sourceFile1);
                    if (PassFrase.Checked)
                    {
                        for (int i = 0; i < 8; ++i) sr.Read();
                             oldhashv = sr.ReadToEnd();
                    }
                    else
                    {
                        oldhashv = sr.ReadToEnd();
                    }
                    

                    //Сравнений хэш-значений
                    if (oldhashv == hashnew) CheckResult.Text = "Файл исправен";
                    else CheckResult.Text = "Файл не исправен или неправильная парольная фраза";

                }
            }
            else
            {
                MessageBox.Show("Ошибка: Один из файлов пустой или такого файла не существует!.","Error!",  MessageBoxButtons.OK);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PassFrase_CheckedChanged(object sender, EventArgs e)
        {
            if (PassFrase.Checked)
            {
                PassFraseText.Enabled = true;
            }
            else
            {
                PassFraseText.Enabled = false;
            }
        }
    }
}
