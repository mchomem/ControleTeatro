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
    public partial class FrmCadSessao : Form
    {
        public FrmCadSessao()
        {
            InitializeComponent();
        }

        private void FrmCadSessao_Load(object sender, EventArgs e)
        {
            FormUtils.CentralizaForm(this);
        }

        private void FrmCadSessao_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipal.frmCadSessao = null;
        }

        private void tsbtnInicializar_Click(object sender, EventArgs e)
        {
            FormUtils.InicializaControles(this.Controls);
        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            // Faz a consistências dos campos NOT NULL
            // Se o valor dos campos é nulo ou vazio.
            //if (String.IsNullOrEmpty(this.mtbDataSessao.Text) || String.IsNullOrEmpty(this.mtbHoraInicio.Text) || String.IsNullOrEmpty(this.txtCodigoSala.Text))
            //{
            //    MessageBox.Show(null, "Os campos requeridos devem ser informados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            // Misael - 06/11/2012 - 11:06 --------------------------------------------------------------------------------------------------------------
            // Faz a consistências dos campos NOT NULL
            // Validar se os campos com máscara de data ou com máscara de hora estão vazios ou também se o campo de código de sala é vazio ou nulo.
            if (this.mtbDataSessao.Text == "  /  /" || this.mtbHoraInicio.Text == "  :" || String.IsNullOrEmpty(this.txtCodigoSala.Text))
            {
                MessageBox.Show(null, "Os campos requeridos devem ser informados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar se o campo de data é válido.
            DateTime resuldado = DateTime.MinValue;

            if(DateTime.TryParse(this.mtbDataSessao.Text, out resuldado) == false)
            {
                MessageBox.Show(null, "A data informada é inválida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.mtbDataSessao.Focus();
                return;
            }

            // Validar se o campo de hora é válido
            if (DateTime.TryParse(this.mtbHoraInicio.Text, out resuldado) == false)
            {
                MessageBox.Show(null, "A hora informada é inválida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.mtbHoraInicio.Focus();
                return;
            }
            // ------------------------------------------------------------------------------------------------------------------------------------------


            // Se o valor dos campos é nulo ou espaço em branco.
            if (String.IsNullOrWhiteSpace(this.mtbDataSessao.Text) || String.IsNullOrWhiteSpace(this.mtbHoraInicio.Text) || String.IsNullOrWhiteSpace(this.txtCodigoSala.Text))
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
            sql += " DT_SESSAO";
            sql += " FROM";
            sql += " SESSAO";
            sql += " WHERE";
            sql += " DT_SESSAO = " + DateTime.Parse(this.mtbDataSessao.Text).ToString("yyyyMMdd");
            sql += " AND HR_SESSAO = '" + DateTime.Parse(this.mtbHoraInicio.Text).ToString("HHmm") + "'";
            sql += " AND CD_SALA = '" + this.txtCodigoSala.Text + "'";

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

                    mensagem = "Registro não pode ser alterado.";

                    MessageBox.Show(null, mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    FormUtils.InicializaControles(this.Controls);
                    return;
                    //break;

                case "INSERT":
                    sql = "INSERT INTO";
                    sql += " SESSAO";
                    sql += "(";
                    sql += "DT_SESSAO";
                    sql += ", HR_SESSAO";
                    sql += ", CD_SALA";
                    sql += ", QT_DISP_ASSENTOS";
                    sql += " )";
                    sql += " VALUES";
                    sql += "(";
                    sql += "" + DateTime.Parse(this.mtbDataSessao.Text).ToString("yyyyMMdd");
                    //sql += ", '" + DateTime.Parse(this.mtbHoraInicio.Text).Hour + DateTime.Parse(this.mtbHoraInicio.Text).Minute + "'"; // se for usar com campo númerico no access [ERRADO].
                    sql += ", '" + DateTime.Parse(this.mtbHoraInicio.Text).ToString("HHmm") + "'";
                    sql += ", '" + this.txtCodigoSala.Text + "'";
                    sql += ", " + this.txtQtDispAssento.Text;
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
            if (String.IsNullOrEmpty(this.mtbDataSessao.Text) || String.IsNullOrEmpty(this.mtbHoraInicio.Text) || String.IsNullOrEmpty(this.txtCodigoSala.Text))
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
            sql += " DT_SESSAO";
            sql += " FROM";
            sql += " SESSAO";
            sql += " WHERE";
            sql += " DT_SESSAO = " + DateTime.Parse(this.mtbDataSessao.Text).ToString("yyyyMMdd");
            // sql += " AND HR_SESSAO = " + DateTime.Parse(this.mtbHoraInicio.Text).Hour + DateTime.Parse(this.mtbHoraInicio.Text).Minute;  // se for usar com campo númerico no access [ERRADO].
            sql += " AND HR_SESSAO = '" + DateTime.Parse(this.mtbHoraInicio.Text).ToString("HHmm") + "'";
            sql += " AND CD_SALA = '" + this.txtCodigoSala.Text + "'";

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
            sql += " SESSAO";
            sql += " WHERE";
            sql += " DT_SESSAO = " + DateTime.Parse(this.mtbDataSessao.Text).ToString("yyyyMMdd");
            // sql += " AND HR_SESSAO = " + DateTime.Parse(this.mtbHoraInicio.Text).Hour + DateTime.Parse(this.mtbHoraInicio.Text).Minute;  // se for usar com campo númerico no access [ERRADO].
            sql += " AND HR_SESSAO = '" + DateTime.Parse(this.mtbHoraInicio.Text).ToString("HHmm") + "'";
            sql += " AND CD_SALA = '" + this.txtCodigoSala.Text + "'";

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

            sql = "SELECT";
            // O Código abaixo é para ao executar o sql no Access, formatar a data e a hora no grid para apresentação.
            sql += " cvdate(mid(trim(str(DT_SESSAO)) , 7, 2) + \"/\" + mid(trim(str(DT_SESSAO)), 5, 2) + \"/\" + mid(trim(str(DT_SESSAO)), 1, 4)) AS [Data Sessão]";
            //sql += " , mid(str(HR_SESSAO), 1, 3) + \":\" + mid(str(HR_SESSAO), 4, 2) AS [Hora Incial]"; // se for usar com campo númerico no access [ERRADO].
            sql += " , mid(HR_SESSAO, 1, 2) + \":\" + mid(HR_SESSAO, 3, 2) AS [Hora Incial]";
            sql += ", CD_SALA AS [Sala]";
            sql += ", QT_DISP_ASSENTOS AS [Assentos Disponíveis]";
            sql += " FROM";
            sql += " SESSAO";
            sql += " ORDER BY";
            sql += " DT_SESSAO";
            sql += " , HR_SESSAO";
            sql += " , CD_SALA";

            if (FrmPrincipal.frmListaRegistros == null)
            {
                // Instancia a classe FrmListaRegistros passando o comando sql e o título
                // do formulário de Lista de Registros.
                FrmPrincipal.frmListaRegistros = new FrmListaRegistros(sql, "Sessões");
                FrmPrincipal.frmListaRegistros.ShowDialog();
            }

            //Se o valor de retorno do formulário Lista Registros não é nulo ou vazio.
            if (!(String.IsNullOrEmpty(FrmListaRegistros.RetValores)))
            {
                string[] dados = FrmListaRegistros.RetValores.Split(Convert.ToChar("|"));
                this.mtbDataSessao.Text = dados[0];
                // Como os campos inteiros do Access que representam as datas já estão vindo formatados do sql.
                // não é mais necessário formatá-los (comandos comentados abaixo)
                //this.mtbEstreia.Text = DateTime.ParseExact(dados[1], "yyyyMMdd", null).ToString("ddMMyyyy");
                //this.mtbTermino.Text = DateTime.ParseExact(dados[2],"yyyyMMdd", null).ToString("ddMMyyyy");
                //this.mtbHoraInicio.Text = TimeSpan.Parse(dados[1]).ToString("HHmm");
                this.mtbHoraInicio.Text = DateTime.Parse(dados[1]).ToString("HHmm");
                this.txtCodigoSala.Text = dados[2];
                this.txtQtDispAssento.Text = dados[3];

                // Inicializa o valor de retorno do formulário Lista Registros.
                FrmListaRegistros.RetValores = String.Empty;
            }
        }

        private void btListaRegistroExternaSala_Click(object sender, EventArgs e)
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

            // OBS -------------------------------------------
            // Para vincular uma sala para uma sessão neste
            // cadastro, a sala não pode estar em manuntenção.
            sql += " WHERE";
            sql += " FL_MANUTENCAO <> 'Sim'";
            // -----------------------------------------------

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
                this.txtQtDispAssento.Text = dados[2];

                FrmListaRegistros.RetValores = String.Empty;
            }
        }
    }
}
