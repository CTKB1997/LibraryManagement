using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class frmChild_Inventory : Form
    {
        private int AddOrEdit; // 0 - add; 1 - edit;
        private string id;
        private DialogResult dr = DialogResult.Cancel;
        private BUS.InventoryBUS bus = new BUS.InventoryBUS();

        public frmChild_Inventory()
        {
            InitializeComponent();
        }

        public frmChild_Inventory(int type)
        {
            this.AddOrEdit = type;
            InitializeComponent();
        }

        public frmChild_Inventory(int type, List<string> s)
        {
            this.AddOrEdit = type;
            this.id = s[0];
            InitializeComponent();
            txtInventoryID.Text = s[0];
            txtBookID.Text = s[1];
            txtIndex.Text = s[2];
            cbStatus.Checked = (s[3] == "True");


        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            if(AddOrEdit == 1)
            {
                txtInventoryID.Enabled = false;
            }
            else
            {
                txtInventoryID.Enabled = true;
            }
        }

        private bool check()
        {
            BUS.BookBUS bkBUS = new BUS.BookBUS();
            if (!bkBUS.IsBookIDExisted(txtBookID.Text))
            {
                MessageBox.Show(this, "The Book ID is invalid. Please checked it and try again!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            bool result = false;
            InventoryDTO inv = new InventoryDTO {
                BookID = txtBookID.Text,
                Index = txtIndex.Text,
                InventoryID= txtInventoryID.Text,
                Status = 0
            };
            if (inv.InventoryID == String.Empty)
            {
                MessageBox.Show(this, "The New Inventory is added fail. InventoryID Can't empty!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (AddOrEdit == 0)
            {                
                if (cbStatus.Checked) inv.Status = 1;
                result = bus.AddNewInventory(inv);
                if (result)
                {
                    MessageBox.Show(this, "The New Inventory is added successful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "The New Inventory is added fail. InventoryID is existed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (cbStatus.Checked) inv.Status = 1;
                result = bus.UpdateInventory(inv, inv.Status);
                if (result)
                {
                    MessageBox.Show(this, "The Inventory is updated successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "The Inventory is updated fail. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dr = DialogResult.Cancel;
            this.Close();
        }

        private void frmChild_Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = dr;
        }
    }
}
