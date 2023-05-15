using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TODoAppSystem.Controller;
using TODoAppSystem.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TODoAppSystem.View
{
    public partial class RegisterView : Form
    {
        LoginController controller = new LoginController();
        public RegisterView()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string username = btn_Username.Text;
            string password = btn_Password.Text;
            if (username == string.Empty)
            {
                MessageBox.Show("Please enter your username");
            }
            Users user = new Users();
            user.Username = username;
            user.Password = password;

            controller.AddUser(user);
            LoginView m = new LoginView();
            this.Hide();
            m.Show();
        }
    }
}
