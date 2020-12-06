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
    public partial class Lottery5 : Form
    {
        public Lottery5()
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

        private void button1_Click(object sender, EventArgs e)
        {

            hiba2.Items.Clear();
            List<string> errors = new List<string>();
            int i;
            int[] szamok = new int[5];
            Random rnd = new Random();
            int[] tomb = new int[5];
            for (i = 0; i < 5; i++)
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
            }
            catch
            {
                errors.Add("Az össze mezőbe írj egy számot!");
            }
        
            bool mehet = false;
            bool nagyobb = false;
            for (i = 0; i < 5; i++)
            {
                if (tomb[i] > 90 || tomb[i] < 1)
                {
                    nagyobb = true;
                    mehet = true;
                }
               
  
            }
            if (nagyobb)
            {
                errors.Add("Számoknak 1 és 90 köztieknek kell leniük!");
            }
            bool egyforma = false;
            for (int x = 0; x < 4; x++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (tomb[x] == tomb[j] && x != j)
                    {
                        egyforma = true;
                        mehet = true;
                    }
                }
            }
            if(egyforma){
                errors.Add("Számoknak nem lehetnek egyformák!");
            }
            tomb = sorbarendez(tomb);
            int[] ottoslotto = tomb;
            int talalt = 0;
            for (i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (tomb[i] == szamok[j])
                    {
                        talalt++;
                    }
                }
            }
            if (!mehet)
            {
                kisorssz1.Text = szamok[0].ToString();
                kisorssz2.Text = szamok[1].ToString();
                kisorssz3.Text = szamok[2].ToString();
                kisorssz4.Text = szamok[3].ToString();
                kisorssz5.Text = szamok[4].ToString();
            }
           foreach(var error in errors)
            {
                hiba2.Items.Add(error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Games f3 = new Games();
            f3.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void kisorssz3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
