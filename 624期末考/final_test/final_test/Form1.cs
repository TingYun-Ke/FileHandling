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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "第一題";
            button2.Text = "第二題";
            button3.Text = "第三題";
            button4.Text = "第四題";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new Form2();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f2 = new Form3();
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f3 = new Form4();
            f3.StartPosition = FormStartPosition.CenterScreen;
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f4 = new Form5();
            f4.StartPosition = FormStartPosition.CenterScreen;
            f4.Show();
        }
    }
}
