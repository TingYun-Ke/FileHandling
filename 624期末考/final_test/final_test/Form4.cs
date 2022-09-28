using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace final_test
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            button1.Text = "瀏覽";
            button2.Text = "清空並儲存";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
            FileInfo f = new FileInfo(openFileDialog1.FileName);
            StreamReader sr = f.OpenText();
            int count = 0;
            while (sr.Peek() >= 0)
            {
                listBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo(textBox1.Text);
            StreamWriter sw = f.CreateText();
            for (int i=0; i<listBox1.Items.Count; i++)
            {
                
            }
            sw.Close();
            listBox1.Items.Clear();
        }
    }
}
