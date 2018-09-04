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
    public partial class frmFunc_Search_User : Form
    {
        private string UserID;
        public frmFunc_Search_User()
        {
            InitializeComponent();
        }

        public frmFunc_Search_User(string id)
        {
            this.UserID = id;
            InitializeComponent();
        }

        private void LoadData()
        {
            BUS._MultiTableBUS bus = new BUS._MultiTableBUS();
            string title = txtSearch.Text;
            bsItem.DataSource = bus.SelectBookTitleWithTitleOrAuthorNameOrCategoryName("", "", "");
            dgvSearch.DataSource = bsItem;
            bnItemList.BindingSource = bsItem;
            this.dgvSearch.Columns["AuthorID"].Visible = false;
            this.dgvSearch.Columns["CategoryID"].Visible = false;
        }
        private void frmFunc_Search_User_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BUS._MultiTableBUS bus = new BUS._MultiTableBUS();
            string title = txtSearch.Text;
            string authorName = "@@@";
            string categoryName = "@@@";
            if (chbAuthor.Checked) authorName = title;
            if (chbCategory.Checked) categoryName = title;
            bsItem.DataSource = bus.SelectBookTitleWithTitleOrAuthorNameOrCategoryName(title, authorName, categoryName);
            dgvSearch.DataSource = bsItem;
            bnItemList.BindingSource = bsItem;
            this.dgvSearch.Columns["AuthorID"].Visible = false;
            this.dgvSearch.Columns["CategoryID"].Visible = false;
        }

        private void btnAdvanceSearch_Click(object sender, EventArgs e)
        {
            var form = new frmFunc_AdvanceSearch();
            form.MdiParent = this.MdiParent;
            form.Show();
            form.FormClosing += (object sender1, FormClosingEventArgs ee) =>
            {
                if (form.DialogResult == DialogResult.OK)
                {
                    string title = form.bookTitle;
                    string authorName = form.authorName;
                    string categoryName = form.categoryName;
                    BUS._MultiTableBUS bus = new BUS._MultiTableBUS();
                    bsItem.DataSource = bus.SelectBookTitleWithTitleAndAuthorNameAndCategoryName(title, authorName, categoryName);
                    dgvSearch.DataSource = bsItem;
                    bnItemList.BindingSource = bsItem;
                    this.dgvSearch.Columns["AuthorID"].Visible = false;
                    this.dgvSearch.Columns["CategoryID"].Visible = false;
                }
            };
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dgvSearch.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSearch.Rows[selectedrowindex];
            if (selectedRow.Cells[0].Value != null && selectedRow.Cells[0].Value.ToString() != string.Empty)
            {
                string value = selectedRow.Cells[0].Value.ToString();
                BUS.RequestBUS bus = new BUS.RequestBUS();
                bool result = bus.AddNewRequest(UserID, value);
                if (result == true)
                {
                    MessageBox.Show("Borrow successful!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Borrow fail!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
