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

namespace LibraryManagement
{
    public partial class Member : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        string str = @"Data Source=DUNKEYY;Initial Catalog=LibraryManagement;Integrated Security=True";
        public Member()
        {
            InitializeComponent();
        }

        void FillData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from tbMember";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Member_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            FillData();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibraryManagement lm = new LibraryManagement();
            lm.ShowDialog();
            this.Dispose();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into tbMember values('" + txtID.Text + "', N'" + txtName.Text + "', '" + txtPhone.Text + "', '" + dtBirth.Text + "', N'" + txtAddress.Text + "', '" + txtEmail.Text + "')";

            if ( string.IsNullOrEmpty(txtID.Text) )
            {
                lbErrorID.Text = "Don't blank ID";
            } else if ( string.IsNullOrEmpty(txtName.Text))
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
                        txtAddress.Text = null;
                        txtEmail.Text = null;
                        lbErrorID.Text = "";
                        lbErrorName.Text = "";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;

            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtBirth.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from tbMember where MemberID = '" + txtID.Text + "'";

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
                        MessageBox.Show("Deleted Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = null;
                        txtName.Text = null;
                        txtPhone.Text = null;
                        txtAddress.Text = null;
                        txtEmail.Text = null;
                        lbErrorID.Text = "";
                        lbErrorName.Text = "";
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
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update tbMember set MemberName = '" + txtName.Text + "', MemberPhone = '" + txtPhone.Text + "', MemberBirth = '" + dtBirth.Text + "', MemberAddress = '" + txtAddress.Text + "', Email = '" + txtEmail.Text + "' where MemberID = '" + txtID.Text + "'";

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
                        MessageBox.Show("Updated Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = null;
                        txtName.Text = null;
                        txtPhone.Text = null;
                        txtAddress.Text = null;
                        txtEmail.Text = null;
                        lbErrorID.Text = "";
                        lbErrorName.Text = "";
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtName.Text = null;
            txtPhone.Text = null;
            txtAddress.Text = null;
            txtEmail.Text = null;
            lbErrorID.Text = "";
            lbErrorName.Text = "";
        }

        private void dtBirth_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
