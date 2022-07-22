using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        bool _ekranTemizlenecekMi;
        int _ilkSayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_ekranTemizlenecekMi)
            {
                ekranlable.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if  (ekranlable.Text == "0")
            {
                ekranlable.Text = "";
            }
            ekranlable.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlable.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlable.Text == "0")
            {
                ekranlable.Text = "";
            }
            ekranlable.Text += "2";
        }
        

        private void button0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlable.Text = "";
                _ekranTemizlenecekMi = false;
            }


            if (ekranlable.Text == "0")
                {
                    ekranlable.Text = "";
                }
                ekranlable.Text += "0";
            
        }

        private void buttonartı_Click(object sender, EventArgs e)
        {
          
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranlable.Text);
        }

        private void buttonesitle_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ekranlable.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;

                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekranlable.Text = Convert.ToString(sonuc);
        }

        private void buttoneksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranlable.Text);
        }

        private void buttonçarp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranlable.Text);
        }

        private void buttonböl_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(ekranlable.Text);
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            ekranlable.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlable.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlable.Text == "0")
            {
                ekranlable.Text = "";
            }
            ekranlable.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlable.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlable.Text == "0")
            {
                ekranlable.Text = "";
            }
            ekranlable.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlable.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlable.Text == "0")
            {
                ekranlable.Text = "";
            }
            ekranlable.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlable.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlable.Text == "0")
            {
                ekranlable.Text = "";
            }
            ekranlable.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlable.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlable.Text == "0")
            {
                ekranlable.Text = "";
            }
            ekranlable.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlable.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlable.Text == "0")
            {
                ekranlable.Text = "";
            }
            ekranlable.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ekranlable.Text = "";
                _ekranTemizlenecekMi = false;
            }
            if (ekranlable.Text == "0")
            {
                ekranlable.Text = "";
            }
            ekranlable.Text += "9";
        }
    }  
}
