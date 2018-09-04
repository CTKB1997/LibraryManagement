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
    public partial class frmFunc_AdvanceSearch : Form
    {
        private DialogResult dr = DialogResult.Cancel;
        public string bookTitle { get; set; }
        public string authorName { get; set; }
        public string categoryName { get; set; }

        public frmFunc_AdvanceSearch()
        {
            InitializeComponent();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dr = DialogResult.OK;
            bookTitle = txtBookTitle.Text;
            authorName = txtAuthor.Text;
            categoryName = txtCategoryName.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFunc_AdvanceSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = dr;
        }
    }
}
