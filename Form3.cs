﻿using System;
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
            for (int i = -8; i <= 15; i = i+1)
            {
                if (i == 15)
                    textBox1.Text += i.ToString();
                else
                    textBox1.Text += i.ToString() + ",";
            }
            
        }

      
    }
}
