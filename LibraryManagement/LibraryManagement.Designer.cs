namespace LibraryManagement
{
    partial class LibraryManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Book = new System.Windows.Forms.Button();
            this.btn_Librarian = new System.Windows.Forms.Button();
            this.btn_Library = new System.Windows.Forms.Button();
            this.btn_Member = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sad = new System.Windows.Forms.Label();
            this.txtLibrarydsadasID = new System.Windows.Forms.Label();
            this.dsa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtReturn = new System.Windows.Forms.DateTimePicker();
            this.dtDue = new System.Windows.Forms.DateTimePicker();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLoanID = new System.Windows.Forms.TextBox();
            this.cBoxBookID = new System.Windows.Forms.ComboBox();
            this.cBoxLibraryID = new System.Windows.Forms.ComboBox();
            this.cBoxLibrarianID = new System.Windows.Forms.ComboBox();
            this.cBoxMemberID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(944, 257);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello, Admin";
            // 
            // btn_Book
            // 
            this.btn_Book.Location = new System.Drawing.Point(638, 214);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(75, 31);
            this.btn_Book.TabIndex = 2;
            this.btn_Book.Text = "Book";
            this.btn_Book.UseVisualStyleBackColor = true;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // btn_Librarian
            // 
            this.btn_Librarian.Location = new System.Drawing.Point(719, 214);
            this.btn_Librarian.Name = "btn_Librarian";
            this.btn_Librarian.Size = new System.Drawing.Size(75, 31);
            this.btn_Librarian.TabIndex = 3;
            this.btn_Librarian.Text = "Librarian";
            this.btn_Librarian.UseVisualStyleBackColor = true;
            this.btn_Librarian.Click += new System.EventHandler(this.btn_Librarian_Click);
            // 
            // btn_Library
            // 
            this.btn_Library.Location = new System.Drawing.Point(800, 214);
            this.btn_Library.Name = "btn_Library";
            this.btn_Library.Size = new System.Drawing.Size(75, 31);
            this.btn_Library.TabIndex = 4;
            this.btn_Library.Text = "Library";
            this.btn_Library.UseVisualStyleBackColor = true;
            this.btn_Library.Click += new System.EventHandler(this.btn_Library_Click);
            // 
            // btn_Member
            // 
            this.btn_Member.Location = new System.Drawing.Point(881, 214);
            this.btn_Member.Name = "btn_Member";
            this.btn_Member.Size = new System.Drawing.Size(75, 31);
            this.btn_Member.TabIndex = 5;
            this.btn_Member.Text = "Member";
            this.btn_Member.UseVisualStyleBackColor = true;
            this.btn_Member.Click += new System.EventHandler(this.btn_Member_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "List of Borrow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "LoanID";
            // 
            // sad
            // 
            this.sad.AutoSize = true;
            this.sad.Location = new System.Drawing.Point(147, 97);
            this.sad.Name = "sad";
            this.sad.Size = new System.Drawing.Size(43, 13);
            this.sad.TabIndex = 8;
            this.sad.Text = "BookID";
            // 
            // txtLibrarydsadasID
            // 
            this.txtLibrarydsadasID.AutoSize = true;
            this.txtLibrarydsadasID.Location = new System.Drawing.Point(147, 129);
            this.txtLibrarydsadasID.Name = "txtLibrarydsadasID";
            this.txtLibrarydsadasID.Size = new System.Drawing.Size(49, 13);
            this.txtLibrarydsadasID.TabIndex = 9;
            this.txtLibrarydsadasID.Text = "LibraryID";
            // 
            // dsa
            // 
            this.dsa.AutoSize = true;
            this.dsa.Location = new System.Drawing.Point(147, 160);
            this.dsa.Name = "dsa";
            this.dsa.Size = new System.Drawing.Size(58, 13);
            this.dsa.TabIndex = 10;
            this.dsa.Text = "LibrarianID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Checkout Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Return Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Due Date";
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckOut.Location = new System.Drawing.Point(491, 51);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(99, 20);
            this.dtCheckOut.TabIndex = 18;
            // 
            // dtReturn
            // 
            this.dtReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReturn.Location = new System.Drawing.Point(491, 91);
            this.dtReturn.Name = "dtReturn";
            this.dtReturn.Size = new System.Drawing.Size(99, 20);
            this.dtReturn.TabIndex = 19;
            // 
            // dtDue
            // 
            this.dtDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDue.Location = new System.Drawing.Point(491, 133);
            this.dtDue.Name = "dtDue";
            this.dtDue.Size = new System.Drawing.Size(99, 20);
            this.dtDue.TabIndex = 20;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(719, 25);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 49);
            this.btn_Insert.TabIndex = 21;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(832, 25);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 49);
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(719, 111);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 49);
            this.btn_Update.TabIndex = 23;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(832, 111);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(75, 49);
            this.btn_LogOut.TabIndex = 24;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "MemberID";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(454, 214);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtLoanID
            // 
            this.txtLoanID.Location = new System.Drawing.Point(206, 58);
            this.txtLoanID.Name = "txtLoanID";
            this.txtLoanID.Size = new System.Drawing.Size(100, 20);
            this.txtLoanID.TabIndex = 14;
            // 
            // cBoxBookID
            // 
            this.cBoxBookID.FormattingEnabled = true;
            this.cBoxBookID.Location = new System.Drawing.Point(206, 94);
            this.cBoxBookID.Name = "cBoxBookID";
            this.cBoxBookID.Size = new System.Drawing.Size(100, 21);
            this.cBoxBookID.TabIndex = 28;
            // 
            // cBoxLibraryID
            // 
            this.cBoxLibraryID.FormattingEnabled = true;
            this.cBoxLibraryID.Location = new System.Drawing.Point(206, 126);
            this.cBoxLibraryID.Name = "cBoxLibraryID";
            this.cBoxLibraryID.Size = new System.Drawing.Size(100, 21);
            this.cBoxLibraryID.TabIndex = 29;
            // 
            // cBoxLibrarianID
            // 
            this.cBoxLibrarianID.FormattingEnabled = true;
            this.cBoxLibrarianID.Location = new System.Drawing.Point(206, 157);
            this.cBoxLibrarianID.Name = "cBoxLibrarianID";
            this.cBoxLibrarianID.Size = new System.Drawing.Size(100, 21);
            this.cBoxLibrarianID.TabIndex = 30;
            // 
            // cBoxMemberID
            // 
            this.cBoxMemberID.FormattingEnabled = true;
            this.cBoxMemberID.Location = new System.Drawing.Point(206, 187);
            this.cBoxMemberID.Name = "cBoxMemberID";
            this.cBoxMemberID.Size = new System.Drawing.Size(100, 21);
            this.cBoxMemberID.TabIndex = 31;
            // 
            // LibraryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 520);
            this.Controls.Add(this.cBoxMemberID);
            this.Controls.Add(this.cBoxLibrarianID);
            this.Controls.Add(this.cBoxLibraryID);
            this.Controls.Add(this.cBoxBookID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.dtDue);
            this.Controls.Add(this.dtReturn);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.txtLoanID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dsa);
            this.Controls.Add(this.txtLibrarydsadasID);
            this.Controls.Add(this.sad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Member);
            this.Controls.Add(this.btn_Library);
            this.Controls.Add(this.btn_Librarian);
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LibraryManagement";
            this.Text = "LibraryManagement";
            this.Load += new System.EventHandler(this.LibraryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Book;
        private System.Windows.Forms.Button btn_Librarian;
        private System.Windows.Forms.Button btn_Library;
        private System.Windows.Forms.Button btn_Member;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sad;
        private System.Windows.Forms.Label txtLibrarydsadasID;
        private System.Windows.Forms.Label dsa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
        private System.Windows.Forms.DateTimePicker dtReturn;
        private System.Windows.Forms.DateTimePicker dtDue;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLoanID;
        private System.Windows.Forms.ComboBox cBoxBookID;
        private System.Windows.Forms.ComboBox cBoxLibraryID;
        private System.Windows.Forms.ComboBox cBoxLibrarianID;
        private System.Windows.Forms.ComboBox cBoxMemberID;
    }
}