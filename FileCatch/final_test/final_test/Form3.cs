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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            button1.Text = "瀏覽";
            label1.Text = "顯示根目錄";
            label2.Text = "顯示資料夾名稱 (不含路徑)";
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                FileInfo f = new FileInfo(folderBrowserDialog1.SelectedPath);
                textBox2.Text = f.FullName;
                textBox3.Text = f.Name;

                DirectoryInfo dir = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                DirectoryInfo[] dirA = dir.GetDirectories();
                for (int i = 0; i < dirA.Length; i++)
                {
                    listBox1.Items.Add(dirA[i].FullName.ToString());
                }

                FileInfo[] dirB = dir.GetFiles();
                for (int i = 0; i < dirB.Length; i++)
                {
                    listBox1.Items.Add(dirB[i].FullName.ToString());
                }

                label3.Visible = true;
                label3.Text = "檔案數 : " + (dirA.Length + dirB.Length).ToString();
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
