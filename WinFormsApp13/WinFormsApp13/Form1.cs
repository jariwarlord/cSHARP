namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int x = 99;
            while (x > 99 && x < 200)
            {
                if ((x % 7 == 0) && (x % 8 == 0)  && (x % 9 == 0)) 
                {
                    x++;
                }
                Console.WriteLine();  
            }
        }
    }
}