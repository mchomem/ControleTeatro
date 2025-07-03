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
    public partial class FrmAlterarSenha : Form
    {
        public FrmAlterarSenha()
        {
            InitializeComponent();
        }

        private void FrmAlterarSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipal.frmAlterarSenha = null;
        }

        private void FrmAlterarSenha_Load(object sender, EventArgs e)
        {
            // Obtém da variável de sessão o nome do usuário logado.
            this.lblUsuario.Text = Program.sessaoUsuario.Nome;

            // Centraliza este formulário.
            FormUtils.CentralizaForm(this);
        }

        private void tsbtnInicializar_Click(object sender, EventArgs e)
        {
            FormUtils.InicializaControles(this.Controls);
        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            // Consistências de dados
            //-----------------------

            // Se os campos são nulos ou vazios.
            if (String.IsNullOrEmpty(this.txtSenhaAtual.Text) || String.IsNullOrEmpty(this.txtNovaSenha.Text) || String.IsNullOrEmpty(this.txtConfirmaSenha.Text))
            {
                MessageBox.Show(null, "Campos devem ser informados para a gravação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Se os campos são nulos ou espaço em branco.
            if (String.IsNullOrWhiteSpace(this.txtSenhaAtual.Text) && String.IsNullOrWhiteSpace(this.txtNovaSenha.Text) && String.IsNullOrWhiteSpace(this.txtConfirmaSenha.Text))
            {
                MessageBox.Show(null, "Não são aceitos caracteres espaço em branco para os campos de senhas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verifia se existe um caractere apóstrofo em todas as caixas de texto do formulário.
            if (FormUtils.VerificaCaracterProibido(this.Controls))
            {
                MessageBox.Show(null, "Não é permitido o uso de caracteres especiais ( ' / ) nos campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Declação do tipo Cripto para tratar a encriptação de senha.
            Cripto cripto = new Cripto();
            // Variáveis para receber o código hash da encriptação.
            string hashAtual, hashNovo;

            // Encriptando o valor da senha atual informada pelo usuário.
            using (MD5 md5Hash = MD5.Create())
            {
                hashAtual = cripto.GetMd5Hash(md5Hash, this.txtSenhaAtual.Text);
            }

            // Compara a senha informada com a existente na base.
            string sql = String.Empty;

            sql = "SELECT";
            sql += " CD_USUARIO";
            sql += " FROM";
            sql += " USUARIO";
            sql += " WHERE ";
            sql += " CD_USUARIO = '" + Program.sessaoUsuario.Nome + "'";
            sql += " AND AN_SENHA = '" + hashAtual + "'";

            using (OleDbCommand consulta = new OleDbCommand(sql, Dal.conn))
            {
                if (consulta.ExecuteReader().HasRows == false)
                {
                    MessageBox.Show(null, "A senha atual informada está incorreta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            // Se a nova senha é diferente da senha de confirmação
            if (this.txtNovaSenha.Text != this.txtConfirmaSenha.Text)
            {
                MessageBox.Show(null, "A nova senha não confere com a senha de confirmação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Encriptando a nova senha informado pelo usuário.
            using (MD5 md5Hash = MD5.Create())
            {
                hashNovo = cripto.GetMd5Hash(md5Hash, this.txtNovaSenha.Text);
            }

            // Altera a senha do usuário na base de dados.
            sql = "UPDATE";
            sql += " USUARIO";
            sql += " SET";
            sql += " AN_SENHA = '" + hashNovo + "'";
            sql += " WHERE";
            sql += " CD_USUARIO = '" + Program.sessaoUsuario.Nome + "'";

            using (OleDbCommand comando = new OleDbCommand(sql, Dal.conn))
            {
                comando.ExecuteNonQuery();
                MessageBox.Show(null, "A nova senha foi definida com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
