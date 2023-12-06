using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace LibraryManagement
{
    public partial class Book : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        string str = @"Data Source=DUNKEYY;Initial Catalog=LibraryManagement;Integrated Security=True";
        public Book()
        {
            InitializeComponent();
            
        }

        void FillData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from tbBook";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Book_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            FillData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;

            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTitle.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtAuthor.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtCategory.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtYear.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into tbBook values('" + txtID.Text + "', N'" + txtTitle.Text + "', N'" + txtAuthor.Text + "', N'" + txtCategory.Text + "', '" + txtYear.Text + "')";

            if (string.IsNullOrEmpty(txtID.Text))
            {
                lbErrorID.Text = "Don't blank ID";
            }
            else if (string.IsNullOrEmpty(txtTitle.Text))
            {
                lbErrorTitle.Text = "Don't blank Title";
            }
            else if (string.IsNullOrEmpty(txtAuthor.Text))
            {
                lbErrorAuthor.Text = "Don't blank Author";
            }
            else
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Inserted Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = null;
                    txtTitle.Text = null;
                    txtAuthor.Text = null;
                    txtYear.Text = null;
                    txtCategory.Text = null;
                    lbErrorID.Text = null;
                    lbErrorTitle.Text = null;
                    lbErrorAuthor.Text = null;
                }
                else
                {
                    MessageBox.Show("Insertion failed! Check your data and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                FillData();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from tbBook where BookID = '" + txtID.Text + "'";

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Deleted Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = null;
                txtTitle.Text = null;
                txtAuthor.Text = null;
                txtYear.Text = null;
                txtCategory.Text = null;
                lbErrorID.Text = null;
                lbErrorTitle.Text = null;
                lbErrorAuthor.Text = null;
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
            command.CommandText = "UPDATE tbBook SET BookTitle = N'"+txtTitle.Text+"', BookAuthor = N'"+txtAuthor.Text+"', BookCategory = N'"+txtCategory.Text+"', BookYear = '"+txtYear.Text+"' WHERE BookID = '"+txtID.Text+"'";

            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Updated Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Text = null;
                txtTitle.Text = null;
                txtAuthor.Text = null;
                txtYear.Text = null;
                txtCategory.Text = null;
                lbErrorID.Text = null;
                lbErrorTitle.Text = null;
                lbErrorAuthor.Text = null;
            }
            else
            {
                MessageBox.Show("Update failed! The specified record was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FillData();
            
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryManagement lm = new LibraryManagement();
            lm.ShowDialog();
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtTitle.Text = null;
            txtAuthor.Text = null;
            txtYear.Text = null;
            txtCategory.Text = null;
            lbErrorID.Text = null;
            lbErrorTitle.Text = null;
            lbErrorAuthor.Text = null;
        }
    }
}
