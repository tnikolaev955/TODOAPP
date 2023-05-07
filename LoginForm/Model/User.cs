using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    
}


public class UserRepository
{

    public interface IUserRepository
    {
        User GetUserById(int userId);
        void DeleteUser(User user);
    }

    public User GetUserById(int userId)
    {
        // Retrieve the user from your data source by ID
        // Return null if no user is found with the specified ID
        // Example implementation using Entity Framework:
        using (var dbContext = new MyDbContext())
        {
            return dbContext.Users.FirstOrDefault(u => u.Id == userId);
        }
    }

    public void DeleteUser(User user)
    {
        // Delete the specified user from your data source
        // Example implementation using Entity Framework:
        using (DbContext dbContext = new DbContext())
        {
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }
    }
}

// In your administrative code, you could have a method like this:

{ }
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



public User GetUserById(int userId)
{
    using (var dbContext = new MyDbContext())
    {
        // Find the user in the database with the specified ID
        return dbContext.Users.FirstOrDefault(u => u.Id == userId);
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

