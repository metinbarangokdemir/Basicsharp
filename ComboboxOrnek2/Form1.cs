using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboboxOrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ComboBox item in groupBox1.Controls)
            {
                item.Items.Add("İstanbul");
                item.Items.Add("Ankara");
                item.Items.Add("İzmir");
                item.Items.Add("Balıkesir");
                item.Items.Add("Düzce");
            }
        }
    }
}
