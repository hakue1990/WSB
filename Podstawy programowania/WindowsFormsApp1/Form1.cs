﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {
            double a, b, sum;
            try
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                sum = a + b;

                
            }
            catch (Exception e)
            {
                
                throw;
            }
        }
    }
}
