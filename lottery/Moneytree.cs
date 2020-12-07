using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottery
{
    public partial class Moneytree : Form
    {
        public Moneytree()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] szamok = new int[9];
            Random rnd = new Random();

            for (int i = 0; i < 9; i++)
            {
                int number = rnd.Next(1,5);
                if (number==1)
                {
                    szamok[i] = 1000;
                }
                if (number == 2)
                {
                    szamok[i] = 10000;
                }
                if (number == 3)
                {
                    szamok[i] = 300;
                }
                if (number == 4)
                {
                    szamok[i] = 5000;
                }
                if (number == 5)
                {
                    szamok[i] = 1000000;
                }
            }
            money1.Text = szamok[0].ToString();
           money2.Text = szamok[1].ToString();
            money3.Text = szamok[2].ToString();
           money4.Text = szamok[3].ToString();
            money5.Text = szamok[4].ToString();
            money6.Text = szamok[5].ToString();
            money7.Text = szamok[6].ToString();
            money8.Text = szamok[7].ToString();
            money9.Text = szamok[8].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Games f3 = new Games();
            f3.ShowDialog();
        }

        private void Moneytree_Load(object sender, EventArgs e)
        {

        }

        private void money4_Click(object sender, EventArgs e)
        {

        }

        private void money9_Click(object sender, EventArgs e)
        {

        }

        private void money8_Click(object sender, EventArgs e)
        {

        }

        private void money7_Click(object sender, EventArgs e)
        {

        }

        private void money3_Click(object sender, EventArgs e)
        {

        }

        private void money2_Click(object sender, EventArgs e)
        {

        }

        private void money5_Click(object sender, EventArgs e)
        {

        }

        private void money6_Click(object sender, EventArgs e)
        {

        }
    }
}
