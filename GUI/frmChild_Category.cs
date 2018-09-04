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
    public partial class frmChild_Category : Form
    {
        private int AddOrEdit = 0; // 0: add; 1: edit;
        private string id = null;
        private DialogResult dr = DialogResult.Cancel;
        private BUS.CategoryBUS bus = new BUS.CategoryBUS();

        public frmChild_Category()
        { 
            InitializeComponent();
        }

        public frmChild_Category(int type)
        {
            this.AddOrEdit = type;
            InitializeComponent();
        }

        public frmChild_Category(int type, List<String> s)
        {
            this.AddOrEdit = type;
            this.id = s[0];
            InitializeComponent();
            txtCategoryID.Text = s[0];
            txtCategoryName.Text = s[1];
            txtCategoryID.ReadOnly = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool result = false;
            CategoryDTO cate = new CategoryDTO {
                    CategoryID = txtCategoryID.Text,
                    CategoryName = txtCategoryName.Text
            };
            if (cate.CategoryID == String.Empty)
            {
                MessageBox.Show(this, "The New Category is added fail. CategoryID can'e empty!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AddOrEdit == 0)
            {
                result = bus.AddNewCategory(cate);
                if (result)
                {
                    MessageBox.Show(this, "The New Category is added successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "The New Category is added fail. CategoryID is existed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                result = bus.UpdateCategory(cate);
                if (result)
                {
                    MessageBox.Show(this, "The Category is updated successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "The Category is updated fail. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dr = DialogResult.Cancel;
            this.Close();
        }

        private void frmChild_Category_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = dr;
        }
    }
}
