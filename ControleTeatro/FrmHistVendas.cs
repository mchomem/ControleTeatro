using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ControleTeatro
{
    public partial class FrmHistVendas : Form
    {
        public FrmHistVendas()
        {
            InitializeComponent();
            this.ConfiguraDataGridView();
        }

        private void FrmHistVendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipal.frmHistVendas = null;
        }

        private void FrmHistVendas_Load(object sender, EventArgs e)
        {
            FormUtils.CentralizaForm(this);
        }

        private void btListaRegistroExterna_Click(object sender, EventArgs e)
        {
            string sql = String.Empty;

            sql += "SELECT";
            sql += " CD_PECA AS [Código]";
            sql += ", NM_PECA AS [Nome da Peça Teatral]";
            sql += " FROM";
            sql += " PECA_TEATRAL";
            sql += " ORDER BY";
            sql += " CD_PECA";

            if (FrmPrincipal.frmListaRegistros == null)
            {
                // Instancia a classe FrmListaRegistros passando o comando sql e o título
                // do formulário de Lista de Registros.
                FrmPrincipal.frmListaRegistros = new FrmListaRegistros(sql, "Peças Teatrais");
                FrmPrincipal.frmListaRegistros.ShowDialog();
            }

            //Se o valor de retorno do formulário Lista Registros não é nulo ou vazio.
            if (!(String.IsNullOrEmpty(FrmListaRegistros.RetValores)))
            {
                string[] dados = FrmListaRegistros.RetValores.Split(Convert.ToChar("|"));
                this.txtCodigoPeca.Text = dados[0];
                this.lblNomePeca.Text = dados[1];

                // Inicializa o valor de retorno do formulário Lista Registros.
                FrmListaRegistros.RetValores = String.Empty;
            }
        }

        private void tsbtnInicializar_Click(object sender, EventArgs e)
        {
            FormUtils.InicializaControles(this.Controls);
            this.lblNomePeca.Text = String.Empty;
            this.rbnNaoOrd.Checked = true;
            this.lblResultado.Text = "0";
            this.dgvVendas.Columns.Clear();
        }

        private void tsbtnConsultar_Click(object sender, EventArgs e)
        {
            this.PreencheGrade();
        }

        private void PreencheGrade()
        {
            // Se as datas de início e fim forem preenchidas
            if (this.mtbDtInicio.Text != "  /  /" && this.mtbDtFim.Text != "  /  /")
            {
                // Testa se a data de fim é menor que de início.
                if(Convert.ToDateTime(this.mtbDtFim.Text) < Convert.ToDateTime(this.mtbDtInicio.Text))
                {
                    MessageBox.Show(null, "A data de fim é menor que a data de início.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            string sql = String.Empty;

            sql = "SELECT";
            sql += " VENDA.NR_BILHETE AS [Nº Bilhete]";
            // O Código abaixo é para ao executar o sql no Access, formatar a data no grid para apresentação.
            sql += ", cvdate(mid(trim(str(VENDA.DT_EMISS_BILHETE)) , 7, 2) + \"/\" + mid(trim(str(VENDA.DT_EMISS_BILHETE)), 5, 2) + \"/\" + mid(trim(str(VENDA.DT_EMISS_BILHETE)), 1, 4)) AS [Data Emissão Bilhete]";
            // O Código abaixo é para ao executar o sql no Access, formatar a hora no grid para apresentação.
            sql += ", mid(VENDA.HR_EMISS_BILHETE, 1, 2) + \":\" + mid(VENDA.HR_EMISS_BILHETE, 3, 2) AS [Hora Emissão Bilhete]";
            // O Código abaixo é para ao executar o sql no Access, formatar a data no grid para apresentação.
            sql += ", cvdate(mid(trim(str(VENDA.DT_SESSAO)) , 7, 2) + \"/\" + mid(trim(str(VENDA.DT_SESSAO)), 5, 2) + \"/\" + mid(trim(str(VENDA.DT_SESSAO)), 1, 4)) AS [Data Sessão]";
            // O Código abaixo é para ao executar o sql no Access, formatar a hora no grid para apresentação.
            //sql += " , mid(str(SESSAO_TEMPORADA.HR_SESSAO), 1, 3) + \":\" + mid(str(SESSAO_TEMPORADA.HR_SESSAO), 4, 2) AS [Hora Incial]";
            sql += ", mid(VENDA.HR_SESSAO, 1, 2) + \":\" + mid(VENDA.HR_SESSAO, 3, 2) AS [Hora Incial]";
            sql += ", VENDA.CD_SALA AS [Sala]";
            sql += ", VENDA.CD_PECA AS [Peça - Temporada]";
            sql += ", PECA_TEATRAL.NM_PECA AS [Nome da Peça]";
            sql += " FROM";
            sql += " VENDA";
            sql += " , PECA_TEATRAL";
            sql += " WHERE";
            sql += " VENDA.CD_PECA = PECA_TEATRAL.CD_PECA";

            if(this.txtCodigoPeca.Text != String.Empty)
            {
                sql += " AND VENDA.CD_PECA = '" + this.txtCodigoPeca.Text + "'";
            }
            
            if ((this.mtbDtInicio.Text != "  /  /") && (this.mtbDtFim.Text != "  /  /"))
            {
                sql += " AND VENDA.DT_EMISS_BILHETE BETWEEN " + DateTime.Parse(this.mtbDtInicio.Text).ToString("yyyyMMdd") + " AND " + DateTime.Parse(this.mtbDtFim.Text).ToString("yyyyMMdd"); 
            }

            if (this.rbnOrdNrBilhete.Checked)
            {
                sql += " ORDER BY";
                sql += " VENDA.NR_BILHETE";
            }

            if (this.rbnOrdDtEmissBilhete.Checked)
            {
                sql += " ORDER BY";
                sql += " VENDA.DT_EMISS_BILHETE";
            }

            if(this.rbnOrdNmPeca.Checked)
            {
                sql += " ORDER BY";
                sql += " PECA_TEATRAL.NM_PECA";
            }


            this.dgvVendas.Columns.Clear();
            this.dgvVendas.DataSource = this.ObterDados(sql);

            // Obtém o total de registros da tabela.
            this.lblResultado.Text = this.ObterDados(sql).Rows.Count.ToString();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendas.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AllowUserToResizeColumns = false;
            this.dgvVendas.AllowUserToResizeRows = false;
            this.dgvVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVendas.BackgroundColor = System.Drawing.Color.White;
            this.dgvVendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.MultiSelect = false;
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.RowHeadersVisible = false;
            this.dgvVendas.RowTemplate.Height = 18;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // -----------------------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
