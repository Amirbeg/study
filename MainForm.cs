using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using CryptoPro.Sharpei;

namespace HeshProj
{
    public partial class MainForm : Form
    {
        OpenFileDialog openFileDialog1;
        OpenFileDialog openFileDialog2;
        ArgumentException ex;
        byte[] randBytes;
        public static bool Up=true, Down=true, Dig=true, Mat=true;
        public static int KeyLength = 8;
        PassEdit passEdit;
        string test1 = "73657479622032333D6874676Е656С202С6567617373656D2073692073696854";
        string test2 = "747962203035203D206874676Е656С20736168206567617373656D206С616Е696769726F206568742065736F70707553";
        int testnum = 1;
        public byte[] bufkey;
        public MainForm()
        {
            InitializeComponent();
            
        }





        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            passEdit = new PassEdit();
            passEdit.ShowDialog();
        }

        private void ModeButtonFile_CheckedChanged(object sender, EventArgs e)
        {
            if (ModeButtonFile.Checked)
            {
                InFile.Enabled = true;
                BrowseInf.Enabled = true;
                Hash.Enabled = (InFile.Text.Length > 0 && File.Exists(InFile.Text));
            }
            else{
                InFile.Enabled = false;
                BrowseInf.Enabled = false;
            }
        }

        private void ModeButtonText_CheckedChanged(object sender, EventArgs e)
        {
            if (ModeButtonText.Checked)
            {
                InText.Enabled = true;
                Hash.Enabled = true;
            }
            else
            {
                InText.Enabled = false;
                Hash.Enabled = false;
            }
        }

        private void FileSave_CheckedChanged(object sender, EventArgs e)
        {
            if (FileSave.Checked)
            {
                OuFile.Enabled = true;
                BrowseOuf.Enabled = true;
                Hash.Enabled = false;
            }
            else
            {
                OuFile.Enabled = false;
                BrowseOuf.Enabled = false;
                Hash.Enabled = (InFile.Text.Length > 0 && File.Exists(InFile.Text)) || InText.Text.Length > 0;
            }
        }

        private void PassFrase_CheckedChanged(object sender, EventArgs e)
        {
            if (PassFrase.Checked)
            {
                PassFraseBox1.Enabled = true;
                PassFraseBox2.Enabled = true;
                PassFraseSettingBut.Enabled = true;
            }
            else
            {
                PassFraseBox1.Enabled = false;
                PassFraseBox2.Enabled = false;
                PassFraseSettingBut.Enabled = false;
            }
        }

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

        private void FileModeBox_TextChanged(object sender, EventArgs e)
        {
            
            Hash.Enabled = InFile.Text.Length > 0 &&
            File.Exists(InFile.Text);
      

        }

        private void InText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void HeshBox_TextChanged(object sender, EventArgs e)
        {
            
        }

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

        private void Hash_Click(object sender, EventArgs e)
        {

        }

        private void Verify_Click(object sender, EventArgs e)
        {
            CheckForm checkForm = new CheckForm();
            checkForm.Show();
        }

        private void OuFile_TextChanged(object sender, EventArgs e)
        {
            if (OuFile.Text.Length > 0)
            {
                Hash.Enabled = (InFile.Text.Length > 0 && File.Exists(InFile.Text)) || InText.Text.Length > 0;
            }
        }


