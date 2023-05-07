using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoeachButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button129_Click(object sender, EventArgs e)
        {            
            int sayac = 0;
            foreach (Button item in groupBox1.Controls)
            {                
                if (sayac % 2==0)
                {
                    item.BackColor = Color.Red; 

                }
                else
                {
                    item.BackColor = Color.White;
                }
                sayac++;
            }
        }
    }
}
