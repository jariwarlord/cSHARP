namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    listBox1.Items.Add(i.ToString() + "*" + j.ToString() + "=" + i * j);
                }
            }
                for (int k = 2; k < 4; k++)
                {
                    for (int t = 0; t < 11; t++) ;
                    {
                        listBox1.Items.Add(k.ToString() + "*" + t.ToString() + "=" + k * t);
                    }
                    break;
                    
                }
            
        }
    }
}