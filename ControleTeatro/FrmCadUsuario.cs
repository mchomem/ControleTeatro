/* Autor: Misael da Costa Homem.
 * Ano: 2012
 * Cadeira: Linguagem de Programação I
 * Semestre: 3º
 * Turma: ADS3N12/2A
 * Docente: Lizandro Kirts da Silva.
 * Instituição: Faculdade Senac Porto Alegre - RS
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace ControleTeatro
{
    public partial class FrmCadUsuario : Form
    {
        public FrmCadUsuario()
        {
            InitializeComponent();
        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {
            // Centraliza este formulário.
            FormUtils.CentralizaForm(this);
        }

        private void FrmCadUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipal.frmCadUsuario = null;
        }

        private void tsbtnInicializar_Click(object sender, EventArgs e)
        {
            FormUtils.InicializaControles(this.Controls);
        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            // Faz a consistências dos campos NOT NULL
            // Se o valor dos campos é nulo ou vazio.
            if(String.IsNullOrEmpty(this.txtUsuario.Text) || String.IsNullOrEmpty(this.txtNomeFuncionario.Text) || String.IsNullOrEmpty(this.txtSenha.Text) || String.IsNullOrEmpty(this.txtConfSenha.Text))
            {
                MessageBox.Show(null, "Os campos requeridos devem ser informados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Se o valor dos campos é nulo ou espaço em branco.
            if (String.IsNullOrWhiteSpace(this.txtUsuario.Text) || String.IsNullOrWhiteSpace(this.txtNomeFuncionario.Text) || String.IsNullOrWhiteSpace(this.txtSenha.Text) || String.IsNullOrWhiteSpace(this.txtConfSenha.Text))
            {
                MessageBox.Show(null, "Não são aceitos caracteres espaço em branco para os campos requeridos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Se a senha a ser gravada for diferente da confirmação de senha.
            if(this.txtSenha.Text != this.txtConfSenha.Text)
            {
                MessageBox.Show(null, "A nova senha não confere com a senha de confirmação.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            sql += " CD_USUARIO";
            sql += " FROM";
            sql += " USUARIO";
            sql += " WHERE";
            sql += " CD_USUARIO = '" + this.txtUsuario.Text + "'";

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
            catch(OleDbException except)
            {
                MessageBox.Show(null, "Não foi possível executar a consulta para localizar o registro.\n\n"
                    + "Detalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Encripta a senha do usuário
            Cripto cripto = new Cripto();
            string hash;

            using (MD5 md5Hash = MD5.Create())
            {
                hash = cripto.GetMd5Hash(md5Hash, this.txtSenha.Text);
            }

            switch(operacao)
            {

                case "UPDATE":
                    sql = "UPDATE";
                    sql += " USUARIO";
                    sql += " SET";
                    sql += " NM_FUNCIONARIO = '" + this.txtNomeFuncionario.Text + "'";
                    sql += ", AN_SENHA = '" + hash + "'";
                    //sql += ", AN_SENHA = '" +  this.txtSenha.Text + "'";
                    sql += ", CD_TIPO_USUARIO = '" + this.txtTipoUsuario.Text + "'";
                    sql += " WHERE";
                    sql += " CD_USUARIO = '" + this.txtUsuario.Text + "'";

                    mensagem = "Registro alterado com sucesso.";

                    break;
                
                case "INSERT":
                    sql = "INSERT INTO";
                    sql += " USUARIO";
                    sql += "(";
                    sql += "CD_USUARIO";
                    sql += ", NM_FUNCIONARIO";
                    sql += ", AN_SENHA";
                    sql += ", DTHR_INCLUSAO";
                    sql += ",CD_TIPO_USUARIO";
                    sql += " )";
                    sql += " VALUES";
                    sql += "(";
                    sql += "'" + this.txtUsuario.Text + "'";
                    sql += ", '" + this.txtNomeFuncionario.Text + "'";
                    sql += ", '" + hash + "'";
                    //sql += ", '" + this.txtSenha.Text + "'";
                    sql += ", '" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + "'";
                    sql += ", '" + this.txtTipoUsuario.Text + "'";
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
            if (String.IsNullOrEmpty(this.txtUsuario.Text))
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

            // Se o usuário a ser excluído é o mesmo da sessão que está logado no sistema
            if (this.txtUsuario.Text == Program.sessaoUsuario.Nome)
            {
                MessageBox.Show(null, "O usuário: " + this.txtUsuario.Text + " está logado no momento."
                    + "\n Não é possível excluir usuários que estão logado no sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FormUtils.InicializaControles(this.Controls);
                return;
            }

            // Antes de excluir o registro
            // Consulta se já existe a chave
            string sql = String.Empty;

            sql = "SELECT";
            sql += " CD_USUARIO";
            sql += " FROM";
            sql += " USUARIO";
            sql += " WHERE";
            sql += " CD_USUARIO = '" + this.txtUsuario.Text + "'";

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
            sql += " USUARIO";
            sql += " WHERE";
            sql += " CD_USUARIO = '" + this.txtUsuario.Text + "'";

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
            sql += " CD_USUARIO AS [Código]";
            sql += ", NM_FUNCIONARIO AS [Funcionário]";
            sql += ", DTHR_INCLUSAO AS [Data/Hora Inclusão]";
            sql += ", DTHR_ULT_ACESSO AS [Data/Hora Último Acesso]";
            sql += ", CD_TIPO_USUARIO AS [Tipo de Usuário]";
            sql += " FROM";
            sql += " USUARIO";
            sql += " ORDER BY";
            sql += " CD_USUARIO";
            
            if (FrmPrincipal.frmListaRegistros == null)
            {
                // Instancia a classe FrmListaRegistros passando o comando sql e o título
                // do formulário de Lista de Registros.
                FrmPrincipal.frmListaRegistros = new FrmListaRegistros(sql, "Usuários");
                FrmPrincipal.frmListaRegistros.ShowDialog();
            }

            //Se o valor de retorno do formulário Lista Registros não é nulo ou vazio.
            if (!(String.IsNullOrEmpty(FrmListaRegistros.RetValores)))
            {
                string[] dados = FrmListaRegistros.RetValores.Split(Convert.ToChar("|"));
                this.txtUsuario.Text = dados[0];
                this.txtNomeFuncionario.Text = dados[1];
                this.txtDtHrInclusao.Text = dados[2];
                this.txtDtHrUltAcesso.Text = dados[3];
                this.txtTipoUsuario.Text = dados[4];

                // Inicializa o valor de retorno do formulário Lista Registros.
                FrmListaRegistros.RetValores = String.Empty;
            }
        }

        private void btListaRegistroExterna_Click(object sender, EventArgs e)
        {
            string sql = String.Empty;

            sql += "SELECT";
            sql += " CD_TIPO_USUARIO AS [Código]";
            sql += ", DS_TIPO_USUARIO AS [Descrição]";
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
                this.txtTipoUsuario.Text = dados[0];

                // Inicializa o valor de retorno do formulário Lista Registros.
                FrmListaRegistros.RetValores = String.Empty;
            }
        }
    }
}
