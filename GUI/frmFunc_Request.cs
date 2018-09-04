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
    public partial class frmFunc_Request : Form
    {
        public frmFunc_Request()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            BUS.RequestBUS bus = new BUS.RequestBUS();
            bsItem.DataSource = bus.SelectRequestByRequestStatus(0);
            dgvView.DataSource = bsItem;
            bnItemList.BindingSource = bsItem;
        }

        private void frmFunc_Request_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = dgvView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvView.Rows[selectedrowindex];
                //MessageBox.Show(selectedRow.Cells[0].Value.ToString());
                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[0].Value.ToString() != string.Empty)
                {
                    string value = selectedRow.Cells[0].Value.ToString();
                    BUS._MultiTableBUS bus = new BUS._MultiTableBUS();
                    if (bus.AcceptRequest(value) == true)
                    {
                        LoadData();
                        MessageBox.Show("Confirm successful!!!\n Find it at " + bus.stt, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Confirm fail!!! Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedrowindex = dgvView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvView.Rows[selectedrowindex];
                //MessageBox.Show(selectedRow.Cells[0].Value.ToString());
                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[0].Value.ToString() != string.Empty)
                {
                    string value = selectedRow.Cells[0].Value.ToString();
                    BUS.RequestBUS reqBUS = new BUS.RequestBUS();
                    if (reqBUS.UpdateRequest(value, 3))
                    {
                        LoadData();
                        MessageBox.Show("Decline successful!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Decline fail!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {

            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
