namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     char tür= Convert.ToChar(textBox3.Text);
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double sonuc;
            switch (tür)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                textBox4.Text = sonuc.ToString("0.00");
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    textBox4.Text = sonuc.ToString("0.00");
                    break;
                case '/':
                sonuc
                       = sayi1 / sayi2;
                    textBox4.Text = sonuc.ToString("0.00");
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    textBox4.Text = sonuc.ToString("0.00");
                    break;
                case '%':
                    sonuc = sayi1 % sayi2;
                    textBox4.Text = sonuc.ToString("0.00");
                    break;

            }
        }
    }
}