using LoginForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.Controller
{
    internal class LoginController
    {
        static List<User> users = new List<User>()
       {
           new User("admin","adminpass"),
       };
        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}
