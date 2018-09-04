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
    public partial class frmFunc_Search_StaffManager : Form
    {
        private int TypeOfSearch = 0; // 0 - book title, 1 - author, 2 - category, 3 - user, 4 - book id, 5 - inventory
        private int Role = 1; // 0 - manager, 1 - staff;

        public frmFunc_Search_StaffManager()
        {
            InitializeComponent();
            LoadData();
        }

        public frmFunc_Search_StaffManager(int type, int role)
        {
            this.TypeOfSearch = type;
            this.Role = role;
            InitializeComponent();
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            switch (TypeOfSearch)
            {
                case 0: this.Text = "Book Title"; break;
                case 1: this.Text = "Author"; break;
                case 2: this.Text = "Category"; break;
                case 3: this.Text = "User"; break;
                case 4: this.Text = "Book"; break;
                case 5: this.Text = "Inventory"; break;
            }
            switch (TypeOfSearch)
            {
                case 0:
                    BUS.BookTitleBUS bkTitle = new BUS.BookTitleBUS();
                    //BUS._MultiTableBUS bus = new BUS._MultiTableBUS();
                    bsItem.DataSource = bkTitle.GetAllBookTitleByDataSet();
                    //bsItem.DataSource = bus.SelectBookTitleWithTitleOrAuthorNameOrCategoryName("", "", "");
                    dgvSearch.DataSource = bsItem;
                    bnItemList.BindingSource = bsItem;
                    this.dgvSearch.Columns["AuthorID"].Visible = true;
                    this.dgvSearch.Columns["CategoryID"].Visible = true;
                    break;
                case 1:
                    BUS.AuthorBUS author = new BUS.AuthorBUS();
                    bsItem.DataSource = author.GetAllAuthorByDataSet();
                    dgvSearch.DataSource = bsItem;
                    bnItemList.BindingSource = bsItem;
                    break;
                case 2:
                    BUS.CategoryBUS cate = new BUS.CategoryBUS();
                    bsItem.DataSource = cate.getAllCategoryByDataSet();
                    dgvSearch.DataSource = bsItem;
                    bnItemList.BindingSource = bsItem;
                    break;
                case 3:
                    BUS.UserBUS user = new BUS.UserBUS();
                    bsItem.DataSource = user.getAllUserByDataSet();
                    dgvSearch.DataSource = bsItem;
                    bnItemList.BindingSource = bsItem;
                    break;
                case 4:
                    BUS.BookBUS bk = new BUS.BookBUS();
                    bsItem.DataSource = bk.getAllBookIDByDataSet();
                    dgvSearch.DataSource = bsItem;
                    bnItemList.BindingSource = bsItem;
                    break;
                case 5:
                    BUS.InventoryBUS inven = new BUS.InventoryBUS();
                    bsItem.DataSource = inven.getAllInventoryByDataSet();
                    dgvSearch.DataSource = bsItem;
                    bnItemList.BindingSource = bsItem;
                    break;
            }

            int width = 0;
            foreach (DataGridViewColumn col in dgvSearch.Columns)
            {
                width += col.Width;
            }
            width += dgvSearch.RowHeadersWidth;

            dgvSearch.ClientSize = new Size(width + 2, dgvSearch.ClientSize.Height);

            if (this.Role == 1 && this.TypeOfSearch != 4 && this.TypeOfSearch != 0 && this.TypeOfSearch != 5)
            {
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
            }

        }

        private void frmFunc_Search_StaffManager_Load(object sender, EventArgs e)
        {
            int width = 0;
            foreach (DataGridViewColumn col in dgvSearch.Columns)
            {
                width += col.Width;
            }
            width += dgvSearch.RowHeadersWidth;

            dgvSearch.ClientSize = new Size(width + 2, dgvSearch.ClientSize.Height);
            if (TypeOfSearch != 0)
            {
                chbAuthor.Hide();
                chbCategory.Hide();
                txtSearch.Hide();
                btnAdvanceSearch.Hide();
                btnSearch.Hide();
                if (TypeOfSearch != 3 && TypeOfSearch != 5) this.Size = new Size(370, 400);
                if (TypeOfSearch == 3) this.Size = new Size(800, 400);
                if (TypeOfSearch == 5) this.Size = new Size(600, 400);
            } else
            {
                this.Size = new Size(600, 500);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form form = new frmChild_BookTitle(0);
            switch (TypeOfSearch)
            {
                case 0: form = new frmChild_BookTitle(0); break;
                case 1: form = new frmChild_Author(0); break;
                case 2: form = new frmChild_Category(0); break;
                case 3: form = new frmChild_User(0); break;
                case 4: form = new frmChild_Book(0); break;
                case 5: form = new frmChild_Inventory(0); break;
            }

            form.MdiParent = this.MdiParent;
            form.FormClosing += (object sender1, FormClosingEventArgs ee) =>
            {
                if (form.DialogResult == DialogResult.OK)
                {
                    //MessageBox.Show("OK!");
                    LoadData();
                }
                   
            };
            form.Show();
            /**DialogResult r = form.ShowDialog();
            if (r == DialogResult.OK)
            {
                LoadData();
            } **/
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form form = new frmChild_BookTitle(1);
            int selectedrowindex = 0;
            DataGridViewRow selectedRow = null;
            try
            {
                selectedrowindex = dgvSearch.SelectedCells[0].RowIndex;
                selectedRow = dgvSearch.Rows[selectedrowindex];
                List<String> list = new List<string>();
                //MessageBox.Show(selectedRow.Cells[0].Value.ToString());
                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[0].Value.ToString() != string.Empty)
                {
                    //value = (string)selectedRow.Cells[0].Value;
                    foreach (DataGridViewCell cell in selectedRow.Cells)
                    {
                        if (cell.Value != null)
                        {
                            list.Add(cell.Value.ToString());
                        }
                        else list.Add("");
                    }
                    switch (TypeOfSearch)
                    {
                        case 0: form = new frmChild_BookTitle(1, list); break;
                        case 1: form = new frmChild_Author(1, list); break;
                        case 2: form = new frmChild_Category(1, list); break;
                        case 3: form = new frmChild_User(1, list); break;
                        case 4: form = new frmChild_Book(1, list); break;
                        case 5: form = new frmChild_Inventory(1, list); break;
                    }

                    form.MdiParent = this.MdiParent;
                    form.FormClosing += (object sender1, FormClosingEventArgs ee) =>
                    {
                        if (form.DialogResult == DialogResult.OK)
                        {
                            LoadData();
                        }

                    };
                    form.Show();
                }
                else
                {
                    MessageBox.Show(this, "Can not update null cells", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Choose to update");
            }
            
             
            
            /**
            DialogResult r = form.ShowDialog();
            if (r == DialogResult.OK)
            {
                LoadData();
            } **/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form form = new frmChild_BookTitle();
            int selectedrowindex = dgvSearch.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSearch.Rows[selectedrowindex];
            if (selectedRow.Cells[0].Value != null && selectedRow.Cells[0].Value.ToString() != string.Empty)
            {
                string value = (string)selectedRow.Cells[0].Value;
                bool result = false;
                switch (TypeOfSearch)
                {
                    case 0:
                        BUS.BookTitleBUS bkTitle = new BUS.BookTitleBUS();
                        result = bkTitle.DeleteBookTitle(value);
                        break;
                    case 1:
                        BUS.AuthorBUS author = new BUS.AuthorBUS();
                        result = author.DeleteAuthor(value);
                        break;
                    case 2:
                        BUS.CategoryBUS cate = new BUS.CategoryBUS();
                        result = cate.DeleteCategory(value);
                        break;
                    case 3:
                        BUS.UserBUS user = new BUS.UserBUS();
                        result = user.DeleteUser(value);
                        break;
                    case 4:
                        BUS.BookBUS bk = new BUS.BookBUS();
                        result = bk.DeleteAuthor(value);
                        break;
                    case 5:
                        BUS.InventoryBUS inven = new BUS.InventoryBUS();
                        result = inven.DeleteInventory(value);
                        break;
                }
                if (result)
                {
                    LoadData();
                    MessageBox.Show(this, "Delete Successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Delete Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show(this, "Can not delete null cells", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    //MessageBox.Show("OK!");
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
    }
}
