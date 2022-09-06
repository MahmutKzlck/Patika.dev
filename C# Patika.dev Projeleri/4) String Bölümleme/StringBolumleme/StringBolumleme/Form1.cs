using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringBolumleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            string v1, v2;
            int a1;
            string[] bolum = veri.Split(',');
            v1=bolum[0];
            v2=bolum[1];
            a1 = Convert.ToInt32(v2);
            for (int i = 1; i <= a1; i++)
            {
                listBox1.Items.Add(v1);
            }
        }
    }
}
