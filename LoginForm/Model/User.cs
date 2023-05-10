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
