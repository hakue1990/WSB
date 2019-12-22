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
    public partial class kolor : Form
    {
        public kolor()
        {
            InitializeComponent();
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kolor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();       zamyka aplikacje przy zamknięciu okna "kolor"
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            byte bok;
            if (byte.TryParse(textBox1.Text, out bok) && bok >= 0 && bok <= 200)
            {
                if (!panel1.Visible)
                {
                    panel1.Visible = true;
                }
                panel1.Height = bok;
                panel1.Width = bok;
                lblKomunikat.Text = "";

            }
            else
            {
                lblKomunikat.Text = "Podaj prawidłowa długość boku!";
                panel1.Visible = false;
            }
            
        }

        private void btmUkryj_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;

            }
        }

        private void btmZmienKolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Draw draw = new Draw();
            draw.ShowDialog();
        }
    }
}
