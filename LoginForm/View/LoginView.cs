using LoginForm.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginForm.View
{
    public partial class LoginView : Form
    {
        readonly LoginController loginController = new LoginController();
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            var users = loginController.GetAllUsers();
            bool correctUsername = false;
            bool correctPassword = false;
            foreach (var item in users)
            {
                Console.WriteLine("ITEM IS" + item.Username);
                if (item.Username == username)
                {
                    Console.WriteLine("FOUND USERNAME");
                    correctUsername = true;
                    if (item.Password == password)
                    {
                        Console.WriteLine("FOUND");
                        correctPassword = true;
                    }
                }
            }
            if (correctUsername)
            {
                Console.WriteLine("USERNAME IS CORRECT");

                if (correctPassword)
                {
                    Console.WriteLine("PASSWORD IS CORRECT");
                    MainView mainpage = new MainView();
                    this.Hide();
                    mainpage.Show();
                }
                else
                {
                    Console.WriteLine("PASSWORD IS WRONG");
                    MessageBox.Show("Wrong password");
                }

            }
            else
            {
                Console.WriteLine("USERNAME IS WRONG");
                MessageBox.Show("Wrong username");
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterView m = new RegisterView();
            this.Hide();
            m.Show();
        }
    }
}

