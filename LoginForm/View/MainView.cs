using LoginForm.Model;
using LoginForm.Model.LoginForm.Data;
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
    public partial class MainView : Form
    {
        private List<User> users;

        public MainView(ListBox listBox)
        {
            InitializeComponent();
            MainView_Load(listBox);
        }

        private void MainView_Load(ListBox ListBox1)
        {
            MyDbContext dbContext = new MyDbContext();
            NewMethod(dbContext);

            foreach (User user in users)
            {
                ListBox1.Items.Add(user.Name);
            }

            textBox1.TextChanged += (s, evt) =>
            {
                string searchText = textBox1.Text;
                object value = ListBox1.Items.Clear();
                foreach (User user in users.Where(u => { object Name = u.Name; return base.Name.Contains(searchText); }))
                {
                    ListBox1.Items.Add(user.Name);
                }
            };

            textBox1.Text = "Hello, World!";
            button1.Click += new EventHandler(Button1_Click);
        }

        private void NewMethod(MyDbContext dbContext)
        {
            users = dbContext.Users.ToList();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 3 was clicked!");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 1 was clicked!");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string SearchText = text;
        }
    }
}
