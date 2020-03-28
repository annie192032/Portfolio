using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_6
{
    public partial class Form1 : Form
    {
        Color onColor = Color.Coral; // 將onColor的顏色設為咖啡色
        Color offColor = Color.Yellow; // 將offColor的顏色設為黃色
        int seconds, count; //紀錄遊戲時間以及按鍵的次數
        Button[] Buttons = new Button[10]; //儲存按鈕的陣列(陣列第一個元素沒有用到)
        int[] btnState = new int[10];   //紀錄每個按鈕的狀態(陣列第一個元素沒有用到)
        int[,] ChangeCells = {{-1,-1,-1,-1,-1},  //第一列是無用的數值
                                    {1, 2, 4, 5, -1},  //按鈕1影響按鈕1, 2, 4, 5
	                   {2, 1, 3, -1, -1}, //按鈕2影響按鈕2, 1, 3
	                   {3, 2, 5, 6, -1},  //按鈕3影響按鈕3, 2, 5, 6
	                   {4, 1, 7, -1, -1}, //按鈕4影響按鈕4, 1, 7
	                   {5, 2, 4, 6, 8},   //按鈕5影響按鈕5, 2, 4, 6, 8
	                   {6, 3, 9, -1, -1}, //按鈕6影響按鈕6, 3, 9
	                   {7, 4, 5, 8, -1},  //按鈕7影響按鈕7, 4, 5, 8
	                   {8, 7, 9, -1, -1}, //按鈕8影響按鈕8, 7, 9
	                   {9, 5, 6, 8, -1},}; //按鈕9影響按鈕9, 5, 6, 8

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
