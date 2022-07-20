using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bankamatik
{
    public partial class Form2 : Form

    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select * From tablUSR Where Tc = '" + Tc + "'", con );
            SqlDataReader oku = cmd.ExecuteReader();
            oku.Read();
            cmd.ExecuteNonQuery();

            SqlCommand komut1 = new SqlCommand("Update [Musteriler] Set [Bakiye] = [Bakiye]-" + textBox1.Text + " Where [Tc] = '" + Tc , con);
            komut1.ExecuteNonQuery();

            MessageBox.Show("Hesaptan " + textBox1.Text.ToString() + " TL Çekildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select * From tablUSR Where Tc = '" + Tc + "'", con);
            SqlDataReader oku = cmd.ExecuteReader();
            oku.Read();
            cmd.ExecuteNonQuery();

            SqlCommand komut1 = new SqlCommand("Update [Musteriler] Set [Bakiye] = [Bakiye]+" + textBox2.Text + " Where [Tc] = '" + Tc, con);
            komut1.ExecuteNonQuery();

            MessageBox.Show("Hesaptan " + textBox2.Text.ToString() + " TL Yatırıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("server=.; Initial Catalog=dbLogin;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("select * from tblUser as k where k.TC = " , con); // Form1'den buraya gönderdiğimiz TC sine göre kullanıcının bilgilerini çekiyoruz
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
        }
    }
}
