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
        internal void AddUser(User user)
        {
            using (ToDoAppSystemEntities db = new ToDoAppSystemEntities())
            {
                var lastUser = db.Users.ToList().LastOrDefault();
                if (lastUser == null)
                {
                    user.Id = 1;
                }
                else
                {
                    user.Id = lastUser.Id + 1;
                }

                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        public List<User> GetAllUsers()
        {
            using (ToDoAppSystemEntities db = new ToDoAppSystemEntities())
            {
                return db.Users.ToList();
            }
        }
    }
}

