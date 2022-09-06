using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerstenYazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            for (int i = metin.Length - 1; i > 0; i--)
            {
                listBox1.Items.Add(metin[i]);
            }
        }
    }
}
