using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciOrtalamaHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int toplam = 0, s, s1 = 1, s2 = 1, s3 = s1 + s2;
            double ortalama;
            s = Convert.ToInt32(textBox1.Text) - 2;
            
            listBox1.Items.Add(s1);
            listBox1.Items.Add(s2);

            for (int i = 1; i <= s; i++)
            {
                s3 = s1 + s2;
                s1 = s2;
                s2 = s3;                
                listBox1.Items.Add(s3);
                toplam = (s1 + s2 + s3) - 1;
            }            
            ortalama = toplam / (s + 2);
            label3.Text = ortalama.ToString();
            label4.Text = toplam.ToString();
            label6.Text = (s + 2).ToString();
        }
    }
}
