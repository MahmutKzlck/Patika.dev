using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaireCizdirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cap;
            cap = Convert.ToInt32(textBox1.Text);

            System.Drawing.Graphics grafikNesne;
            grafikNesne = this.CreateGraphics();

            Brush fırca = new SolidBrush(System.Drawing.Color.PapayaWhip);
            grafikNesne.FillEllipse(fırca, 150, 100, cap, cap);
        }
    }
}
