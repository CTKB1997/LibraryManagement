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
    public partial class frmChild_Request_History : Form
    {
        BUS.RequestBUS bus = new BUS.RequestBUS();
        public frmChild_Request_History()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            
            bsItem.DataSource = bus.SelectAllRequest();
            dgvHistory.DataSource = bsItem;
            bnList.BindingSource = bsItem;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchValue.Text = string.Empty;
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string UserID = txtSearchValue.Text;
            bsItem.DataSource = bus.SelectRequestByUserID(UserID);
            dgvHistory.DataSource = bsItem;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
