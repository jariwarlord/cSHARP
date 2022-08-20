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
namespace LoginOrnek
    
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 14;
               

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text;
            string password = textBox2.Text;

            baglanti = new SqlConnection("Server=Berke; Database=grs; Initial Catalog=ULogin; Trusted_Connection =True;Persist Security Info=True");
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM ULogin where UsId='" + textBox1.Text + "' AND Password '" + textBox2.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }

        }
    }
}
