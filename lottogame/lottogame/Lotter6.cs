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
    public partial class Lotter6 : Form
    {
        public Lotter6()
        {
            InitializeComponent();
        }
        public int[] sorbarendez(int[] tomb)
        {
            int[] szamok = tomb;
            int i;
            int j;
            int tmp;
            for (i = 1; 0 < i; --i)
            {
                for (j = 0; j < i; ++j)
                {
                    if (szamok[j] > szamok[j + 1])
                    {
                        // csere
                        tmp = szamok[j];
                        szamok[j] = szamok[j + 1];
                        szamok[j + 1] = tmp;
                    }
                }
            }
            return szamok;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Games f3 = new Games();
            f3.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Text = "Print Form";
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
                hiba2.Items.Clear();
                List<string> errors = new List<string>();
                int[] tomb = new int[6];
                int i;
                int[] szamok = new int[6];
                Random rnd = new Random();
                for (i = 0; i < 6; i++)
                {
                    int number = rnd.Next(1, 90);
                    if (number.Equals(szamok) == false)
                    {
                        szamok[i] = number;
                    }
                }
                try
                {

                    tomb[0] = Convert.ToInt32(Lsz1.Text);
                    tomb[1] = Convert.ToInt32(lsz2.Text);
                    tomb[2] = Convert.ToInt32(lsz3.Text);
                    tomb[3] = Convert.ToInt32(lsz4.Text);
                    tomb[4] = Convert.ToInt32(lsz5.Text);
                    tomb[5] = Convert.ToInt32(lsz6.Text);
                }
                catch
                {
                    errors.Add("Az össze mezőbe írj egy számot!");
                }

            bool nagyobb = false;
            bool mehet = false;
                for (i = 0; i < 6; i++)
                {
                    if (tomb[i] > 45 || tomb[i] < 1)
                    {
                    nagyobb = true;
                        mehet = true;
                    }
                }
            if (nagyobb)
            {
                errors.Add("Számoknak 1 és 90 köztieknek kell leniük!");
            }
            tomb = sorbarendez(tomb);
                int[] ottoslotto = tomb;
                int talalt = 0;
                for (i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (tomb[i] == szamok[j])
                        {
                            talalt++;
                        }
                    }
                }
            bool egyforma = false;
                for (int x = 0; x < 5; x++)
                {
                    for (int j = 1; j < 6; j++)
                    {
                        if (tomb[x] == tomb[j] && x != j)
                        {
                        egyforma = true;
                        mehet = true;
                        }
                    }
                }
            if (egyforma)
            {
                errors.Add("Számoknak nem lehetnek egyformák!");
            }
            foreach (var error in errors)
            {
                hiba2.Items.Add(error);
            }
            if (mehet == false)
                {
                    kisorssz1.Text = szamok[0].ToString();
                    kisorssz2.Text = szamok[1].ToString();
                    kisorssz3.Text = szamok[2].ToString();
                    kisorssz4.Text = szamok[3].ToString();
                    kisorssz5.Text = szamok[4].ToString();
                    kisorssz6.Text = szamok[5].ToString();
                }
            
        }
    }
    
}
