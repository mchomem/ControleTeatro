/* Autor: Misael da Costa Homem.
 * Ano: 2012
 * Cadeira: Linguagem de Programação I
 * Semestre: 3º
 * Turma: ADS3N12/2A
 * Docente: Lizandro Kirts da Silva.
 * Instituição: Faculdade Senac Porto Alegre - RS
 */

using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ControleTeatro
{
    public partial class FrmPDV : Form
    {
        private string cdPeca;
        private string cDtSessao;
        private string cHrSessao;
        private string cCdSala;
        private string cQtDispAssentos;
        
        public FrmPDV()
        {
            InitializeComponent();
            this.ConfiguraDataGridView();
        }


        private void FrmPDV_Load(object sender, EventArgs e)
        {
            FormUtils.CentralizaForm(this);
            this.PreencheGrade();
        }


        private void FrmPDV_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipal.frmPDV = null;
        }

        private void PreencheGrade()
        {
            string sql = String.Empty;

            sql += "SELECT";
            // O Código abaixo é para ao executar o sql no Access, formatar a data no grid para apresentação.
            sql += " cvdate(mid(trim(str(SESSAO_TEMPORADA.DT_SESSAO)) , 7, 2) + \"/\" + mid(trim(str(SESSAO_TEMPORADA.DT_SESSAO)), 5, 2) + \"/\" + mid(trim(str(SESSAO_TEMPORADA.DT_SESSAO)), 1, 4)) AS [Data Sessão]";
            // O Código abaixo é para ao executar o sql no Access, formatar a data no grid para apresentação.
            //sql += " , mid(str(SESSAO_TEMPORADA.HR_SESSAO), 1, 3) + \":\" + mid(str(SESSAO_TEMPORADA.HR_SESSAO), 4, 2) AS [Hora Incial]";
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
            sql += " AND SESSAO_TEMPORADA.FL_CONF_EXIB = 'Sim'";

            // NÃO ESQUECER DE ADICIONAR NO WHERE, SESSÕES COM DATA INFERIOR A DATA ATUAL NÃO DEVEM APARECER NO VISOR DO PDV.

            sql += " ORDER BY";
            sql += " SESSAO_TEMPORADA.DT_SESSAO";
            sql += " , SESSAO_TEMPORADA.HR_SESSAO";
            sql += " , SESSAO_TEMPORADA.CD_SALA";

            
            this.dgvSessoesTemporada.Columns.Clear();
            this.dgvSessoesTemporada.DataSource = this.ObterDados(sql);
        }

        /// <summary>
        /// Função que recebe um comando sql e devolve um DataTable com os dados da instrução sql
        /// passada por parâmetro.
        /// </summary>
        /// <param name="pSql">Comando sql.</param>
        /// <returns></returns>
        private DataTable ObterDados(string pSql)
        {
            try
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter da;
                string sql = pSql;
                da = new OleDbDataAdapter(sql, Dal.conn);
                da.Fill(dt);
                return dt;
            }
            catch (OleDbException except)
            {
                // Exibe mensagem de erro.
                MessageBox.Show(null, "Não foi possível executar a consulta.\n\n"
                    + "Detalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Retorna nulo para o método que chamou este método.
                return null;
            }
        }

        /// <summary>
        /// Método para configurar o controle DataGridView em tempo de execução.
        /// Este método também configura o controle GroupBox que contem o DatGridView.
        /// </summary>
        private void ConfiguraDataGridView()
        {
            // Configurações para o GroupBox -----------------------------------------------------------------------------------------------------------------------
            this.gbRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            // -----------------------------------------------------------------------------------------------------------------------------------------------------

            // Configurações para o DataGridView -------------------------------------------------------------------------------------------------------------------
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime;
            this.dgvSessoesTemporada.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSessoesTemporada.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSessoesTemporada.AllowUserToAddRows = false;
            this.dgvSessoesTemporada.AllowUserToDeleteRows = false;
            this.dgvSessoesTemporada.AllowUserToResizeColumns = false;
            this.dgvSessoesTemporada.AllowUserToResizeRows = false;
            this.dgvSessoesTemporada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSessoesTemporada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSessoesTemporada.BackgroundColor = System.Drawing.Color.Black;
            this.dgvSessoesTemporada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSessoesTemporada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessoesTemporada.MultiSelect = false;
            this.dgvSessoesTemporada.ReadOnly = true;
            this.dgvSessoesTemporada.RowHeadersVisible = false;
            this.dgvSessoesTemporada.RowTemplate.Height = 18;
            this.dgvSessoesTemporada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // -----------------------------------------------------------------------------------------------------------------------------------------------------
        }


        private void dgvSessoesTemporada_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string retValores = String.Empty;

            // Percorre o dataGridView em busca dos valores de cada coluna
            // da linha selecionada pelo usuário.
            for (int l = 0; l < this.dgvSessoesTemporada.ColumnCount; l++)
            {
                // A propriedade RetValores recebe todos os valores
                // acumulados das// colunas separadas por um pipe "|".
                retValores += this.dgvSessoesTemporada.CurrentRow.Cells[l].Value.ToString() + "|";
            }

            string[] dados = retValores.Split(Convert.ToChar("|"));

            // Se houver cadeiras para vender bilhete, carrega nos campos do PDV as informações da
            // Sessão x Temporada da Peça (nome, valor) e alimenta as variáveis de uso do PDV.
            if (Convert.ToInt32(dados[3]) > 0)
            {
                cDtSessao = dados[0];
                cHrSessao = dados[1];
                cCdSala = dados[2];
                cQtDispAssentos = dados[3];
                cdPeca = dados[4];
                this.txtNomePeca.Text = dados[5];
                this.txtTotalPagar.Text = dados[9];

                this.txtSituacao.Text = "Disponível";
                this.txtSituacao.ForeColor = Color.Blue;
            }
            else
            {
                this.txtSituacao.Text = "Esgotado";
                this.txtSituacao.ForeColor = Color.Red;
            }
        }

        private void FrmPDV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                EfetuarVenda();
            }
        }

        private void btnEfetuarVenda_Click(object sender, EventArgs e)
        {
            EfetuarVenda();
        }

        public void EfetuarVenda()
        {
            // Faz validação dos campos do PDV.
            if (String.IsNullOrEmpty(this.txtNomePeca.Text) || this.txtTotalPagar.Text == "0,00")
            {
                MessageBox.Show(null, "Um item deve ser informado para efetuar a venda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dr;
            dr = MessageBox.Show(null, "Deseja efetuar a venda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se o resultado do diálogo for sim.
            if (dr == DialogResult.Yes)
            {
                // Grava um registro para a venda.

                string sql = String.Empty;
                string mensagem = String.Empty;

                sql = " INSERT INTO";
                sql += " VENDA";
                sql += "(";
                sql += "DT_EMISS_BILHETE";
                sql += ", HR_EMISS_BILHETE";
                sql += ", DT_SESSAO";
                sql += ", HR_SESSAO";
                sql += ", CD_SALA";
                sql += ", CD_PECA";
                sql += ", VL_TOTAL";
                sql += ", CD_USUARIO ";
                sql += ")";
                sql += " VALUES";
                sql += "(";
                sql +=  DateTime.Now.ToString("yyyyMMdd");
                sql += ", '" + DateTime.Now.ToString("HHmm") + "'"; // Gravar no padrão 24 horas
                sql += ", " + DateTime.Parse(cDtSessao).ToString("yyyyMMdd"); //Remover formatação de data
                sql += ", '" + DateTime.Parse(cHrSessao).ToString("HHmm") + "'"; // Remover formatação de hora
                sql += ", '" + cCdSala + "'";
                sql += ", '" + cdPeca + "'";
                sql += ", '" + this.txtTotalPagar.Text + "'";
                sql += ", '" + Program.sessaoUsuario.Nome + "'";
                sql += ")";

                mensagem = "Venda efetuado com sucesso";

                try
                {
                    using (OleDbCommand comando = new OleDbCommand(sql, Dal.conn))
                    {
                        comando.ExecuteNonQuery();
                        FormUtils.InicializaControles(this.Controls);
                    }
                }
                catch (OleDbException except)
                {
                    MessageBox.Show(null, "Não foi possível executar a operação de registro da venda.\n\n"
                        + "Detalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Atualiza a quantidade de assentos para tabela SESSAO_TEMPORADA.
                int assentoDebitado = Convert.ToInt32(cQtDispAssentos) - 1;

                sql = "UPDATE ";
                sql += " SESSAO_TEMPORADA";
                sql += " SET";
                sql += " QT_DISP_ASSENTOS = " + assentoDebitado;
                sql += " WHERE";
                sql += " DT_SESSAO = " + DateTime.Parse(cDtSessao).ToString("yyyyMMdd");
                sql += " AND HR_SESSAO = '" + DateTime.Parse(cHrSessao).ToString("HHmm") + "'";
                sql += " AND CD_SALA = '" + cCdSala + "'";

                try
                {
                    using (OleDbCommand comando = new OleDbCommand(sql, Dal.conn))
                    {
                        comando.ExecuteNonQuery();
                    }
                }
                catch (OleDbException except)
                {
                    MessageBox.Show(null, "Não foi possível executar a operação de atualização na tabela SESSAO_TEMPORADA.\n\n"
                        + "Detalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Atualizar a tabela de sessões disponíveis no PDV.
                this.PreencheGrade();

                MessageBox.Show(null, mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
