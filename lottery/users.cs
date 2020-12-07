using System;
using System.Collections.Generic;
using System.Text;

namespace lottery
{
    class User
    {
        public User()
        {

        }
        public User(string userEmail, string usersPwd, string userName)
        {

            this.userName = userName;
            this.usersPwd = usersPwd;
            this.userEmail = userEmail;
        }
        public int Id { get; set; }
        public String userEmail { get; set; }
        public String usersPwd { get; set; }
        public String userName { get; set; }
    }
}
