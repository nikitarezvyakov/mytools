using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mytools
{
    public partial class Form1 : Form
    {
        int count = 0;
        Random rnd;
        char[] specchar = new char[] { '!', '@', '#', '$', '%', '*', '&', '?', '№' };
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа, где представлены некоторые полезные функции", " О программе");
        }

        private void plusscount_Click(object sender, EventArgs e)
        {
            count++;
            scorecount.Text = count.ToString();
        }

        private void minuscount_Click(object sender, EventArgs e)
        {
            count--;
            scorecount.Text = count.ToString();
        }

        private void resetcount_Click(object sender, EventArgs e)
        {
            count = 0;
            scorecount.Text = count.ToString();
        }

        private void startgenerator_Click(object sender, EventArgs e)
        {
            int score;
            try
            {
                score = rnd.Next(Convert.ToInt32(minvaluegen.Value), Convert.ToInt32(maxvaluegen.Value) + 1);
                scoregenerator.Text = score.ToString();
                Textboxrandm.AppendText(score + "\r\n");
            }
            catch
            {
                MessageBox.Show("Неправильно введены параметры!","Ошибка");
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            Textboxrandm.Clear();
        }

        private void вставитьДатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadwrite.AppendText(DateTime.Now.ToShortDateString() + "\r\n");
        }

        private void addtime_Click(object sender, EventArgs e)
        {
            notepadwrite.AppendText(DateTime.Now.ToShortTimeString() + "\r\n");
        }

        private void addscoreandtime_Click(object sender, EventArgs e)
        {
            notepadwrite.AppendText(DateTime.Now.ToShortDateString() 
                + " " + DateTime.Now.ToShortTimeString() + "\r\n");
        }

        private void notepadsave_Click(object sender, EventArgs e)
        {
            notepadwrite.SaveFile("notepad.rtf");
        }

        private void notepadload_Click(object sender, EventArgs e)
        {
            try
            {
                notepadwrite.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке");
            }

        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notepadwrite.Clear();
        }

        private void createpass_Click(object sender, EventArgs e)
        {
            if (checkedListpass.CheckedItems.Count == 0) return;
            string passworld = "";
            for ( int i = 0; i < numericupdownpass.Value;i++)
            {
                int n = rnd.Next(0, checkedListpass.CheckedItems.Count);
                string s = checkedListpass.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифры":
                        passworld += rnd.Next(10).ToString();
                        break;

                    case "Прописные буквы":
                        passworld += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    case "Заглавные буквы":
                        passworld += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Специальные символы ( !, @, #, $, %, *, &, ?, №)":
                        passworld += specchar[ rnd.Next(specchar.Length)];
                        break;
                }
                textBoxpass.Text = passworld.ToString();
            }

        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBoxpass.Clear();
        }

        private void copybutpass_Click(object sender, EventArgs e)
        {
            try { Clipboard.SetText(textBoxpass.Text); }
            catch
                { MessageBox.Show("Нечего копировать!","Ошибка!"); };
            

        }

        private void запуститьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        private void подробнееОбУтилитахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Генератор паролей ( min длина = 4, max длина = 25), простенький блокнот, куда " +
                "можно что-то записывать, копировать, сохранять и загружать, бесполезный счетчик и генератор случайных чисел");
        }

        private void подробнееОИгреToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Очень просто пинг-понг, который работает очень странной, но пусть будет");
        }
    }
}
