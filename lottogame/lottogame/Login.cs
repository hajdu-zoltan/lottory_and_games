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
    public struct felhasznalo
    {
        public string nev;
        public string jelszo;
        public string email;
        public byte pontok;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "../SamuderaJayaMotor.png";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> errors = new List<string>();
            String name = nm.Text;
            String pasword = pw.Text; 
            bool log = false;
            List<felhasznalo> v = new List<felhasznalo>();
            string path = @"Accaunt.txt";
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            String sor = "";
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                String[] darabok = sor.Split(';');
                felhasznalo k = new felhasznalo();
                k.nev = darabok[0];
                k.jelszo = darabok[1];
                k.pontok = Convert.ToByte(darabok[2]);
                k.email = darabok[3];
                v.Add(k);
            }
            sr.Close();
            fs.Close();
            foreach (felhasznalo elem in v)
            {
                if (elem.nev == name && elem.jelszo == pasword)
                {
                    log = true;

                }

            }
            if (log == false)
            {
               errors.Add("hibás felhasználónév/jelszó");
            }
            else
            {
     
                
                this.Hide();
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            hiba.Text = (string.Join("\t", errors));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pw_TextChanged(object sender, EventArgs e)
        {

        }

        private void nm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
