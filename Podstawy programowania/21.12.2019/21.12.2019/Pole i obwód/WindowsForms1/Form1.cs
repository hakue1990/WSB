using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Pole_i_obwód : Form
    {
        public Pole_i_obwód()
        {
            
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a;
            uint pole, obwod;
            uint dlugosc;
            try
            {
                a = Bok.Text;
                dlugosc = uint.Parse(a);
                lblKomunikat.Text = "";
                pole = dlugosc * dlugosc;
                obwod = dlugosc * 4;
                Pole.Text = pole.ToString();
                Obwod.Text = obwod.ToString();
            }
            catch (Exception)
            {
                lblKomunikat.Text= "Wprowadź poprawne dane!";
                Pole.Text = "";
                Obwod.Text = "";

            }
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmClear_Click(object sender, EventArgs e)
        {
            Bok.Text = string.Empty;
        }
    }
}
