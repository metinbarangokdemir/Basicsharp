using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChechBoxOrnegi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = label1.Text+" ";

            if (checkBox1.Checked)
            {
                cumle += checkBox1.Text+" , ";
            }
            if (checkBox2.Checked)
            {
                cumle += checkBox2.Text + " , ";
            }
            if (checkBox3.Checked)
            {
                cumle += checkBox3.Text + " , ";
            }
            if (checkBox4.Checked)
            {
                cumle += checkBox4.Text + " , ";
            }
            if (checkBox5.Checked)
            {
                cumle += checkBox5.Text + " , ";
            }
            if (checkBox6.Checked)
            {
                cumle += checkBox6.Text + " , ";
            }
            cumle = cumle.Substring(0, cumle.Length - 2);
            cumle += " ekleyeceğiz.";

            MessageBox.Show(cumle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cumle = label1.Text + " ";

            foreach (CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    cumle += item.Text + " , ";
                }
            }

            cumle = cumle.Substring(0, cumle.Length - 2);
            cumle += " ekleyeceğiz.";

            MessageBox.Show(cumle);
        }
    }
}
