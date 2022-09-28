using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            groupBox1.Text = "";
            //groupBox1.
            radioButton1.Text = "玩家大";
            radioButton2.Text = "玩家小";
            radioButton3.Text = "平手";
            button1.Text = "執行";
            label1.Text = "電腦 : ";
            label2.Text = "玩家 : ";
            //radioButton1.AutoCheck = false;
            //radioButton2.AutoCheck = false;
            //radioButton3.AutoCheck = false;
        }

        int a;
        private void group1(object sender, EventArgs e)
        {
            String rdo = ((RadioButton)sender).Name.ToString();
            switch (rdo)
            {
                case "radioButton1":
                    a = 1;
                    break;
                case "radioButton2":
                    a = -1;
                    break;
                case "radioButton3":
                    a = 0;
                    break;

            }
        }

        Random r = new Random();
        int var;
        private void button1_Click(object sender, EventArgs e)
        {
            var com = r.Next(1, 6);
            var player = r.Next(1, 6);
            label1.Text = "電腦 : " + com.ToString();
            label2.Text = "玩家 : " + player.ToString(); 
            if (com > player && a == -1)
            {
                MessageBox.Show("押玩家小: 獲勝");
            }
            else if (a == -1)
            {
                MessageBox.Show("押玩家小: 失敗");
            }
            else if (com == player && a == 0)
            {
                MessageBox.Show("押平手: 獲勝");
            }
            else if (a == 0)
            {
                MessageBox.Show("押平手: 失敗");
            }
            else if (com < player && a == 1)
            {
                MessageBox.Show("押玩家大: 獲勝");
            }
            else
            {
                MessageBox.Show("押玩家大: 失敗");
            }
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }
    }
}
