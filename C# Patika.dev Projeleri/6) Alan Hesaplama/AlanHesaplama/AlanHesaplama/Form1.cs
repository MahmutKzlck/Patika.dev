using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlanHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            if (comboBox1.Text == "Daire")
            {
                label3.Text = "Yarıçap uzunluğunu giriniz.";
            }
            else if (comboBox1.Text == "Kare")
            {
                label3.Text = "Kenar uzunluğunu giriniz.";
            }
            else if (comboBox1.Text == "Üçgen")
            {
                label3.Text = "Kenar uzunluğunu giriniz.";
            }
            else if (comboBox1.Text == "Altıgen")
            {
                label3.Text = "Kenar uzunluğunu giriniz.";
            }
            else if (comboBox1.Text == "Beşgen")
            {
                label3.Text = "Kenar uzunluğunu giriniz.";
            }
            else if (comboBox1.Text == "Dikdörtgen")
            {
                label3.Text = "Uzun Kenarı giriniz.";

                button1.Location = new Point(148, 241);
                label4.Location = new Point(198, 273);

                label5.Visible = true;
                textBox2.Visible = true;
                label5.Text = "Kısa Kenarı Giriniz.";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double alan, cevre, hacim;            
            string DaireAlan, DaireCevre, DaireHacim;

            if (comboBox1.Text == "Daire")
            {
                if (comboBox2.Text == "Alan")
                {
                    alan = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);
                    DaireAlan = alan + " Pi";
                    label4.Text = DaireAlan;
                }
                else if (comboBox2.Text == "Çevre")
                {
                    cevre = Convert.ToInt32(textBox1.Text) * 2;
                    DaireCevre = cevre + " Pi";
                    label4.Text = DaireCevre;
                }
                else if (comboBox2.Text == "Hacim")
                {
                    hacim = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox3.Text);
                    DaireHacim = hacim + " Pi";
                    label4.Text = DaireHacim;
                }
            }
            else if (comboBox1.Text == "Kare")
            {
                if (comboBox2.Text == "Alan")
                {
                    alan = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);
                    label4.Text = alan.ToString();
                }
                else if (comboBox2.Text == "Çevre")
                {
                    cevre = Convert.ToInt32(textBox1.Text) * 4;
                    label4.Text = cevre.ToString();
                }
                else if (comboBox2.Text == "Hacim")
                {
                    hacim = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text);
                    label4.Text = hacim.ToString();
                }
            }
            else if (comboBox1.Text == "Üçgen")
            {
                if (comboBox2.Text == "Alan")
                {
                    alan = Math.Sqrt(((Convert.ToInt32(textBox1.Text) * 3) / 2) * (((Convert.ToInt32(textBox1.Text) * 3) / 2) - Convert.ToInt32(textBox1.Text)) * 3);
                    label4.Text = alan.ToString();
                }
                else if (comboBox2.Text == "Çevre")
                {
                    cevre = Convert.ToInt32(textBox1.Text) * 3;
                    label4.Text = cevre.ToString();
                }
                else if (comboBox2.Text == "Hacim")
                {
                    hacim = (Math.Sqrt(((Convert.ToInt32(textBox1.Text) * 3) / 2) * (((Convert.ToInt32(textBox1.Text) * 3) / 2) - Convert.ToInt32(textBox1.Text)) * 3) * Convert.ToInt32(textBox1.Text)) / 3;
                    label4.Text = hacim.ToString();
                }
            }
            else if (comboBox1.Text == "Altıgen")
            {
                if (comboBox2.Text == "Alan")
                {
                    alan = ((Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text)) * (1.4422 / 2));
                    label4.Text = alan.ToString();
                }
                else if (comboBox2.Text == "Çevre")
                {
                    cevre = Convert.ToInt32(textBox1.Text) * 6;
                    label4.Text = cevre.ToString();
                }
                else if (comboBox2.Text == "Hacim")
                {
                    hacim = ((Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text)) * (1.4422 / 2)) * Convert.ToInt32(textBox2.Text);
                    label4.Text = hacim.ToString();
                }
            }
            else if (comboBox1.Text == "Beşgen")
            {
                if (comboBox2.Text == "Alan")
                {
                    alan = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text) * 5) / (4 * Math.Sqrt(5 - (2 * Math.Sqrt(5))));
                    label4.Text = alan.ToString();
                }
                else if (comboBox2.Text == "Çevre")
                {
                    cevre = Convert.ToInt32(textBox1.Text) * 5;
                    label4.Text = cevre.ToString();
                }
                else if (comboBox2.Text == "Hacim")
                {
                    hacim = ((Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text) * 5) / (4 * Math.Sqrt(5 - (2 * Math.Sqrt(5))))) * Convert.ToInt32(textBox2.Text);
                    label4.Text = hacim.ToString();
                }
            }
            else if (comboBox1.Text == "Dikdörtgen")
            {
                if (comboBox2.Text == "Alan")
                {
                    alan = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
                    label4.Text = alan.ToString();
                }
                else if (comboBox2.Text == "Çevre")
                {
                    cevre = (Convert.ToInt32(textBox1.Text) * 2) + (Convert.ToInt32(textBox2.Text) * 2);
                    label4.Text = cevre.ToString();
                }
                else if (comboBox2.Text == "Hacim")
                {
                    hacim = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);
                    label4.Text = hacim.ToString();
                }
            }
        }        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;

            if (comboBox1.Text == "Dikdörtgen")
            {
                if (comboBox2.Text == "Hacim")
                {
                    label6.Visible = true;
                    textBox3.Visible = true;
                    label6.Text = "Yükseklik Giriniz.";

                    button1.Location = new Point(145, 294);
                    label4.Location = new Point(198, 326);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

            label5.Visible = false;
            label6.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;

            label4.Location = new System.Drawing.Point(198, 233);
            button1.Location = new System.Drawing.Point(154, 188);
        }
    }
}