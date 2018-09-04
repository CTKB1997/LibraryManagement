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
    public partial class frmRole_Manager : Form
    {
        private int role;
        private string UserID;
        private bool chkBookTitle = true;
        private bool chkAuthor = true;
        private bool chkCategory = true;
        private bool chkUser = true;
        private bool chkBook = true;
        private bool chkInventory = true;
        private bool chkLoanHistory = true;
        private bool chkRequestHistory = true;

        public frmRole_Manager()
        {
            InitializeComponent();
        }

        public frmRole_Manager(String UserID, int role)
        {
            this.role = role;
            InitializeComponent();
            this.UserID = UserID;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void searchBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkBookTitle)
            { 
                frmFunc_Search_StaffManager form = new frmFunc_Search_StaffManager(0, 0);
                form.MdiParent = this;
                form.Show();
                chkBookTitle = false;
                form.FormClosing += (object sender1, FormClosingEventArgs ee) =>
                {
                    chkBookTitle = true;
                };
            } else
            {
                MessageBox.Show(this, "This form has appeared already!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void authorsInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkAuthor) { 
                frmFunc_Search_StaffManager form = new frmFunc_Search_StaffManager(1, 0);
                form.MdiParent = this;
                form.Show();
                chkAuthor = false;
                form.FormClosing += (object sender1, FormClosingEventArgs ee) =>
                {
                    chkAuthor = true;
                };
            } else
            {
                MessageBox.Show(this, "This form has appeared already!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkCategory)
            {
                frmFunc_Search_StaffManager form = new frmFunc_Search_StaffManager(2, 0);
                form.MdiParent = this;
                form.Show();
                chkCategory = false;
                form.FormClosing += (object sender1, FormClosingEventArgs ee) =>
                {
                    chkCategory = true;
                };
            }
            else
            {
                MessageBox.Show(this, "This form has appeared already!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (chkUser)
            {
                frmFunc_Search_StaffManager form = new frmFunc_Search_StaffManager(3, 0);
                form.MdiParent = this;
                form.Show();
                chkUser = false;
                form.FormClosing += (object sender1, FormClosingEventArgs ee) =>
                {
                    chkUser = true;
                };
            }
            else
            {
                MessageBox.Show(this, "This form has appeared already!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewBookIDtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkBook)
            {
                frmFunc_Search_StaffManager form = new frmFunc_Search_StaffManager(4, 0);
                form.MdiParent = this;
                form.Show();
                chkBook = false;
                form.FormClosing += (object sender1, FormClosingEventArgs ee) =>
                {
                    chkBook = true;
                };
            }
            else
            {
                MessageBox.Show(this, "This form has appeared already!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (chkInventory)
            {
                frmFunc_Search_StaffManager form = new frmFunc_Search_StaffManager(5, 0);
                form.MdiParent = this;
                form.Show();
                chkInventory = false;
                form.FormClosing += (object sender1, FormClosingEventArgs ee) =>
                {
                    chkInventory = true;
                };
            }
            else
            {
                MessageBox.Show(this, "This form has appeared already!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRole_Manager_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void loansHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkLoanHistory)
            {
                frmChild_Loan_History form = new frmChild_Loan_History(role, UserID);
                form.MdiParent = this;
                form.Show();
                chkLoanHistory = false;
                form.FormClosing += (object sender1, FormClosingEventArgs ee) =>
                {
                    chkLoanHistory = true;
                };
            }
            else
            {
                MessageBox.Show(this, "This form has appeared already!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void requestsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkRequestHistory)
            {
                frmChild_Request_History form = new frmChild_Request_History();
                form.MdiParent = this;
                form.Show();
                chkRequestHistory = false;
                form.FormClosing += (object sender1, FormClosingEventArgs ee) =>
                {
                    chkRequestHistory = true;
                };
            }
            else
            {
                MessageBox.Show(this, "This form has appeared already!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
