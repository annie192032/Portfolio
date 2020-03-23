using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Form1 : Form
    {
        public int x = 4; //球水平移動的速度
        public int y = 4; //球垂直移動的速度
        int mdx; //滑鼠點的地方
        int score = 0;
        
        public Form1()
        {
            InitializeComponent();           
        }
        private void Form1_Load(object sender, EventArgs e)
        {            
            timer.Start();           
        }
        private void picLine_MouseDown(object sender, MouseEventArgs e) //滑鼠只能水平移動
        {
            mdx = e.X;
        }
        private void picLine_MouseMove(object sender, MouseEventArgs e) //板子的拖曳範圍
        {
            if (e.Button == MouseButtons.Left)
            {
                int Lx = picLine.Left + (e.X - mdx);

                if (Lx < 0)
                    Lx = 0; //不超過左邊框

                if (Lx > this.ClientSize.Width - picLine.Width) //不超過右邊框
                    Lx = this.ClientSize.Width - picLine.Width;
                picLine.Left = Lx;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            picBall.Left += x;
            picBall.Top += y;
            Random r = new Random(); //顏色隨機變換
            if (picBall.Bottom > picLine.Top) 
            {
                int c = (picBall.Left + picBall.Right) / 2;
                if (c >= picLine.Left && c <= picLine.Right)
                {
                    x += 2;
                    y += 2;

                    y = -y; //反彈
                    x = -x;
                   
                    playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
                    score++;
                    lblScore.Text = score.ToString();
                }
            }  
            if (picBall.Left <= playground.Left)
            { 
                x = - x;
                playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
            }
            if (picBall.Top <= playground.Top)
            {
                y = -y;
                playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
            }
            if (picBall.Right >= playground.Right)
            {
                x = -x;
                playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
            }
            
            if ((picBall.Top + picBall.Height) >= playground.Bottom)  //跑到視窗外，就結束
            {
                timer.Stop();
                MessageBox.Show("遊戲結束");
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picBall.Top = 100;
            picBall.Left = 50;
            score = 0;
            lblScore.Text = "0";
            timer.Start();
        }
    }
}
