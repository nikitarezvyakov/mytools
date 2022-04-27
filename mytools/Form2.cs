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
    public partial class Form2 : Form
    {
        private int speed_hor = 2;
        private int speed_ver = 2;
        private int score = 0;

        public Form2()
        {
            InitializeComponent();
            
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            timer.Enabled = true;
            gameend.Visible = false;
         
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            
            gamepanel.Top = background.Bottom - (background.Bottom / 10);
            gameend.Left = (background.Width / 2) - (gameend.Width / 2);
            gameend.Top = (background.Height / 2) - (gameend.Height / 2);
           
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Enter)
            {
                speed_hor = 2;
                speed_ver = 2;
                score = 0;
                gameball.Top = 50;
                gameball.Left = 100;
                result.Text = "Счет: 0";
                gameend.Visible = false;
                timer.Enabled = true;
            }
            
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            gamepanel.Left = Cursor.Position.X - (gamepanel.Width / 2);
          
            gameball.Left += speed_hor;
            gameball.Top += speed_ver;
            if (gameball.Left <= background.Left)
                speed_hor *= -1;
            if (gameball.Right >= background.Right)
                speed_hor *= -1;
            if (gameball.Top <= background.Top)
                speed_ver *= -1;
            if (gameball.Bottom >= background.Bottom)
            {
                timer.Enabled = false;
                gameend.Visible = true;
            }
            if (gameball.Bottom >= gamepanel.Top && gameball.Bottom <= gamepanel.Bottom
                && gameball.Left >= gamepanel.Left && gameball.Right <= gamepanel.Right)
            {
                speed_hor += 1;
                speed_ver += 1;
                speed_ver *= -1;
                score++;
                result.Text = "Счет:" + score.ToString();
                Random randomcolor = new Random();
                background.BackColor = Color.FromArgb(randomcolor.Next(120, 250),
                    randomcolor.Next(120, 250), randomcolor.Next(120, 250));
                


            }
        }
    }
}
