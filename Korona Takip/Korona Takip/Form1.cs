using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Korona_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] CoronaVerileri, CoronaGunlukVeriBilgisi;
            using (WebClient wc=new WebClient())
            {
                var url = wc.DownloadString("https://raw.githubusercontent.com/ozanerturk/covid19-turkey-api/master/dataset/timeline.json");
                CoronaVerileri = url.ToString().Split('{');
            }
            for (int i = 1; i <= 10; i++)
            {
                CoronaGunlukVeriBilgisi = CoronaVerileri[CoronaVerileri.Length - i].Split('"');
                if (i == 1)
                {
                    label1.Text = CoronaGunlukVeriBilgisi[3] + "Covid Hasta Tablosu";
                }
                tarih.ListView.Items.Add(CoronaGunlukVeriBilgisi[3]);
                testsayisi.ListView.Items.Add(CoronaGunlukVeriBilgisi[31]);
                vaka.ListView.Items.Add(CoronaGunlukVeriBilgisi[35]);
                iyilesen.ListView.Items.Add(CoronaGunlukVeriBilgisi[51]);
                vefat.ListView.Items.Add(CoronaGunlukVeriBilgisi[47]);
            }
        }
    }
}
