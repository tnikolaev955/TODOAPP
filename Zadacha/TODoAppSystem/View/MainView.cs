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

namespace TODoAppSystem.View
{
    public partial class MainView : Form
    {
        LoginController loginController = new LoginController();
        public MainView()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            dgvUsers.DataSource = loginController.GetAllUsers();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toDoAppSystemDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.toDoAppSystemDataSet.Users);
            RefreshData();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUsers.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            User user = new User();
            user.Username = btn_Username.Text;
            user.Password = btn_Password.Text;
            loginController.UpdateUser(id, user);
            RefreshData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUsers.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            loginController.DeleteUser(id);
            RefreshData();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string username = btn_Username.Text;
            string password = btn_Password.Text;
           /* if (username == string.Empty)
            {
                MessageBox.Show("Please enter your username");
            } */
            Users user = new Users();
            user.Username = username;
            user.Password = password;

            loginController.AddUser(user);
            RefreshData();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
