using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmChild_Book : Form
    {
        private int AddOrEdit = 0; // 0: Add; 1: Edit;
        private string id = null;
        private BUS.BookBUS bus = new BUS.BookBUS();
        private DialogResult dr = DialogResult.Cancel;

        public frmChild_Book()
        {
            InitializeComponent();
        }

        public frmChild_Book(int type)
        {
            this.AddOrEdit = type;
            InitializeComponent();
        }

        public frmChild_Book(int type, List<String> s)
        {
            this.id = s[0];
            this.AddOrEdit = type;
            InitializeComponent();
            txtBookID.Text = s[0];
            txtBookTitleID.Text = s[1];
            this.txtBookID.ReadOnly = true;

        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            if(AddOrEdit == 1)
            {
                txtBookID.Enabled = false;
            }
            else
            {
                txtBookID.Enabled = true;
            }
        }

        private bool check()
        {
            BUS.BookTitleBUS bkTitle = new BUS.BookTitleBUS();
            if (!bkTitle.IsBookTitleIDExisted(txtBookTitleID.Text))
            {
                MessageBox.Show(this, "The Book Title ID is invalid. Please checked it and try again!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BookDTO book = new BookDTO {
                BookID = txtBookID.Text,
                BookTitleID = txtBookTitleID.Text
            };
            if (!check()) return;
            bool result = false;
            if (AddOrEdit == 0)
            {
                result = bus.AddNewBookID(book);
                if (result)
                {
                    MessageBox.Show(this, "The New Book is added successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "The New Book is added fail. BookID is existed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                result = bus.UpdateBook(book);
                if (result)
                {
                    MessageBox.Show(this, "The Book is updated successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "The Book is updated fail. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dr = DialogResult.Cancel;
            this.Close();
        }

        private void frmChild_Book_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = dr;
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
