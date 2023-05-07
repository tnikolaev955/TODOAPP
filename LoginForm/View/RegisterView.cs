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

namespace LoginForm.View
{
    public partial class RegisterView : Form
    {
        readonly LoginController controller = new LoginController();
        public RegisterView()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
           string username = textBox1.Text;
           string password = textBox2.Text;
           if(username == string.Empty)
           {
                MessageBox.Show("Please enter your username");
           }
            User user = new User
            {
                Username = username,
                Password = password
            };

            controller.AddUser(user);
            LoginView m = new LoginView();
            this.Hide();
            m.Show();
        }
    }
}
