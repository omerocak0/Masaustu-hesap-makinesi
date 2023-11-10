using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sayi1, sayi2, sonuc;
        string islem;

        void sonucyaz()
        {
            lblislem.Text = sayi1 + islem + sayi2 + "=" + sonuc;
            txtEkran.Text = sonuc.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //1
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "1";
            }
            else
            {
                txtEkran.Text += "1";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //2
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "2";
            }
            else
            {
                txtEkran.Text += "2";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //3
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "3";
            }
            else
            {
                txtEkran.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //4
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "4";
            }
            else
            {
                txtEkran.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //5
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "5";
            }
            else
            {
                txtEkran.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //6
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "6";
            }
            else
            {
                txtEkran.Text += "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //7
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "7";
            }
            else
            {
                txtEkran.Text += "7";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //8
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "8";
            }
            else
            {
                txtEkran.Text += "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //9
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "9";
            }
            else
            {
                txtEkran.Text += "9";
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            //0
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "0";
            }
            else
            {
                txtEkran.Text += "0";
            }
        }

        private void btnNokta_Click(object sender, EventArgs e)
        {
            // .
            if (txtEkran.Text != "")
            {
                txtEkran.Text += ",";
                btnNokta.Enabled = false;
            }
            else
            {
                MessageBox.Show("Sayı Giriniz!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // +
            btnNokta.Enabled = true;

            sayi1 = Convert.ToDouble(txtEkran.Text);
            islem = "+";
            txtEkran.Text = "";
            lblislem.Text = sayi1 + islem;
            btnArti.Enabled = false;
            btnEksi.Enabled = false;
            btnCarpma.Enabled = false;
            btnBolme.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // *
            btnNokta.Enabled = true;

            sayi1 = Convert.ToDouble(txtEkran.Text);
            islem = "x";
            txtEkran.Text = "";
            lblislem.Text = sayi1 + islem;
            btnArti.Enabled = false;
            btnEksi.Enabled = false;
            btnCarpma.Enabled = false;
            btnBolme.Enabled = false;
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            // -
            btnNokta.Enabled = true;

            sayi1 = Convert.ToDouble(txtEkran.Text);
            islem = "-";
            txtEkran.Text = "";
            lblislem.Text = sayi1 + islem;
            btnArti.Enabled = false;
            btnEksi.Enabled = false;
            btnCarpma.Enabled = false;
            btnBolme.Enabled = false;
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            // /
            btnNokta.Enabled = true;

            sayi1 = Convert.ToDouble(txtEkran.Text);
            islem = "/";
            txtEkran.Text = "";
            lblislem.Text = sayi1 + islem;
            btnArti.Enabled = false;
            btnEksi.Enabled = false;
            btnCarpma.Enabled = false;
            btnBolme.Enabled = false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            // CE
            if (txtEkran.Text == sonuc.ToString())
            {
                lblislem.Text = " ";
                txtEkran.Text = "0";
            } else
            {
                lblislem.Text = sayi1 + islem;
                txtEkran.Text = "0";
            }
                
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            // C
            txtEkran.Text = "0";
            lblislem.Text = "";
            sonuc = 0;
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            // =
            if (txtEkran.Text != "")
            {
                sayi2 = Convert.ToDouble(txtEkran.Text);

                switch(islem)
                {
                    case "+": sonuc = sayi1 + sayi2; sonucyaz(); break;
                    case "-": sonuc = sayi1 - sayi2; sonucyaz(); break;
                    case "x": sonuc = sayi1 * sayi2; sonucyaz(); break;
                    case "/": sonuc = sayi1 / sayi2; sonucyaz(); break;
                }

                btnArti.Enabled = true;
                btnEksi.Enabled = true;
                btnCarpma.Enabled = true;
                btnBolme.Enabled = true;


            } else
            {
                MessageBox.Show("Sayı Giriniz!");
            }
        }

        private void txtEkran_TextChanged(object sender, EventArgs e)
        {
            // Ekran
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // İşlem
        }
    }
}
