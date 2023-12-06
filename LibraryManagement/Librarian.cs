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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace LibraryManagement
{
    public partial class Librarian : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DUNKEYY;Initial Catalog=LibraryManagement;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public Librarian()
        {
            InitializeComponent();
        }

        void FillData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from tbLibrarian";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Librarian_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            FillData();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryManagement libraryManagement = new LibraryManagement();
            libraryManagement.ShowDialog();
            this.Dispose();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into tbLibrarian values('" + txtID.Text + "', N'" + txtName.Text + "', '" + txtPhone.Text + "', '" + txtAge.Text + "')";

            if (string.IsNullOrEmpty(txtID.Text))
            {
                lbErrorID.Text = "Don't blank ID";
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                lbErrorName.Text = "Don't blank Name";
            }
            else
            {
                try
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Inserted Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = null;
                        txtName.Text = null;
                        txtPhone.Text = null;
                        txtAge.Text = null;
                        lbErrorID.Text = null;
                        lbErrorName.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Insertion failed! Check your data and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    FillData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE tbLibrarian SET LibrarianName = @Name, LibrarianPhone = @Phone, LibrarianAge = @Age WHERE LibrarianID = @ID";

            // Add parameters with their values
            command.Parameters.AddWithValue("@Name", txtName.Text);
            command.Parameters.AddWithValue("@Phone", txtPhone.Text);
            command.Parameters.AddWithValue("@Age", txtAge.Text);
            command.Parameters.AddWithValue("@ID", txtID.Text);

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = null;
                    txtName.Text = null;
                    txtPhone.Text = null;
                    txtAge.Text = null;
                    lbErrorID.Text = null;
                    lbErrorName.Text = null;
                }
                else
                {
                    MessageBox.Show("Update failed! The specified record was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FillData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
          

        private void dataGridView1_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtAge.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "Delete from tbLibrarian where LibrarianID= '" + txtID.Text + "'";

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Deleted Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = null;
                    txtName.Text = null;
                    txtPhone.Text = null;
                    txtAge.Text = null;
                    lbErrorID.Text = null;
                    lbErrorName.Text = null;
                }
                else
                {
                    MessageBox.Show("Deletion failed! The specified record was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FillData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtName.Text = null;
            txtPhone.Text = null;
            txtAge.Text = null;
            lbErrorID.Text = null;
            lbErrorName.Text = null;
        }
    }
}
