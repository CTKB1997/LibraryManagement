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
    public partial class frmChild_Author : Form
    {
        private int AddOrEdit = 0; // 0 - add; 1 - edit;
        private string id = null;
        private DialogResult dr = DialogResult.Cancel;
        private BUS.AuthorBUS bus = new BUS.AuthorBUS();

        public frmChild_Author()
        {
            InitializeComponent();
        }

        public frmChild_Author(int type)
        {
            this.AddOrEdit = type;
            InitializeComponent();
        }

        public frmChild_Author(int type, List<String> s)
        {
            this.AddOrEdit = type;
            this.id = s[0];
            InitializeComponent();
            txtAuthorID.Text = s[0];
            txtAuthorName.Text = s[1];
            this.txtAuthorID.ReadOnly = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool result = false;
            AuthorDTO auth = new AuthorDTO
            {
                AuthorID = txtAuthorID.Text,
                AuthorName = txtAuthorName.Text
            };
            if (auth.AuthorID == String.Empty)
            {
                MessageBox.Show(this, "The New Author is added fail. AuthorID can't empty!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AddOrEdit == 0)
            {
                
                result = bus.AddNewAuthor(auth);
                if (result)
                {
                    MessageBox.Show(this, "The New Author is added successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "The New Author is added fail. AuthorID is existed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                result = bus.UpdateAuthor(auth);
                if (result)
                {
                    MessageBox.Show(this, "The Author is updated successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "The Author is updated fail. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dr = DialogResult.Cancel;
            this.Close();
        }

        private void frmChild_Author_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = dr;
        }
    }
}
