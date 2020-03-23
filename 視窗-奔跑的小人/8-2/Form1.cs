using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_2
{
    public partial class Form1 : Form
    {
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[index];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 3;
            if (pictureBox1.Left < 0) pictureBox1.Left = this.Size.Width;

            index++;
            if (index >= imageList1.Images.Count) index = 0;

            pictureBox1.Image = imageList1.Images[index];
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = 100 - hScrollBar1.Value;
        }
    }
}
