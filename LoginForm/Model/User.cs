using LoginForm.Model.LoginForm.Data;
using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginForm.Model
{
    internal class LoginUser
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginUser(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

    public interface IUserRepository
    {
        User GetUserById(int userId);
        void DeleteUser(User user);
        void DeleteUser1(User User);
        void DeleteUserById(int userId);
    }

    public class User
    {
        private int id;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; internal set; }
    }

    public class UserRepository : IUserRepository
    {
        public User GetUserById(int userId)
        {
            using (var dbContext = new MyDbContext())
            
        {
            return dbContext.Users.FirstOrDefault(u => u.Id == userId);
        }
    }

        public void DeleteUser1(User User)
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                object value = dbContext.Users.Remove(User);
                dbContext.SaveChanges();
            }




            using (DbContext dbContext = new MyDbContext())
            {
                object value = DbContext(User);
                dbContext.SaveChanges();
            }
        }

        private static object DbContext(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserById(int userId)
        {
            var userRepository = new UserRepository();
            var userToDelete = userRepository.GetUserById(userId);

            if (userToDelete == null)
            {
                // User with specified ID doesn't exist
                // Handle this however you want (e.g. throw an exception, return a message)
            }
            else
            {
                userRepository.DeleteUser(userToDelete);
            }
        }

        private void DeleteUser(User userToDelete)
        {
            throw new NotImplementedException();
        }

        User IUserRepository.GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.DeleteUser(User user)
        {
            throw new NotImplementedException();
        }
    }

    namespace LoginForm.Data
    {
        public class MyDbContext : DbContext
        {
            public DbSet<User> Users { get; set; }
            public MyDbContext() : base("name=MyConnectionString")
            {
            }
        }
    }
}