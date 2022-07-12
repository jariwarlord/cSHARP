using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapÖrnek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random r = new Random();
            int rastgeleTamSayi = r.Next(1, listBox1.Items.Count);
            string kisi = listBox1.Items[rastgeleTamSayi].ToString();
            MessageBox.Show(kisi);
        }
    }
}
