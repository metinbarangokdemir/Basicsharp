using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesneler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToShortDateString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.AddYears(-9).ToLongDateString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime dogumgunu;
            dogumgunu = Convert.ToDateTime("0001-10-17").Date;

            //MessageBox.Show(dogumgunu.AddYears(0).ToLongDateString());

            MessageBox.Show(dogumgunu.AddYears(1500).ToLongDateString());
            MessageBox.Show(dogumgunu.AddYears(-1000).ToLongDateString());
        }
    }
}
