/* Autor: Misael da Costa Homem.
 * Ano: 2012
 * Cadeira: Linguagem de Programação I
 * Semestre: 3º
 * Turma: ADS3N12/2A
 * Docente: Lizandro Kirts da Silva.
 * Instituição: Faculdade Senac Porto Alegre - RS
 */

using System;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ControleTeatro
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.lblVersao.Text += " " + Application.ProductVersion;
            this.pbSplash.Controls.Add(this.lblVersao);

            // tenta conexão na base de dados.
            try
            {
                Dal.Conectar();
            }
            catch(OleDbException exept)
            {
                MessageBox.Show(null, "Erro ao conectar na base de dados.\n\nDetalhes: " + exept, "Falha na conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// Método para tratar o evento ao pressionar alguma tecla
        /// na caixa de texto Usuário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            // Se a tecla pressionada for ENTER
            if (e.KeyCode == Keys.Enter)
            {
                IniciarLogin();
            }
        }

        /// <summary>
        /// Método para tratar o evento ao pressionar alguma tecla
        /// na caixa de texto Senha.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            // Se a tecla pressionada for ENTER
            if (e.KeyCode == Keys.Enter)
            {
                IniciarLogin();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IniciarLogin();
        }

        /// <summary>
        /// Método que providencia o acesso ao usuário do sistema.
        /// </summary>
        private void IniciarLogin()
        {
            //Consistência dos campos
            // Se os campos são nulos ou vazios.
            if (String.IsNullOrEmpty(this.txtUsuario.Text) || String.IsNullOrEmpty(this.txtSenha.Text))
            {
                MessageBox.Show(null, "Informe os campos para o login.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Se campos são nulos ou espaço em branco.
            if (String.IsNullOrWhiteSpace(this.txtUsuario.Text) || String.IsNullOrWhiteSpace(this.txtSenha.Text))
            {
                MessageBox.Show(null, "Não são aceitos caracteres espaço em branco para os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            /* Antes de instarciar a classe SessãoUsuario deve ser
            * consultado o usuário e senha na base de dados.
            */
            string sql = String.Empty;

            sql = "SELECT";
            sql += " CD_USUARIO";
            sql += ", AN_SENHA";
            sql += ", CD_TIPO_USUARIO";
            sql += " FROM";
            sql += " USUARIO";
            sql += " WHERE";
            sql += " CD_USUARIO = '" + this.txtUsuario.Text + "'";

            Cripto cripto = new Cripto();
            string hash;

            using (MD5 md5Hash = MD5.Create())
            {
                hash = cripto.GetMd5Hash(md5Hash, this.txtSenha.Text);
            }

            sql += " AND AN_SENHA = '" + hash + "'";

            try
            {
                using (OleDbCommand comando = new OleDbCommand(sql, Dal.conn))
                {
                    // Se o houver uma linha de retorno (usuário e senha encontrado)
                    if (!(comando.ExecuteReader().HasRows))
                    {
                        MessageBox.Show(null, "Login inválido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        FormUtils.InicializarControles(this.Controls);
                        this.txtUsuario.Focus();
                        return;
                    }
                }

                string tipoUsuario = String.Empty;

                // Extrai valor da coluna CD_TIPO_USUARIO para o módulo de segurança
                using (OleDbCommand comando = new OleDbCommand(sql, Dal.conn))
                {
                    OleDbDataReader dr = comando.ExecuteReader();
                    dr.Read();
                    tipoUsuario = dr.GetValue(2).ToString();
                }

                /* Instancia a classe SessaoUsuario passando para o construtor
                * o usuário, tipo de usuário, data/hora de início de login e nada para
                * a data/hora de logout.*/
                Program.sessaoUsuario = new SessaoUsuario(
                    this.txtUsuario.Text.ToUpper()
                    , tipoUsuario
                    , DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")
                    , String.Empty);

                // DialogResult deste formulário recebe o valor OK.
                this.DialogResult = DialogResult.OK;

            }
            catch (OleDbException except)
            {
                MessageBox.Show(null, "Não foi possível executar a consulta para localizar o registro.\n\n"
                    + "Detalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
