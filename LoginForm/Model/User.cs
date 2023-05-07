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
            // Return null if no user is found with the specified ID
            // Example implementation using Entity Framework:
            using (var DbContext = new MyDbContext())
            {
                return dbContext.Users.FirstOrDefault(u => u.Id == userId);
            }
        }

        public void DeleteUser(User User)
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
    }

    namespace LoginForm.Data
    {
        public class MyDbContext : DbContext
        {
            public DbSet<User> Users { get; set; }
            public MyDbContext() : base("name=MyConnectionString");

      
        }
    }
}