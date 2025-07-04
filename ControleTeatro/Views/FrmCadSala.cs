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
using ControleTeatro.Helpers;

namespace ControleTeatro.Views
{
    public partial class FrmCadSala : Form
    {
        public FrmCadSala()
        {
            InitializeComponent();
        }

        private void FrmCadSala_Load(object sender, EventArgs e)
        {
            // Centraliza este formulário.
            FormHelper.CentralizarForm(this);
        }

        private void FrmCadSala_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipal.frmCadSala = null;
        }

        private void tsbtnInicializar_Click(object sender, EventArgs e)
        {
            FormHelper.InicializarControles(this.Controls);
        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            // Faz a consistências dos campos NOT NULL
            // Se o valor dos campos é nulo ou vazio.
            if(String.IsNullOrEmpty(this.txtCodigoSala.Text) || String.IsNullOrEmpty(this.txtDescricaoSala.Text) || String.IsNullOrEmpty(this.txtQtMaxAssento.Text))
            {
                MessageBox.Show(null, "Os campos requeridos devem ser informados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Se o valor dos campos é nulo ou espaço em branco.
            if (String.IsNullOrWhiteSpace(this.txtCodigoSala.Text) || String.IsNullOrWhiteSpace(this.txtDescricaoSala.Text) || String.IsNullOrWhiteSpace(this.txtQtMaxAssento.Text))
            {
                MessageBox.Show(null, "Não são aceitos caracteres espaço em branco para os campos requeridos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verifia se existe um caractere apóstrofo em todas as caixas de texto do formulário.
            if (FormHelper.VerificarCaracterProibido(this.Controls))
            {
                MessageBox.Show(null, "Não é permitido o uso de caracteres especiais ( ' | ) nos campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Antes de gravar o registro
            // Consulta se já existe a chave CD_SALA
            string sql = String.Empty;

            sql = "SELECT";
            sql += " CD_SALA";
            sql += " FROM";
            sql += " SALA";
            sql += " WHERE";
            sql += " CD_SALA = '" + this.txtCodigoSala.Text + "'";

            // Variável para tratar a opereção escolhida (UPDATE ou INSERT);
            string operacao = String.Empty;
            // Variável para tratar a mensagem após a operação executada.
            string mensagem = String.Empty;

            try
            {
                using (OleDbCommand consulta = new OleDbCommand(sql, Dal.conn))
                {
                    // Se já existe o registro na base de dados.
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
                    sql += " SALA";
                    sql += " SET";
                    sql += " DS_SALA = '" + this.txtDescricaoSala.Text + "'";
                    sql += ", QT_MAX_ASSENTO = '" + this.txtQtMaxAssento.Text + "'";

                    if (this.cbManutencao.Checked)
                    {
                        sql += ", FL_MANUTENCAO = 'Sim'";
                    }
                    else
                    {
                        sql += ", FL_MANUTENCAO = 'Não'";
                    }
                    
                    sql += ", AN_OBS = '" + this.txtOBS.Text + "'";
                    sql += " WHERE";
                    sql += " CD_SALA = '" + this.txtCodigoSala.Text + "'";

                    mensagem = "Registro alterado com sucesso.";

                    break;

                case "INSERT":
                    sql = "INSERT INTO";
                    sql += " SALA";
                    sql += "(";
                    sql += "CD_SALA";
                    sql += ", DS_SALA";
                    sql += ", QT_MAX_ASSENTO";
                    sql += ", FL_MANUTENCAO";
                    sql += ", AN_OBS";
                    sql += " )";
                    sql += " VALUES";
                    sql += "(";
                    sql += "'" + this.txtCodigoSala.Text + "'";
                    sql += ", '" + this.txtDescricaoSala.Text + "'";
                    sql += ", '" + this.txtQtMaxAssento.Text + "'";

                    if (this.cbManutencao.Checked)
                    {
                        sql += ", 'Sim'";
                    }
                    else
                    {
                        sql += ", 'Não'";
                    }

                    sql += ", '" + this.txtOBS.Text + "'";
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
                    FormHelper.InicializarControles(this.Controls);
                }
            }
            catch (OleDbException except)
            {
                MessageBox.Show(null, "Não foi possível executar a operação de " + operacao + ".\n\n"
                    + "Detalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tsbtnListarRegistros_Click(object sender, EventArgs e)
        {
            string sql = String.Empty;

            sql += "SELECT";
            sql += " CD_SALA AS [Código]";
            sql += ", DS_SALA AS [Descrição]";
            sql += ", QT_MAX_ASSENTO AS [Quantidade de Assentos]";
            sql += ", FL_MANUTENCAO AS [Em Manutenção?]";
            sql += ", AN_OBS AS [Observações]";
            sql += " FROM";
            sql += " SALA";
            sql += " ORDER BY";
            sql += " CD_SALA";

            if (FrmPrincipal.frmListaRegistros == null)
            {
                FrmPrincipal.frmListaRegistros = new FrmListaRegistros(sql, "Salas");
                FrmPrincipal.frmListaRegistros.ShowDialog();
            }

            if (!(String.IsNullOrEmpty(FrmListaRegistros.RetValores)))
            {
                string[] dados = FrmListaRegistros.RetValores.Split(Convert.ToChar("|"));
                this.txtCodigoSala.Text = dados[0];
                this.txtDescricaoSala.Text = dados[1];
                this.txtQtMaxAssento.Text = dados[2];

                if (dados[3] == "Sim")
                {
                    this.cbManutencao.Checked = true;
                }
                else
                {
                    this.cbManutencao.Checked = false;
                }

                this.txtOBS.Text = dados[4];

                FrmListaRegistros.RetValores = String.Empty;
            }
        }

        private void tsbtnExcluir_Click(object sender, EventArgs e)
        {
            // Consistência
            // Se pelo menos o campo da chave está informado.
            if (String.IsNullOrEmpty(this.txtCodigoSala.Text))
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
            sql += " CD_SALA";
            sql += " FROM";
            sql += " SALA";
            sql += " WHERE";
            sql += " CD_SALA = '" + this.txtCodigoSala.Text + "'";

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
                        FormHelper.InicializarControles(this.Controls);
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
            sql += " SALA";
            sql += " WHERE";
            sql += " CD_SALA = '" + this.txtCodigoSala.Text + "'";

            try
            {
                using (OleDbCommand exclusao = new OleDbCommand(sql, Dal.conn))
                {
                    exclusao.ExecuteNonQuery();
                    MessageBox.Show(null, "Registro excluido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    FormHelper.InicializarControles(this.Controls);
                }
            }
            catch (OleDbException except)
            {
                MessageBox.Show(null, "Não foi possível executar a exclusão do registro.\n\n"
                    + "Detalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void lblObs_Click(object sender, EventArgs e)
        {

        }
    }
}
