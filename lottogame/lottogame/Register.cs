using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lottogame
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            List<string> errors = new List<string>();
            string nev;
            string jelszo;
            string email;
            byte pontok = 0;
          
                String[] t = new String[4];
            nev = nm.Text;
            jelszo = pw.Text;
            email = em.Text;
            if (string.IsNullOrEmpty(nev) || string.IsNullOrEmpty(jelszo) || string.IsNullOrEmpty(email))
            {
                errors.Add("Nem lehet üres mező!");
            }

            t[0] = nev + ";";
            t[1] = jelszo + ";";
            t[3] = email + '\n';
            t[2] = Convert.ToString(pontok) + ";";
            string path = @"Accaunt.txt";
            if (File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        tw.Write(t[i]);
                    }

                    tw.Close();
                }
            }
            MessageBox.Show("Sikeres Regisztráció");
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();
            string nev;
            string jelszo;
            string email;
            byte pontok = 0;

            String[] t = new String[4];
            nev = nm.Text;
            jelszo = pw.Text;
            email = em.Text;
         
            t[0] = nev + ";";
            t[1] = jelszo + ";";
            t[3] = email + '\n';
            t[2] = Convert.ToString(pontok) + ";";
            string path = @"C:\Users\Zoli\Downloads\lottogame\Accaunt.txt";
            if (string.IsNullOrEmpty(nev) || string.IsNullOrEmpty(jelszo) || string.IsNullOrEmpty(email))
            {
                errors.Add("Nem lehet üres mező!");
            }
            if (File.Exists(path)||errors.Count==0)
            {
                using (var tw = new StreamWriter(path, true))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        tw.Write(t[i]);
                    }

                    tw.Close();
                }
            }
            if(errors.Count!=0)
            {
                hiba.Text = (string.Join("\t", errors));
            }
            else
            {
             this.Hide();
             Login f1 = new Login();
             f1.ShowDialog();
            }
       
        }
    }
}
