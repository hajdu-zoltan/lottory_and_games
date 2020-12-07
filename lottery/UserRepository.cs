using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace lottery
{
    class UserRepository
    {
        private Applicationsdbcontext contex;
        public UserRepository()
        {
            contex = new Applicationsdbcontext();
        }
        public void Adduser(User user)
        {

            contex.users.Add(user);
            contex.SaveChanges();
        }
        public List<User> getusers()
        {
            return contex.users.ToList();
        }
        public bool Can_Login(string name, string password )
        {
            foreach (var user in getusers())
            {
             
                if (name==user.userName && password==user.usersPwd)
                {
                   return true;
                }
            }
            return false;

        }
    }
}
