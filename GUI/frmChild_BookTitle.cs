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
    public partial class frmChild_BookTitle : Form
    {
        private int AddOrEdit = 0; // 0: add, 1: edit;
        private string id = null;
        private DialogResult dr = DialogResult.Cancel;
        private BUS.BookTitleBUS bus = new BUS.BookTitleBUS();

        public frmChild_BookTitle()
        {
            InitializeComponent();
        }

        public frmChild_BookTitle(int type)
        {
            this.AddOrEdit = type;
            InitializeComponent();
        }

        public frmChild_BookTitle(int type, List<String> s)
        {
            this.AddOrEdit = type;
            
            
            this.id = s[0];
            InitializeComponent();
            txtBookTitleID.Text = s[0];
            txtTitle.Text = s[1];
            txtAuthorID.Text = s[2];
            txtCategoryID.Text = s[3];
        }

        private void frmBookTitle_Load(object sender, EventArgs e)
        {
            if (AddOrEdit == 1)
            {
                txtBookTitleID.Enabled = false;
            }
            else
            {
                txtBookTitleID.Enabled = true;
            }
        }

        private bool check()
        {
            
            BUS.AuthorBUS auBUS = new BUS.AuthorBUS();
            BUS.CategoryBUS cateBUS = new BUS.CategoryBUS();
            if (!auBUS.IsAuthorExisted(txtAuthorID.Text))
            {
                MessageBox.Show(this, "The New Book Title is invalid. Please checked it and try again!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!cateBUS.IsCategoryIDExisted(txtCategoryID.Text))
            {
                MessageBox.Show(this, "The New Book Title is invalid. Please checked it and try again!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (check() == false) return;
            bool result = false;
            BookTitleDTO bt = new BookTitleDTO {
                BookTitleID = txtBookTitleID.Text,
                AuthorID = txtAuthorID.Text,
                CategoryID = txtCategoryID.Text,
                Title = txtTitle.Text
            };
            if (AddOrEdit == 0)
            {
                result = bus.AddNewBookTitle(bt);
                if (result)
                {
                    MessageBox.Show(this, "The New Book Title is added successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "The New Book Title is added fail. BookID is existed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                result = bus.UpdateBookTitle(bt);
                if (result)
                {
                    MessageBox.Show(this, "The Book Title is updated successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "The Book Title is updated fail. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dr = DialogResult.Cancel;
            this.Close();
        }

        private void frmChild_BookTitle_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = dr;

        }
    }
}
