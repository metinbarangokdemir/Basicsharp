using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxOrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = groupBox1.Controls.Count;
            foreach (CheckBox item in groupBox1.Controls)
            {
                sayac--;
                item.Text = sayac.ToString();
            }
        }
    }
}
