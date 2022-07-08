namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Random rastgele = new Random();
            int sayi, toplam = 0;
            for(int i=0; i<3; i++)
            {
                sayi = rastgele.Next(0, 100);
                toplam = sayi + toplam;
            }
            if(toplam>200)
            {
                MessageBox.Show(toplam.ToString()+ " " + "Tebrikler Kazandýnýz.");
            }
            else
            {
                MessageBox.Show(toplam.ToString() + " " + "Maalesef, Tekrar Deneyiniz.");
            }*/
            /*
            int i = 0;
            while (i < 10) ;
            {
                listBox1.Items.Add(i.ToString());
                i++;

            }*/
            /*
            int i = 0;
            while(i < Convert.ToInt32(textBox1.Text))
            {
                listBox1.Items.Add(i.ToString());
                i++;
            }+
            */
            /*
            int i = Convert.ToInt32(textBox1.Text);
            int j = Convert.ToInt32(textBox2.Text);
            int top = 0;
            while (i < j)
            {
                if(i%2==0)
                {
                    top = i + top;
                }
                i++;
            }
            listBox1.Items.Add(top.ToString());
         *//*
            Double sayi = double.Parse(textBox1.Text);
            double sonuc;
            // sonuc = Math.Abs(sayi);
            //sonuc = Math.Sqrt(sayi);
            sonuc = Math.Pow(sayi,3);
            listBox1.Items.Add(sonuc.ToString());*/

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}