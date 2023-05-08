using LoginForm.Model;
using LoginForm.Model.LoginForm.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LoginForm.View
{
    public partial class MainView : Form
    {
        private List<User> users;
        private string username;
        private string password;

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
            string username = textBox1.Text;
            string password = textBox2.Text;


            SqlConnection conn = new SqlConnection("ConnectionString");
            
                conn.Open();
                string sql = "INSERT INTO [Users](Username, Password) VALUES (@Username, @Password)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.ExecuteNonQuery();
            

            DataTable dt = (DataTable)dataGridView1.DataSource;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Users]", conn);
            dt.Clear();
            da.Fill(dt);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string usernameFormTextBox = textBox1.Text;
            string passwordFormTextBox = textBox2.Text;

            SqlConnection conn = new SqlConnection("ConnectionString");

            conn.Open();
            string sql = "UPDATE [Users] SET Name = @UsernameFormTxtBox, Password = @PasswordFormTxtBox WHERE Username = @Username";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@UsernameFormTxtBox", usernameFormTextBox);
            cmd.Parameters.AddWithValue("@PasswordFormTxtBox ", passwordFormTextBox);
            cmd.ExecuteNonQuery();


            
            DataGridViewRow row = dataGridView1.CurrentRow;
            row.Cells["Username"].Value = usernameFormTextBox;
            row.Cells["Password"].Value = passwordFormTextBox;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string SearchText = text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                username = row.Cells["Username"].Value.ToString();
                password = row.Cells["Password"].Value.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Connection String");

        conn.Open();
            string sql = "DELETE FROM [Users] WHERE Username = @Username";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.ExecuteNonQuery();


           
            DataTable dt = (DataTable)dataGridView1.DataSource;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM [Users]", conn);
            dt.Clear();
            da.Fill(dt);
        }
    }
}
