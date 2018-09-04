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
    public partial class frmChild_User : Form
    {
        private int AddOrEdit; // 0: Add; 1: Edit;
        private string id;
        private BUS.UserBUS bus = new BUS.UserBUS();
        private DialogResult dr = DialogResult.Cancel;

        public frmChild_User()
        {
            InitializeComponent();
        }

        public frmChild_User(int type)
        {
            this.AddOrEdit = type;
            InitializeComponent();
        }

        public frmChild_User(int type, List<String> s)
        {
            this.id = s[0];
            this.AddOrEdit = type;
            InitializeComponent();
            txtUserID.Text = s[0];
            txtUserName.Text = s[1];
            txtPassword.Text = s[2];
            txtPhone.Text = s[3];
            txtEmail.Text = s[4];
            txtRole.Text = s[5];
        }

        private bool check()
        {
            BUS.RoleBUS roleBUS = new BUS.RoleBUS();
            if (!roleBUS.IsRoleExisted(txtRole.Text))
            {
                MessageBox.Show(this, "The RoleID is invalid. Please checked it and try again!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int phone = int.Parse(txtPhone.Text);
            } catch (Exception ex)
            {
                MessageBox.Show(this, "Enter Number at Phone, please!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            bool result = false;
            if (txtUserID.Text == String.Empty)
            {
                MessageBox.Show(this, "UserID can't null!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserDTO user = new UserDTO
            {
                    
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Phone = int.Parse(txtPhone.Text),
                    RoleID = txtRole.Text,
                    UserID = txtUserID.Text,
                    UserName = txtUserName.Text
            };
            if (AddOrEdit == 0)
            {
                result = bus.AddNewUser(user);
                if (result)
                {
                    MessageBox.Show(this, "The New User is added successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "The New User is added fail. UserID is existed!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                result = bus.UpdateUser(user);
                if (result)
                {
                    MessageBox.Show(this, "The User is updated successful.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dr = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "The User is updated fail. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmChild_User_Load(object sender, EventArgs e)
        {
            if (AddOrEdit == 1)
            {
                txtUserID.Enabled = false;
            }
            else
            {
                txtUserID.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dr = DialogResult.Cancel;
            this.Close();
        }

        private void frmChild_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = dr;
        }
    }
}