        ///Функция хеширования 
        public void Hashh()
        {
           
            // Создаем объект для хэширования.
            HashAlgorithm myhash = HashAlgorithm.Create("GOST3411");
            
           // Gost3411 gost3411 = new Gost3411CryptoServiceProvider();

            // Открываем входной файл и считываем его содержимое в буфер.
            byte[] buffer = null;
            if (ModeButtonFile.Checked) //Файловый режим работы
            {
                string sourceFile = InFile.Text;
                using (FileStream inStream = new FileStream(sourceFile,FileMode.Open, FileAccess.Read))
                {
                    if (inStream.Length > int.MaxValue)
                    {
                        MessageBox.Show(ex.Message, "Ошибка: Файл слишком большой.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (PassFrase.Checked)
                    {
                        buffer = new byte[inStream.Length + bufkey.Length];
                        bufkey.CopyTo(buffer, 0);
                        inStream.Read(buffer, bufkey.Length, (int)inStream.Length);
                    }
                    else
                    {
                        buffer = new byte[inStream.Length];
                        inStream.Read(buffer, 0, (int)inStream.Length);
                    }
                    
                }
                if (FileSave.Checked)
                {
                    Verify.Enabled = true;
                }
            }
            else //Текстовый режим работы
            {
                //При пустой строке запуск с данными из документации
                //При повторном запуске с данными из теста они сменятся данными следующего теста
                if (InText.Text.Length == 0 || InText.Text == test1 || InText.Text == test2)
                {

                    //При повторных запусках данные меняются
                    if (testnum++ % 2 == 1) InText.Text = test1;
                    else InText.Text = test2;
                }
                //При наличии парольной фразы добавляем ключ к данным
                if (PassFrase.Checked)
                {
                    byte[] buf;
                    buf = Encoding.UTF8.GetBytes(InText.Text);
                    buffer = new byte[buf.Length + bufkey.Length];
                    bufkey.CopyTo(buffer, 0);
                    buf.CopyTo(buffer, bufkey.Length);
                }
                else
                {
                    byte[] buf;
                    buf = Encoding.UTF8.GetBytes(InText.Text);
                    buffer = new byte[buf.Length];
                    buf.CopyTo(buffer, 0);
                }
                
            }
            // Вычисляем хэш от всех прочитанных данных.
            byte[] hashValue = myhash.ComputeHash(buffer);

           // byte[] result = gost3411.ComputeHash(buffer);

            // отображение шифротекста
            HeshBox.Clear();
            for (int i = 0; i < hashValue.Length; i++)
                HeshBox.Text += Convert.ToString(hashValue[i],16);
            /* HeshBox.Text += "\n";
             for (int i = 0; i < hashValue.Length; i++)
                 HeshBox.Text += Convert.ToString(result[i], 16);*/

            //Если хэш-значение сохраняется в файле, то сохраняем случайную примесь в файл вместе с хэш
            if (FileSave.Checked)
            {
                if (ModeButtonFile.Checked && PassFrase.Checked)
                {
                    using (FileStream ouStream = new FileStream(OuFile.Text, FileMode.Truncate, FileAccess.Write))
                    {
                        ouStream.Write(randBytes, 0, randBytes.Length);
                    }
                }
                using (StreamWriter sw = new StreamWriter(OuFile.Text,true))
                {
                    
                   for (int i = 0; i < hashValue.Length; i++)
                       sw.Write(Convert.ToString(hashValue[i], 16));
                   
                }
                

            }
            // Освобождаем ресурсы.
            myhash.Clear();
        }

        //Функция генерации ключа из парольной фразы
        public byte[] GetSecretKey()
        {
            Gost28147CryptoServiceProvider gostCSP = new
                    Gost28147CryptoServiceProvider();
            randBytes = new byte[8];
            RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
            rand.GetBytes(randBytes);
            byte[] pwd = Encoding.UTF8.GetBytes(PassFraseBox1.Text);
            byte[] buf = new byte[pwd.Length + randBytes.Length];
            pwd.CopyTo(buf, 0);
            randBytes.CopyTo(buf, pwd.Length);
            gostCSP.ByDeriveBytes(buf);
            return buf;
        }


        //Событие при клике кнопки "Хэшировать"
        //Проверяется соответствие парольной фразы сложности
        //Далее получаем из фразы ключ добавляемый к хешируемым данным
        //При отсутствии фразы просто хэшируем данные 
        private void Hash_Click_1(object sender, EventArgs e)
        {

            if (PassFrase.Checked & PassFraseBox1.Text != "" & PassFraseBox2.Text != "")
            {
                bool UpLetter = false, DownLetter = false, Digit = false, Math = false;
                try
                {
                    // проверка совпадения парольной фразы и ее подтверждения
                    if (PassFraseBox1.Text != PassFraseBox2.Text)
                        throw ex = new ArgumentException("Парольная фраза и ее подтверждение не совпадают.");
                    if (PassFraseBox1.Text.Length < KeyLength)
                        throw ex = new ArgumentException("Парольная фраза короче требуемой длины.");
                    // проверка сложности введенной парольной фразы
                    for (int i = 0; i < PassFraseBox1.Text.Length; i++) 
                    {
                        // проверка очередного символа парольной фразы
                        UpLetter |= Char.IsUpper(PassFraseBox1.Text[i]);
                        DownLetter |= Char.IsLower(PassFraseBox1.Text[i]);
                        Digit |= Char.IsDigit(PassFraseBox1.Text[i]);
                        Math |= Char.IsSymbol(PassFraseBox1.Text[i]);
                    }

                    if (!Up) UpLetter = true;
                    if (!Down) DownLetter = true;
                    if (!Dig) Digit = true;
                    if (!Mat) Math = true;
                    // проверка наличия всех четырех групп символов
                    if (!UpLetter || !DownLetter || !Digit || !Math)
                        throw ex = new ArgumentException("Парольная фраза не соответствует условиям сложности.");
                    // проверка длины парольной фразы
                    if (PassFraseBox1.Text.Length < KeyLength)
                        throw ex = new ArgumentException("Парольная фраза короче требуемой длины.");

                    bufkey = GetSecretKey();
                    Hashh();
                }
                catch (CryptographicException ex)
                {
                    // вывод сообщения об ошибке
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // обработка остальных ошибок
                catch (Exception ex)
                {
                    // вывод сообщения об ошибке
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    // проверка длины парольной фразы
                    if (PassFraseBox1.Text.Length< KeyLength && PassFrase.Checked )
                        throw ex = new ArgumentException("Парольная фраза короче требуемой длины.");
                    Hashh();
                }
                catch (CryptographicException ex)
                {
                    // вывод сообщения об ошибке
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // обработка остальных ошибок
                catch (Exception ex)
                {
                    // вывод сообщения об ошибке
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
    }
}

