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
    public partial class LibraryManagement : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        string str = @"Data Source=DUNKEYY;Initial Catalog=LibraryManagement;Integrated Security=True";
        public LibraryManagement()
        {
            InitializeComponent();
        }

        public void FillData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from tbLoan";
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void FillcBoxBookID()
        {
            command = connection.CreateCommand();
            command.CommandText = "select BookID from tbBook";
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cBoxBookID.DataSource = dt;
            cBoxBookID.DisplayMember = "BookID";
            cBoxBookID.ValueMember = "BookID";
        }

        public void FillcBoxLibraryID()
        {
            command = connection.CreateCommand();
            command.CommandText = "select LibraryID from tbLibrary";
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cBoxLibraryID.DataSource = dt;
            cBoxLibraryID.DisplayMember = "LibraryID";
            cBoxLibraryID.ValueMember = "LibraryID";
        }

        public void FillcBoxLibrarianID()
        {
            command = connection.CreateCommand();
            command.CommandText = "select LibrarianID from tbLibrarian";
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cBoxLibrarianID.DataSource = dt;
            cBoxLibrarianID.DisplayMember = "LibrarianID";
            cBoxLibrarianID.ValueMember = "LibrarianID";
        }

        public void FillcBoxMemberID()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MemberID from tbMember";
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cBoxMemberID.DataSource = dt;
            cBoxMemberID.DisplayMember = "MemberID";
            cBoxMemberID.ValueMember = "MemberID";
        }

        private void LibraryManagement_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            FillData();
            FillcBoxBookID();
            FillcBoxLibraryID();
            FillcBoxMemberID();
            FillcBoxLibrarianID();
        } 

        private void btn_Member_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member m = new Member();
            m.ShowDialog();
            this.Dispose();
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book b = new Book();
            b.ShowDialog();
            this.Dispose();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Dispose();
        }

        private void btn_Librarian_Click(object sender, EventArgs e)
        {
            this.Hide();
            Librarian librarian = new Librarian();
            librarian.ShowDialog();
            this.Dispose();
        }

        private void btn_Library_Click(object sender, EventArgs e)
        {
            this.Hide();
            Library b = new Library();
            b.ShowDialog();
            this.Dispose();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into tbLoan values('" + txtLoanID.Text + "', '" + cBoxBookID.Text + "', '" + cBoxLibraryID.Text + "', '" + cBoxLibrarianID.Text + "', '" + cBoxMemberID.Text + "', '" + dtCheckOut.Text + "', '" + dtReturn.Text + "', '" + dtDue.Text + "')";

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Inserted Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;

            txtLoanID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cBoxBookID.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cBoxLibraryID.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            cBoxLibrarianID.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            cBoxMemberID.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            dtCheckOut.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            dtReturn.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            dtDue.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from tbLoan where LoanID = '" + txtLoanID.Text + "'";

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Deleted Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update tbLoan set BookID = '" + cBoxBookID.Text + "', LibraryID = '" + cBoxLibraryID.Text + "', LibrarianID = '" + cBoxLibrarianID.Text + "', MemberID = '" + cBoxMemberID.Text + "', CheckoutDate = '" + dtCheckOut.Text + "', ReturnDate = '" + dtReturn.Text + "', DueDate = '" + dtDue.Text + "'";

            try
            {
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLoanID.Text = null;
        }
    }
}
