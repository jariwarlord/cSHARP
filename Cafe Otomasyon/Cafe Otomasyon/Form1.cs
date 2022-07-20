namespace Cafe_Otomasyon
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Americano + labeli
        {
            int AmericanoSay = Convert.ToInt32(label9.Text);
            int AmericanoFiy = Convert.ToInt32(label5.Text);
            AmericanoSay++;
            label9.Text = Convert.ToString(AmericanoSay);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int AmericanoSay = Convert.ToInt32(label9.Text);
            AmericanoSay--;
            label9.Text = Convert.ToString(AmericanoSay);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int LatteSay = Convert.ToInt32(label10.Text);
            int AmericanoFiy = Convert.ToInt32(label5.Text);
            LatteSay++;
            label10.Text = Convert.ToString(LatteSay);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int LatteSay = Convert.ToInt32(label10.Text);          
            LatteSay--;
            label10.Text = Convert.ToString(LatteSay);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int EspressoSay = Convert.ToInt32(label11.Text);
            EspressoSay++;
            label11.Text = Convert.ToString(EspressoSay);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int EspressoSay = Convert.ToInt32(label11.Text);
            EspressoSay--;
            label11.Text = Convert.ToString(EspressoSay);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int MochaSay = Convert.ToInt32(label12.Text);
            MochaSay++;
            label12.Text = Convert.ToString(MochaSay);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int MochaSay = Convert.ToInt32(label12.Text);
            MochaSay--;
            label12.Text = Convert.ToString(MochaSay);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int AmericanoSay = Convert.ToInt32(label9.Text);
            int AmericanoFiy = Convert.ToInt32(label5.Text);
            int AmericanoTut = Convert.ToInt32(AmericanoSay * AmericanoFiy);

            int LatteSay = Convert.ToInt32(label10.Text);
            int LatteFiy = Convert.ToInt32(label6.Text);
            int LatteTut = Convert.ToInt32(LatteSay * LatteFiy);

            int EspressoSay = Convert.ToInt32(label11.Text);
            int EspressoFiy = Convert.ToInt32(label7.Text);
            int EspressoTut = Convert.ToInt32(EspressoSay * EspressoFiy);

            int MochaSay = Convert.ToInt32(label12.Text);
            int MochaFiy = Convert.ToInt32(label8.Text);
            int MochaTut = Convert.ToInt32(MochaSay * MochaFiy);



            MessageBox.Show("Verilen Sipariþler Americano : " + label9.Text + " Latte: " + label10.Text + " Espresso : " + label11.Text + " Mocha " + label12.Text + " Toplam Tutar : " + (MochaTut + AmericanoTut + LatteTut + EspressoTut) + "TL" );
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
        }
    }
}