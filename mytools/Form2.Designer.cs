
namespace mytools
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.gameball = new System.Windows.Forms.PictureBox();
            this.gamepanel = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.background = new System.Windows.Forms.Panel();
            this.gameend = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamepanel)).BeginInit();
            this.background.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameball
            // 
            this.gameball.BackColor = System.Drawing.Color.DodgerBlue;
            this.gameball.Location = new System.Drawing.Point(386, 135);
            this.gameball.Name = "gameball";
            this.gameball.Size = new System.Drawing.Size(33, 31);
            this.gameball.TabIndex = 2;
            this.gameball.TabStop = false;
            // 
            // gamepanel
            // 
            this.gamepanel.BackColor = System.Drawing.Color.Black;
            this.gamepanel.Location = new System.Drawing.Point(335, 389);
            this.gamepanel.Name = "gamepanel";
            this.gamepanel.Size = new System.Drawing.Size(134, 21);
            this.gamepanel.TabIndex = 3;
            this.gamepanel.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // background
            // 
            this.background.Controls.Add(this.label2);
            this.background.Controls.Add(this.label1);
            this.background.Controls.Add(this.gameend);
            this.background.Controls.Add(this.result);
            this.background.Controls.Add(this.gamepanel);
            this.background.Controls.Add(this.gameball);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(800, 450);
            this.background.TabIndex = 4;
            // 
            // gameend
            // 
            this.gameend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gameend.AutoSize = true;
            this.gameend.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameend.Location = new System.Drawing.Point(306, 206);
            this.gameend.Name = "gameend";
            this.gameend.Size = new System.Drawing.Size(325, 64);
            this.gameend.TabIndex = 5;
            this.gameend.Text = "GAME OVER";
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(631, 9);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(106, 31);
            this.result.TabIndex = 4;
            this.result.Text = "Счет: 0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "ESC - выход";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter - перезапуск";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.background);
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gameball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamepanel)).EndInit();
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameball;
        private System.Windows.Forms.PictureBox gamepanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label gameend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}