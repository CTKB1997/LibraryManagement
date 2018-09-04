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
    public partial class frmFunc_Pending : Form
    {
        private string userID;

        public frmFunc_Pending()
        {
            InitializeComponent();
        }

        public frmFunc_Pending(string id)
        {
            this.userID = id;
            InitializeComponent();
        }

        private void LoadData()
        {
            BUS._MultiTableBUS bus = new BUS._MultiTableBUS();
            bsItem.DataSource = bus.SelectRequestByUserIDAndStatus(this.userID, "0");
            dgvView.DataSource = bsItem;
            bnItemList.BindingSource = bsItem;
        }

        private void frmFunc_Pending_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dgvView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvView.Rows[selectedrowindex];
            //MessageBox.Show(selectedRow.Cells[0].Value.ToString());
            if (selectedRow.Cells[0].Value != null && selectedRow.Cells[0].Value.ToString() != string.Empty)
            {
                string value = selectedRow.Cells[0].Value.ToString();
                BUS.RequestBUS reqBUS = new BUS.RequestBUS();
                if (reqBUS.UpdateRequest(value, 1))
                {
                    LoadData();
                    MessageBox.Show("Cancel successful!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Cancel fail!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
