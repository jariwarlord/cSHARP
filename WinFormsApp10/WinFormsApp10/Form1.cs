namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            int toplam=0;
            int carpým = 1;
            for (int i=0; i < 20; i++)

            {
                if(i%2 == 0)

                {
                    toplam = i + toplam;
                }
                
                
                else
                {
                    if (i % 2 == 1) carpým *= i;


                }


            }
            listBox1.Items.Add(toplam.ToString());
            listBox1.Items.Add(carpým.ToString());
        }
            
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)*/
            
                for (int i = 1; i < 2; i++)
                {
                    for (int j = 0; j < 11; j++)
                    {
                        listBox3.Items.Add(i.ToString() + "*" + j.ToString() + "=" + i * j);
                    }
                }

            

        }
    }
}