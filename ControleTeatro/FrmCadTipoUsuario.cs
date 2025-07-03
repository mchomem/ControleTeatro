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
using System.Windows.Forms;

namespace ControleTeatro
{
    public partial class FrmCadTipoUsuario : Form
    {
        public FrmCadTipoUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadTipoUsuario_Load(object sender, EventArgs e)
        {
            FormUtils.CentralizaForm(this);
        }

        private void FrmCadTipoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipal.frmCadTipoUsuario = null;
        }

        private void tsbtnInicializar_Click(object sender, EventArgs e)
        {
            FormUtils.InicializaControles(this.Controls);
        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            // Faz a consistências dos campos NOT NULL
            // Se o valor dos campos é nulo ou vazio.
            if (String.IsNullOrEmpty(this.txtCodigoTipoUsuario.Text) || String.IsNullOrEmpty(this.txtDescTipoUsuario.Text))
            {
                MessageBox.Show(null, "Os campos requeridos devem ser informados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Se o valor dos campos é nulo ou espaço em branco.
            if (String.IsNullOrWhiteSpace(this.txtCodigoTipoUsuario.Text) || String.IsNullOrWhiteSpace(this.txtDescTipoUsuario.Text))
            {
                MessageBox.Show(null, "Não são aceitos caracteres espaço em branco para os campos requeridos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verifia se existe um caractere apóstrofo em todas as caixas de texto do formulário.
            if (FormUtils.VerificaCaracterProibido(this.Controls))
            {
                MessageBox.Show(null, "Não é permitido o uso de caracteres especiais ( ' | ) nos campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Antes de gravar o registro
            // Consulta se já existe a chave CD_USUARIO
            string sql = String.Empty;

            sql = "SELECT";
            sql += " CD_TIPO_USUARIO";
            sql += " FROM";
            sql += " TIPO_USUARIO";
            sql += " WHERE";
            sql += " CD_TIPO_USUARIO = '" + this.txtCodigoTipoUsuario.Text + "'";

            string operacao = String.Empty;
            string mensagem = String.Empty;

            try
            {
                using (OleDbCommand consulta = new OleDbCommand(sql, Dal.conn))
                {
                    // Se já existe o registro
                    if (consulta.ExecuteReader().HasRows)
                    {
                        operacao = "UPDATE"; // atualizar
                    }
                    // Se não existe
                    else
                    {
                        operacao = "INSERT"; // inserir
                    }
                }
            }
            catch (OleDbException except)
            {
                MessageBox.Show(null, "Não foi possível executar a consulta para localizar o registro.\n\n"
                    + "Detalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (operacao)
            {
                case "UPDATE":
                    sql = "UPDATE";
                    sql += " TIPO_USUARIO";
                    sql += " SET";
                    sql += " DS_TIPO_USUARIO = '" + this.txtDescTipoUsuario.Text + "'";
                    sql += " WHERE";
                    sql += " CD_TIPO_USUARIO = '" + this.txtCodigoTipoUsuario.Text + "'";

                    mensagem = "Registro alterado com sucesso.";

                    break;

                case "INSERT":
                    sql = "INSERT INTO";
                    sql += " TIPO_USUARIO";
                    sql += "(";
                    sql += "CD_TIPO_USUARIO";
                    sql += ", DS_TIPO_USUARIO";
                    sql += " )";
                    sql += " VALUES";
                    sql += "(";
                    sql += "'" + this.txtCodigoTipoUsuario.Text + "'";
                    sql += ", '" + this.txtDescTipoUsuario.Text + "'";
                    sql += ")";

                    mensagem = "Registro gravado com sucesso.";

                    break;
            }

            try
            {
                using (OleDbCommand comando = new OleDbCommand(sql, Dal.conn))
                {
                    comando.ExecuteNonQuery();
                    MessageBox.Show(null, mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    FormUtils.InicializaControles(this.Controls);
                }
            }
            catch (OleDbException except)
            {
                MessageBox.Show(null, "Não foi possível executar a operação de " + operacao + ".\n\n"
                    + "Detalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tsbtnExcluir_Click(object sender, EventArgs e)
        {
            // Consistências
            // Se pelo menos o campo da chave está informado.
            if (String.IsNullOrEmpty(this.txtCodigoTipoUsuario.Text))
            {
                MessageBox.Show(null, "Os campos requeridos devem ser informados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dr;
            dr = MessageBox.Show(null, "Deseja excluir este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.No || dr == DialogResult.None)
            {
                return;
            }

            // Antes de excluir o registro
            // Consulta se já existe a chave
            string sql = String.Empty;

            sql = "SELECT";
            sql += " CD_TIPO_USUARIO";
            sql += " FROM";
            sql += " TIPO_USUARIO";
            sql += " WHERE";
            sql += " CD_TIPO_USUARIO = '" + this.txtCodigoTipoUsuario.Text + "'";

            string operacao = String.Empty;
            string mensagem = String.Empty;

            try
            {
                using (OleDbCommand consulta = new OleDbCommand(sql, Dal.conn))
                {
                    // Se não existe o registro
                    if (!(consulta.ExecuteReader().HasRows))
                    {
                        MessageBox.Show(null, "Não existe a chave informada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        FormUtils.InicializaControles(this.Controls);
                        return;
                    }
                }
            }
            catch (OleDbException except)
            {
                MessageBox.Show(null, "Não foi possível executar a consulta para localizar o registro.\n\n"
                    + "Detalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Exclui o registro.
            sql = "DELETE";
            sql += " FROM";
            sql += " TIPO_USUARIO";
            sql += " WHERE";
            sql += " CD_TIPO_USUARIO = '" + this.txtCodigoTipoUsuario.Text + "'";

            try
            {
                using (OleDbCommand exclusao = new OleDbCommand(sql, Dal.conn))
                {
                    exclusao.ExecuteNonQuery();
                    MessageBox.Show(null, "Registro excluido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    FormUtils.InicializaControles(this.Controls);
                }
            }
            catch (OleDbException except)
            {
                MessageBox.Show(null, "Não foi possível executar a exclusão do registro.\n\n"
                    + "Detalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tsbtnListarRegistros_Click(object sender, EventArgs e)
        {
            string sql = String.Empty;

            sql += "SELECT";
            sql += " CD_TIPO_USUARIO AS [Código]";
            sql += ", DS_TIPO_USUARIO AS [Decrição]";
            sql += " FROM";
            sql += " TIPO_USUARIO";
            sql += " ORDER BY";
            sql += " CD_TIPO_USUARIO";
            
            if (FrmPrincipal.frmListaRegistros == null)
            {
                // Instancia a classe FrmListaRegistros passando o comando sql e o título
                // do formulário de Lista de Registros.
                FrmPrincipal.frmListaRegistros = new FrmListaRegistros(sql, "Tipos de Usuários");
                FrmPrincipal.frmListaRegistros.ShowDialog();
            }

            //Se o valor de retorno do formulário Lista Registros não é nulo ou vazio.
            if (!(String.IsNullOrEmpty(FrmListaRegistros.RetValores)))
            {
                string[] dados = FrmListaRegistros.RetValores.Split(Convert.ToChar("|"));
                this.txtCodigoTipoUsuario.Text = dados[0];
                this.txtDescTipoUsuario.Text = dados[1];

                // Inicializa o valor de retorno do formulário Lista Registros.
                FrmListaRegistros.RetValores = String.Empty;
            }
        }
    }
}
