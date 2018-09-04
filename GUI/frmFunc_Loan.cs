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
    public partial class frmFunc_Loan : Form
    {
        private BUS.LoanBUS bus = new BUS.LoanBUS();

        public frmFunc_Loan()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            bsItem.DataSource = bus.getLoanByStatus(0);
            dgvView.DataSource = bsItem;
            bnItemList.BindingSource = bsItem;
        }

        private void frmFunc_Loan_Load(object sender, EventArgs e)
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
                    bool result = bus.UpdateLoanStatusByLoanID(value, 1);
                    string BookID = selectedRow.Cells[2].Value.ToString();
                    BUS.InventoryBUS invBUS = new BUS.InventoryBUS();
                    invBUS.UpdateInventoryStatusByBookID(BookID, 0);
                    if (result)
                    {
                        LoadData();
                        MessageBox.Show("Update Loan Table successful!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update Loan Table fail!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch(Exception ex)
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
                    bool result = bus.UpdateLoanStatusByLoanID(value, 2);
                    if (result)
                    {
                        LoadData();
                        MessageBox.Show("Update Loan Table successful!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update Loan Table fail!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
