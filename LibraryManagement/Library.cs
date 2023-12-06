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
    public partial class Library : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        string str = @"Data Source=DUNKEYY;Initial Catalog=LibraryManagement;Integrated Security=True";
        public Library()
        {
            InitializeComponent();
        }

        void FillData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from tbLibrary";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Library_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            FillData();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryManagement lm = new LibraryManagement();
            lm.ShowDialog();
            this.Dispose();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into tbLibrary values('" + txtID.Text + "', N'" + txtName.Text + "', '" + txtPhone.Text + "', N'" + txtAddress.Text + "')";

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
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Inserted Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = null;
                    txtName.Text = null;
                    txtPhone.Text = null;
                    txtAddress.Text = null;
                    lbErrorID.Text = null;
                    lbErrorName.Text = null;
                }
                else
                {
                    MessageBox.Show("Insertion failed! Check your data and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FillData();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from tbLibrary where LibraryID = '" + txtID.Text + "'";

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Deleted Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = null;
                txtName.Text = null;
                txtPhone.Text = null;
                txtAddress.Text = null;
                lbErrorID.Text = null;
                lbErrorName.Text = null;
            }
            else
            {
                MessageBox.Show("Deletion failed! The specified record was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FillData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update tbLibrary set LibraryName = N'" + txtName.Text + "', LibraryPhone = '" + txtPhone.Text + "', LibraryAddress = N'" + txtAddress.Text + "' where LibraryID = '" + txtID.Text + "'";

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Updated Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = null;
                txtName.Text = null;
                txtPhone.Text = null;
                txtAddress.Text = null;
                lbErrorID.Text = null;
                lbErrorName.Text = null;
            }
            else
            {
                MessageBox.Show("Update failed! The specified record was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FillData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtName.Text = null;
            txtPhone.Text = null;
            txtAddress.Text = null;
            lbErrorID.Text = null;
            lbErrorName.Text = null;
        }
    }
}
