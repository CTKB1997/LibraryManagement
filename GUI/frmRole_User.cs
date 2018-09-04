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
    public partial class frmRole_User : Form
    {
        private int role;
        private string UserID;
        private bool chkSearch = true;
        private bool chkPending = true;
        private bool chkLoanHistory = true;

        public frmRole_User()
        {
            InitializeComponent();
        }

        public frmRole_User(String UserID, int role)
        {
            this.role = role;
            InitializeComponent();
            this.UserID = UserID;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRole_User_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkSearch)
            {
                frmFunc_Search_User form = new frmFunc_Search_User(this.UserID);
                form.MdiParent = this;
                form.Show();
                chkSearch = false;
                form.FormClosing += (object sender1, FormClosingEventArgs ee) =>
                {
                    chkSearch = true;
                };
            }
            else
            {
                MessageBox.Show(this, "This form has appeared already!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewPendingStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkPending)
            {
                frmFunc_Pending form = new frmFunc_Pending(this.UserID);
                form.MdiParent = this;
                form.Show();
                chkPending = false;
                form.FormClosing += (object sender1, FormClosingEventArgs ee) =>
                {
                    chkPending = true;
                };
            }
            else
            {
                MessageBox.Show(this, "This form has appeared already!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
