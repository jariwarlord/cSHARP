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

    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM tblUser where TC=@TC AND şifre=@şifre";
            con = new SqlConnection("server=.; Initial Catalog=dbLogin;Integrated Security=SSPI");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@Tc", textBox1.Text);
            cmd.Parameters.AddWithValue("@Şifre", textBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");

                Form2 frm = new Form2();

                frm.Show();

                this.Hide();

            }
            else if (a == 3)
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz. 3 Kere yanlış girdiniz Programı Kapatıyorum");
                Application.Exit();
            }
            else if (a == 2)
            {
                MessageBox.Show("2.deneme başarısız");
            }
            else
            {
                a++;
                a++;
                MessageBox.Show("1.deneme başarısız");
                con.Close();


            }
        }
    }
}
