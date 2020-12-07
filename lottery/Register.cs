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
using MySql.Data.MySqlClient;

namespace lottery
{

    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
            userrepository = new UserRepository();
        }
        private UserRepository userrepository;
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            List<string> errors = new List<string>();
            string name;
            string password;
            string email;

            name = nm.Text;
            password = pw.Text;
            email = em.Text;
            User user = new User {
            userName=name,usersPwd=password,userEmail=email};
            bool nameerror = false;
            foreach (var users in userrepository.getusers())
            {
                if(name==users.userName)
                {
                    nameerror = true;
                }
            }
            if (nameerror)
            {
                errors.Add("Ilyen felhasználó már létezik!");
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                errors.Add("Nincs ilyen email cím");
            }
            if(errors.Count!=0)
            {
                hiba.Text = (string.Join("\t", errors));
            }
            else
            {
            

                userrepository.Adduser(user);
                 this.Hide();
             Login f1 = new Login();
             f1.ShowDialog();
               
            }
       
        }
    }
}
