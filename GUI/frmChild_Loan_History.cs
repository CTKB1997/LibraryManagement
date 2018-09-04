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
    public partial class frmChild_Loan_History : Form
    {
        int role;
        string UserID;

        public frmChild_Loan_History()
        {
            InitializeComponent();
        }

        public frmChild_Loan_History(int role, string UserID)
        {
            this.UserID = UserID;
            this.role = role;
            InitializeComponent();
            LoadData(role, UserID);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmChild_Loan_History_Load(object sender, EventArgs e)
        {
            if(role == 1)
            {
                txtSearch.Hide();
                btnSearch.Hide();
                LoadData(role, UserID);
            }
            else
            {
                LoadData(role, UserID);
            }
        }

        public void LoadData(int role, string UserID)
        {
            BUS.LoanBUS bus = new BUS.LoanBUS();
            if (role == 1)
            {
                
                bsItem.DataSource = bus.getLoanByID(UserID);
                dgvHistory.DataSource = bsItem;

            }
            else
            {
                bsItem.DataSource = bus.getAllLoans();
                dgvHistory.DataSource = bsItem;
                
            }
            bnList.BindingSource = bsItem;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BUS.LoanBUS bus = new BUS.LoanBUS();
            string searchValue = txtSearch.Text;
            if(searchValue == "")
            {
                bsItem.DataSource = bus.getAllLoans();
                dgvHistory.DataSource = bsItem;
                return;
            }
            
            bsItem.DataSource = bus.getLoanByID(searchValue);
            dgvHistory.DataSource = bsItem;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            LoadData(role, UserID);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
