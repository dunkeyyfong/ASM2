using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            lblError.Hide();
            connection = new SqlConnection("Data Source=DUNKEYY;Initial Catalog=LibraryManagement;Integrated Security=True");
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string query = "select * from tbAccount where username = @username and u_pass = @password";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string role = reader["u_role"].ToString();
                if (role.Equals("admin"))
                {
                    MessageBox.Show(this, "Login Successfull", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    LibraryManagement l = new LibraryManagement();
                    l.ShowDialog();
                    this.Dispose();
                }
                else
                    lblError.Text = "You are not allowed to access";
            }
            else
            {
                lblError.Show();
                lblError.Text = "Wrong username or password";
            }
            connection.Close();
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show(this, "Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                Application.Exit();
            }
        }
    }
}
