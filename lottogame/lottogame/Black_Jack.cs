using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottogame
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] szamok = new int[4];
            Random rnd = new Random();
            int a = rnd.Next(1, 21);
            blsztop.Text = a.ToString();

            for (int i = 0; i < 4; i++)
            {
                int number = rnd.Next(1, 21);
                if (number.Equals(szamok) == false)
                {
                    szamok[i] = number;
                }
                else i--;
            }
            blsz1.Text = szamok[0].ToString();
            blsz2.Text = szamok[1].ToString();
            blsz3.Text = szamok[2].ToString();
            blsz4.Text = szamok[3].ToString();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0 } ", szamok[i]);
            }
            bool x = false;
            for (int i = 0; i < 4; i++)
            {
                if (szamok[i] > a)
                {
                    x = true;
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Games f3 = new Games();
            f3.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
