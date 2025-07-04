using System;
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
            FormUtils.CentralizarForm(this);
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
