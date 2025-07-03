using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControleTeatro
{
    public partial class FrmSobre : Form
    {
        public FrmSobre()
        {
            InitializeComponent();
        }

        private void FrmSobre_Load(object sender, EventArgs e)
        {
            FormUtils.CentralizaForm(this);
            this.lblVersaoProduto.Text +=  " " + Application.ProductVersion;
        }

        private void FrmSobre_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipal.frmSobre = null;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
