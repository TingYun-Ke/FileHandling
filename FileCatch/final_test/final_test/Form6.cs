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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            groupBox1.Text = "飲料";
            radioButton1.Text = "冷飲";
            radioButton2.Text = "熱飲";
            button1.Text = "加入";
            button2.Text = "送出";

        }

        private void group1(object sender, EventArgs e)
        {
            String rdn = ((RadioButton)sender).Name.ToString();
            switch (rdn)
            {
                case "radioButton1":
                    if (listBox1.Items.Count != 0)
                    {
                        listBox1.Items.Clear();
                    }
                    listBox1.Items.Add("冷咖啡");
                    listBox1.Items.Add("冷奶茶");
                    listBox1.Items.Add("冷紅茶");
                    break;
                case "radioButton2":
                    if (listBox1.Items.Count != 0)
                    {
                        listBox1.Items.Clear();
                    }
                    listBox1.Items.Add("熱咖啡");
                    listBox1.Items.Add("熱奶茶");
                    listBox1.Items.Add("熱紅茶");
                    break;
            }
        }

        static private String[] name = { "冷咖啡", "冷奶茶", "冷紅茶" , "熱咖啡","熱奶茶", "熱紅茶" };
        static private int[] num = { 0, 0, 0, 0, 0, 0 };
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(object o in listBox1.SelectedItems)
            {
                listBox2.Items.Add(o.ToString());
                switch (o.ToString())
                {
                    case "冷咖啡":
                        num[0]++;
                        break;
                    case "冷奶茶":
                        num[1]++;
                        break;
                    case "冷紅茶":
                        num[2]++;
                        break;
                    case "熱咖啡":
                        num[3]++;
                        break;
                    case "熱奶茶":
                        num[4]++;
                        break;
                    case "熱紅茶":
                        num[5]++;
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string st = "";
            for (int i=0; i<num.Length; i++)
            {
                if (num[i] != 0)
                {
                    st += name[i] + " : " + num[i].ToString() + "杯\n";
                }
            }
            MessageBox.Show(st);
        }
    }
}
