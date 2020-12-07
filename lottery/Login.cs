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

namespace lottery
{
    public struct felhasznalo
    {
        public string nev;
        public string jelszo;
        public string email;
        public byte pontok;
    }

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            userrepository = new UserRepository();
        }
        private UserRepository userrepository;

        private void button1_Click(object sender, EventArgs e)
        {
            String name = nm.Text;
            String password = pw.Text;
            bool canlog = userrepository.Can_Login(name, password);
           if(canlog)
            {
                this.Hide();
                Games f3 = new Games();
                f3.ShowDialog();
            }
            else
            {
                errors.Items.Add("Hibás felhasználónév / jelszó!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register f2 = new Register();
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
