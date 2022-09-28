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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            label1.Text = "帳號 : ";
            label2.Text = "密碼 : ";
            button1.Text = "登入";
        }
        static private String[] account = { "abc", "aaa", "ccc" };
        static private String[] password = { "123", "111", "222" };

        private void button1_Click(object sender, EventArgs e)
        {
            bool succeed = false;
            for (int i = 0; i < account.Length; i++)
            {
                if (textBox1.Text == account[i] && textBox2.Text == password[i])
                {
                    succeed = true;
                    Form f = new Form6();
                    f.Show();
                }
            }
            if (!succeed)
            {
                MessageBox.Show("登入失敗");
            }
        }
    }
}
