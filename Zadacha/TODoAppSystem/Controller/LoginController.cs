using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODoAppSystem.Model;


namespace TODoAppSystem.Controller
{
    internal class LoginController
    {
        //Read
        public List<Users> GetAllUsers()
        {
            using (ToDoAppSystemEntities db = new ToDoAppSystemEntities())
            {
                return db.Users.ToList();
            }
        }

        //Create
        internal void AddUser(Users user)
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

        //Update
        public void UpdateUser(int id, User user)
        {
            using (ToDoAppSystemEntities db = new ToDoAppSystemEntities())
            {
                var userToUpdate = db.Users.Where(u => u.Id == id).FirstOrDefault();
                if (userToUpdate != null)
                {
                    userToUpdate.Id = id;
                    userToUpdate.Username = user.Username;
                    userToUpdate.Password = user.Password;
                    db.SaveChanges();
                }
            }
        }

        //Delete
        public void DeleteUser(int id)
        {
            using (ToDoAppSystemEntities db = new ToDoAppSystemEntities())
            {
                var userToDelete = db.Users.Where(u => u.Id == id).FirstOrDefault();
                if (userToDelete != null)
                {
                    object value = db.Users.Remove(userToDelete);
                    db.SaveChanges();
                }
            }
        }
        
        /*internal void AddUser(User user)
        {
            throw new NotImplementedException();
        } */


    }
}
