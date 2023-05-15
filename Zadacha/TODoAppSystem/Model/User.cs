using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODoAppSystem.Model
{
    internal class User
    {
        public string Username { get; internal set; }
        public string Password { get; internal set; }
        public int Id { get; internal set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User()
        {
        }
    }
}
