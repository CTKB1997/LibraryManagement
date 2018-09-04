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
    public partial class Form1 : Form
    {
        private void InitializeMyControl()
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }
        public Form1()
        {
            InitializeComponent();
            InitializeMyControl();
            this.AcceptButton = btnLogin;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BUS.UserBUS Bus = new BUS.UserBUS();
            int role = Bus.CheckLogin(txtUsername.Text, txtPassword.Text);
            if (role == -1)
            {
                MessageBox.Show("Error. Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                //Console.WriteLine(role);
                Form form = new frmRole_User(txtUsername.Text, role);
                switch (role)
                {
                    case 2: form = new frmRole_Staff(txtUsername.Text, role); break;
                    case 3: form = new frmRole_Manager(txtUsername.Text, role); break;
                }
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
