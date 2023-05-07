using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.Model
{
    internal class User
    {
        public string Username;
        public string Password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}

{ 
    public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    // ..
}

// In your administrative code, you could have a method like this:
public void DeleteUserById(int userId)
{
        // Retrieve the user from your database or wherever it's stored
       User userToDelete = GetUserById(userId);

        if (userToDelete == null)
       {
        // User with specified ID doesn't exist
        // Handle this however you want (e.g. throw an exception, return a message)
    }
    else
    {
        // Delete the user from your database or wherever it's stored
        DeleteUser(userToDelete);
    }
}

// Example method to retrieve user from database
private User GetUserById(int userId)
{
    // TODO: Implement this method to retrieve the user from your data source
    // For example, if using Entity Framework, you could do something like:
    using (var context = new MyDbContext())
    {
         return context.Users.FirstOrDefault(u => u.Id == userId);
    }
}

// Example method to delete user from database
private void DeleteUser(User user)
{
    // TODO: Implement this method to delete the user from your data source
    // For example, if using Entity Framework, you could do something like:
    using (var context = new MyDbContext())
    {
        context.Users.Remove(user);
        context.SaveChanges();
    }
}

