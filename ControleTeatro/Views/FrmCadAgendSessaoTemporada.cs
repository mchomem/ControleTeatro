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
using System.Linq;
using System.Windows.Forms;
using ControleTeatro.Helpers;

namespace ControleTeatro.Views
{
    public partial class FrmCadAgendSessaoTemporada : Form
    {
        public FrmCadAgendSessaoTemporada()
        {
            InitializeComponent();
        }

        private void FrmCadAgendSessaoTemporada_Load(object sender, EventArgs e)
        {
            FormHelper.CentralizarForm(this);
        }

        private void FrmCadAgendTemporadaSessao_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipal.frmCadAgendSessaoTemporada = null;
        }

        private void tsbtnInicializar_Click(object sender, EventArgs e)
        {
            FormHelper.InicializarControles(this.Controls);
            this.lblNomePeca.Text = String.Empty;
        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            // Faz a consistências dos campos NOT NULL
            // Se o valor dos campos é nulo ou vazio.
            if (String.IsNullOrEmpty(this.mtbDataSessao.Text) || String.IsNullOrEmpty(this.mtbHoraInicio.Text) || String.IsNullOrEmpty(this.txtCodigoSala.Text) || String.IsNullOrEmpty(this.txtTemporadaPeca.Text))
            {
                MessageBox.Show(null, "Os campos requeridos devem ser informados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Se o valor dos campos é nulo ou espaço em branco.
            if (String.IsNullOrWhiteSpace(this.mtbDataSessao.Text) || String.IsNullOrWhiteSpace(this.mtbHoraInicio.Text) || String.IsNullOrWhiteSpace(this.txtCodigoSala.Text) || String.IsNullOrWhiteSpace(this.txtTemporadaPeca.Text))
            {
                MessageBox.Show(null, "Não são aceitos caracteres espaço em branco para os campos requeridos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Se a data de Sessão estiver fora da temporada informada.
            if ((Convert.ToDateTime(this.mtbDataSessao.Text) < Convert.ToDateTime(this.mtbEstreia.Text)) || (Convert.ToDateTime(this.mtbDataSessao.Text) > Convert.ToDateTime(this.mtbTermino.Text)))
            {
                MessageBox.Show(null, "A data de Sessão está fora da Temporada informada para a peça: " + this.txtTemporadaPeca.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verifia se existe um caractere apóstrofo em todas as caixas de texto do formulário.
            if (FormHelper.VerificarCaracterProibido(this.Controls))
            {
                MessageBox.Show(null, "Não é permitido o uso de caracteres especiais ( ' | ) nos campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Antes de gravar o registro
            // Consulta se já existe a chave
            string sql = String.Empty;

            sql = "SELECT";
            sql += " DT_SESSAO";
            sql += " FROM";
            sql += " SESSAO_TEMPORADA";
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

                    // Antes de atualizar, verifica se a peça já está disponível
                    // para exbição (Disponivel para Venda).
                    sql = "SELECT";
                    sql += " DT_SESSAO";
                    sql += " FROM";
                    sql += " SESSAO_TEMPORADA";
                    sql += " WHERE";
                    sql += " DT_SESSAO = " + DateTime.Parse(this.mtbDataSessao.Text).ToString("yyyyMMdd");
                    sql += " AND HR_SESSAO = '" + DateTime.Parse(this.mtbHoraInicio.Text).ToString("HHmm") + "'";
                    sql += " AND CD_SALA = '" + this.txtCodigoSala.Text + "'";
                    sql += " AND CD_PECA = '" + this.txtTemporadaPeca.Text + "'";
                    sql += " AND FL_CONF_EXIB = 'Sim'";

                    try
                    {
                        using (OleDbCommand consulta = new OleDbCommand(sql, Dal.conn))
                        {
                            // Se existe o registro
                            if (consulta.ExecuteReader().HasRows)
                            {
                                MessageBox.Show(null, "Esta Sessão para a peça: "
                                    + this.txtTemporadaPeca.Text + " não pode ser atualizada\n"
                                    + "por que já está disponível para exibição  (disponível para venda).\n"
                                    , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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


                    // Executa o UPDATE normal se o registro não está disponível para exibição (disponível para venda)
                    sql = " UPDATE";
                    sql += " SESSAO_TEMPORADA";
                    sql += " SET";
                    sql += " DT_SESSAO = " + DateTime.Parse(this.mtbDataSessao.Text).ToString("yyyyMMdd");
                    //sql += " , HR_SESSAO = " + DateTime.Parse(this.mtbHoraInicio.Text).Hour + DateTime.Parse(this.mtbHoraInicio.Text).Minute;
                    sql += " , HR_SESSAO = '" + DateTime.Parse(this.mtbHoraInicio.Text).ToString("HHmm") + "'";
                    sql += " , CD_SALA = '" +  this.txtCodigoSala.Text + "'";
                    sql += " , QT_DISP_ASSENTOS = " + this.txtQtDispAssento.Text;
                    sql += " , CD_PECA = '" + this.txtTemporadaPeca.Text + "'";
                    sql += " , DT_ESTREIA = " + DateTime.Parse(this.mtbEstreia.Text).ToString("yyyyMMdd");
                    sql += " , DT_TERMINO = " + DateTime.Parse(this.mtbTermino.Text).ToString("yyyyMMdd");

                    if (this.chbConfExibicao.Checked)
                    {
                        sql += ", FL_CONF_EXIB = 'Sim'";
                    }
                    else
                    {
                        sql += ", FL_CONF_EXIB =  'Não'";
                    }

                    sql += " , VL_BILHETE = '"  + this.txtVlBilhete.Text + "'";
                    sql += " WHERE";
                    sql += " DT_SESSAO = " + DateTime.Parse(this.mtbDataSessao.Text).ToString("yyyyMMdd");
                    // sql += " AND HR_SESSAO = " + DateTime.Parse(this.mtbHoraInicio.Text).Hour + DateTime.Parse(this.mtbHoraInicio.Text).Minute ;
                    sql += " AND HR_SESSAO = '" + DateTime.Parse(this.mtbHoraInicio.Text).ToString("HHmm") + "'";
                    sql += " AND CD_SALA = '" + this.txtCodigoSala.Text + "'";

                    mensagem = "Registro alterado com sucesso.";
                    
                    break;

                case "INSERT":
                    sql = "INSERT INTO";
                    sql += " SESSAO_TEMPORADA";
                    sql += "(";
                    sql += "DT_SESSAO";
                    sql += ", HR_SESSAO";
                    sql += ", CD_SALA";
                    sql += ", QT_DISP_ASSENTOS";
                    sql += ", CD_PECA";
                    sql += ", DT_ESTREIA";
                    sql += ", DT_TERMINO";
                    sql += ", FL_CONF_EXIB";
                    sql += ", VL_BILHETE";
                    sql += " )";
                    sql += " VALUES";
                    sql += "(";
                    sql += "" + DateTime.Parse(this.mtbDataSessao.Text).ToString("yyyyMMdd");
                    //sql += ", " + DateTime.Parse(this.mtbHoraInicio.Text).Hour + DateTime.Parse(this.mtbHoraInicio.Text).Minute;
                    sql += ", '" + DateTime.Parse(this.mtbHoraInicio.Text).ToString("HHmm") + "'";
                    sql += ", '" + this.txtCodigoSala.Text + "'";
                    sql += ", '" + this.txtQtDispAssento.Text + "'";
                    sql += ", '" + this.txtTemporadaPeca.Text + "'";
                    sql += ", " + DateTime.Parse(this.mtbEstreia.Text).ToString("yyyyMMdd");
                    sql += ", " + DateTime.Parse(this.mtbTermino.Text).ToString("yyyyMMdd");

                    if (this.chbConfExibicao.Checked)
                    {
                        sql += ", 'Sim'";
                    }
                    else
                    {
                        sql += ", 'Não'";
                    }

                    sql += " , '" + this.txtVlBilhete.Text + "'";
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

        private void tsbtnExcluir_Click(object sender, EventArgs e)
        {
            // Consistências
            // Se pelo menos o campo da chave está informado.
            if (String.IsNullOrEmpty(this.mtbDataSessao.Text) || String.IsNullOrEmpty(this.mtbHoraInicio.Text) || String.IsNullOrEmpty(this.txtCodigoSala.Text) || String.IsNullOrEmpty(this.txtTemporadaPeca.Text))
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
            sql += " SESSAO_TEMPORADA";
            sql += " WHERE";
            sql += " DT_SESSAO = " + DateTime.Parse(this.mtbDataSessao.Text).ToString("yyyyMMdd");
            //sql += " AND HR_SESSAO = " + DateTime.Parse(this.mtbHoraInicio.Text).Hour + DateTime.Parse(this.mtbHoraInicio.Text).Minute;
            sql += " AND HR_SESSAO = '" + DateTime.Parse(this.mtbHoraInicio.Text).ToString("HHmm") + "'";
            sql += " AND CD_SALA = '" + this.txtCodigoSala.Text + "'";
            sql += " AND CD_PECA = '" + this.txtTemporadaPeca.Text + "'";

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


            // Verifica se a peça já está disponível para exbição (Disponivel para Venda).
            sql = "SELECT";
            sql += " DT_SESSAO";
            sql += " FROM";
            sql += " SESSAO_TEMPORADA";
            sql += " WHERE";
            sql += " DT_SESSAO = " + DateTime.Parse(this.mtbDataSessao.Text).ToString("yyyyMMdd");
            // sql += " AND HR_SESSAO = " + DateTime.Parse(this.mtbHoraInicio.Text).Hour + DateTime.Parse(this.mtbHoraInicio.Text).Minute;
            sql += " AND HR_SESSAO = '" + DateTime.Parse(this.mtbHoraInicio.Text).ToString("HHmm") + "'";
            sql += " AND CD_SALA = '" + this.txtCodigoSala.Text + "'";
            sql += " AND CD_PECA = '" + this.txtTemporadaPeca.Text + "'";
            sql += " AND FL_CONF_EXIB = 'Sim'";

            try
            {
                using (OleDbCommand consulta = new OleDbCommand(sql, Dal.conn))
                {
                    // Se existe o registro
                    if (consulta.ExecuteReader().HasRows)
                    {
                        MessageBox.Show(null, "Esta Sessão para a peça: "
                            + this.txtTemporadaPeca.Text + " não pode ser excluída\n"
                            + "por que já está disponível para exibição  (disponível para venda).\n"
                            , "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            sql += " SESSAO_TEMPORADA";
            sql += " WHERE";
            sql += " DT_SESSAO = " + DateTime.Parse(this.mtbDataSessao.Text).ToString("yyyyMMdd");
            // sql += " AND HR_SESSAO = " + DateTime.Parse(this.mtbHoraInicio.Text).Hour + DateTime.Parse(this.mtbHoraInicio.Text).Minute;
            sql += " AND HR_SESSAO = '" + DateTime.Parse(this.mtbHoraInicio.Text).ToString("HHmm") + "'";
            sql += " AND CD_SALA = '" + this.txtCodigoSala.Text + "'";
            sql += " AND CD_PECA = '" + this.txtTemporadaPeca.Text + "'";

            try
            {
                using (OleDbCommand exclusao = new OleDbCommand(sql, Dal.conn))
                {
                    exclusao.ExecuteNonQuery();
                    MessageBox.Show(null, "Registro excluido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    FormHelper.InicializarControles(this.Controls);
                    this.lblNomePeca.Text = String.Empty;
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
            // O Código abaixo é para ao executar o sql no Access, formatar a data no grid para apresentação.
            sql += " cvdate(mid(trim(str(SESSAO_TEMPORADA.DT_SESSAO)) , 7, 2) + \"/\" + mid(trim(str(SESSAO_TEMPORADA.DT_SESSAO)), 5, 2) + \"/\" + mid(trim(str(SESSAO_TEMPORADA.DT_SESSAO)), 1, 4)) AS [Data Sessão]";
            // O Código abaixo é para ao executar o sql no Access, formatar a data no grid para apresentação.
            // sql += " , mid(str(SESSAO_TEMPORADA.HR_SESSAO), 1, 3) + \":\" + mid(str(SESSAO_TEMPORADA.HR_SESSAO), 4, 2) AS [Hora Incial]";
            sql += " , mid(SESSAO_TEMPORADA.HR_SESSAO, 1, 2) + \":\" + mid(SESSAO_TEMPORADA.HR_SESSAO, 3, 2) AS [Hora Incial]";
            sql += ", SESSAO_TEMPORADA.CD_SALA AS [Sala]";
            sql += ", SESSAO_TEMPORADA.QT_DISP_ASSENTOS AS [Assentos Disponíveis]";
            sql += ", SESSAO_TEMPORADA.CD_PECA AS [Peça - Temporada]";
            sql += ", PECA_TEATRAL.NM_PECA AS [Nome da Peça]";
            sql += " , cvdate(mid(trim(str(SESSAO_TEMPORADA.DT_ESTREIA)) , 7, 2) + \"/\" + mid(trim(str(SESSAO_TEMPORADA.DT_ESTREIA)), 5, 2) + \"/\" + mid(trim(str(SESSAO_TEMPORADA.DT_ESTREIA)), 1, 4)) AS [Data Estréia]";
            sql += " , cvdate(mid(trim(str(SESSAO_TEMPORADA.DT_TERMINO)) , 7, 2) + \"/\" + mid(trim(str(SESSAO_TEMPORADA.DT_TERMINO)), 5, 2) + \"/\" + mid(trim(str(SESSAO_TEMPORADA.DT_TERMINO)), 1, 4)) AS [Data Término]";
            sql += " , SESSAO_TEMPORADA.FL_CONF_EXIB AS [Confirmada Exibição?]";
            sql += ", SESSAO_TEMPORADA.VL_BILHETE AS [Valor do Bilhete]";
            sql += " FROM";
            sql += " SESSAO_TEMPORADA";
            sql += " , PECA_TEATRAL";
            sql += " WHERE";
            sql += " SESSAO_TEMPORADA.CD_PECA = PECA_TEATRAL.CD_PECA";
            sql += " ORDER BY";
            sql += " SESSAO_TEMPORADA.DT_SESSAO";
            sql += " , SESSAO_TEMPORADA.HR_SESSAO";
            sql += " , SESSAO_TEMPORADA.CD_SALA";

            if (FrmPrincipal.frmListaRegistros == null)
            {
                // Instancia a classe FrmListaRegistros passando o comando sql e o título
                // do formulário de Lista de Registros.
                FrmPrincipal.frmListaRegistros = new FrmListaRegistros(sql, "Agendamento de Sessões x Temporadas da Peça");
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
                // this.mtbHoraInicio.Text = TimeSpan.Parse(dados[1]).ToString("hhmm");
                this.mtbHoraInicio.Text = DateTime.Parse(dados[1]).ToString("HHmm");
                this.txtCodigoSala.Text = dados[2];
                this.txtQtDispAssento.Text = dados[3];
                this.txtTemporadaPeca.Text = dados[4];
                this.lblNomePeca.Text = dados[5];
                this.mtbEstreia.Text = dados[6];
                this.mtbTermino.Text = dados[7];

                if (dados[8] == "Sim")
                {
                    this.chbConfExibicao.Checked = true;
                }
                else
                {
                    this.chbConfExibicao.Checked = false;
                }

                this.txtVlBilhete.Text = dados[9];

                // Inicializa o valor de retorno do formulário Lista Registros.
                FrmListaRegistros.RetValores = String.Empty;
            }
        }

        private void btListaRegistroExternaSessao_Click(object sender, EventArgs e)
        {
            string sql = String.Empty;

            sql += "SELECT";
            // O Código abaixo é para ao executar o sql no Access, formatar a data e a hora no grid para apresentação.
            sql += " cvdate(mid(trim(str(DT_SESSAO)) , 7, 2) + \"/\" + mid(trim(str(DT_SESSAO)), 5, 2) + \"/\" + mid(trim(str(DT_SESSAO)), 1, 4)) AS [Data Sessão]";
            // sql += " , mid(str(HR_SESSAO), 1, 3) + \":\" + mid(str(HR_SESSAO), 4, 2) AS [Hora Incial]";
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
                //this.mtbHoraInicio.Text = TimeSpan.Parse(dados[1]).ToString("hhmm");
                this.mtbHoraInicio.Text = DateTime.Parse(dados[1]).ToString("HHmm");
                this.txtCodigoSala.Text = dados[2];
                this.txtQtDispAssento.Text = dados[3];

                // Inicializa o valor de retorno do formulário Lista Registros.
                FrmListaRegistros.RetValores = String.Empty;
            }
        }

        private void btListaRegistroExternaTemporadaPeca_Click(object sender, EventArgs e)
        {
            string sql = String.Empty;

            sql += "SELECT";
            sql += " TEMPORADA.CD_PECA AS [Código]";
            sql += " , PECA_TEATRAL.NM_PECA AS [Nome da Peça]";
            // O Código abaixo é para ao executar o sql no Access, formatar a data no grid para apresentação.
            sql += " , cvdate(mid(trim(str(TEMPORADA.DT_ESTREIA)) , 7, 2) + \"/\" + mid(trim(str(TEMPORADA.DT_ESTREIA)), 5, 2) + \"/\" + mid(trim(str(TEMPORADA.DT_ESTREIA)), 1, 4)) AS [Data Estréia]";
            sql += " , cvdate(mid(trim(str(TEMPORADA.DT_TERMINO)) , 7, 2) + \"/\" + mid(trim(str(TEMPORADA.DT_TERMINO)), 5, 2) + \"/\" + mid(trim(str(TEMPORADA.DT_TERMINO)), 1, 4)) AS [Data Término]";

            // Tentativa de uso de funções do VBA (Microsoft Access) para formatar os campos de data no sql.
            // sql += ", CStr(DT_ESTREIA) AS [Data Estréia]";
            // sql += ", CStr(DT_TERMINO) AS [Data Término]";

            sql += ", TEMPORADA.AN_OBS AS [Observações]";
            sql += " FROM";
            sql += " TEMPORADA";
            sql += " , PECA_TEATRAL";
            sql += " WHERE";
            sql += " TEMPORADA.CD_PECA = PECA_TEATRAL.CD_PECA";
            sql += " ORDER BY";
            sql += " TEMPORADA.CD_PECA";
            sql += ", TEMPORADA.DT_ESTREIA";
            sql += ", TEMPORADA.DT_TERMINO";

            if (FrmPrincipal.frmListaRegistros == null)
            {
                // Instancia a classe FrmListaRegistros passando o comando sql e o título
                // do formulário de Lista de Registros.
                FrmPrincipal.frmListaRegistros = new FrmListaRegistros(sql, "Temporadas");
                FrmPrincipal.frmListaRegistros.ShowDialog();
            }

            //Se o valor de retorno do formulário Lista Registros não é nulo ou vazio.
            if (!(String.IsNullOrEmpty(FrmListaRegistros.RetValores)))
            {
                string[] dados = FrmListaRegistros.RetValores.Split(Convert.ToChar("|"));
                this.txtTemporadaPeca.Text = dados[0];
                this.lblNomePeca.Text = dados[1];
                // Como os campos inteiros do Access que representam as datas já estão vindo formatados do sql.
                // não é mais necessário formatá-los (comandos comentados abaixo)
                //this.mtbEstreia.Text = DateTime.ParseExact(dados[1], "yyyyMMdd", null).ToString("ddMMyyyy");
                //this.mtbTermino.Text = DateTime.ParseExact(dados[2],"yyyyMMdd", null).ToString("ddMMyyyy");
                this.mtbEstreia.Text = dados[2];
                this.mtbTermino.Text = dados[3];

                // Inicializa o valor de retorno do formulário Lista Registros.
                FrmListaRegistros.RetValores = String.Empty;
            }
        }

        // Pesquisa para formatação do campo como moeda.
        // http://social.msdn.microsoft.com/Forums/pt-BR/vscsharppt/thread/8a92a64c-a1be-4cb7-b074-91997161a38f

        /// <summary>
        /// Método para tratar evento ao deixar o controle (Lost Focus)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVlBilhete_Leave(object sender, EventArgs e)
        {
            // Se o conteudo do campo não for vazio, aplica a formatação de moeda
            if (this.txtVlBilhete.Text != String.Empty)
            {
                // Aplica a formatação de moeda, se informado C ao invés de N, mostra o símbolo da moeda brasileira 'R$'
                this.txtVlBilhete.Text = Convert.ToDouble(txtVlBilhete.Text).ToString("N");
            }
        }

        /// <summary>
        /// Método para tratar o evento ao apertar a tecla do teclado, no controle de caixa de texto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVlBilhete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!this.txtVlBilhete.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        /// <summary>
        /// Método para tratar quando o controlo se torna o controle ativo no formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVlBilhete_Enter(object sender, EventArgs e)
        {
            String x = "";

            for (int i = 0; i <= this.txtVlBilhete.Text.Length - 1; i++)
            {
                if ((this.txtVlBilhete.Text[i] >= '0' && this.txtVlBilhete.Text[i] <= '9') || this.txtVlBilhete.Text[i] == ',')
                {
                    x += this.txtVlBilhete.Text[i];
                }
            }

            this.txtVlBilhete.Text = x;
            this.txtVlBilhete.SelectAll();
        }
    }
}
