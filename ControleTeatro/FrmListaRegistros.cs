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

namespace ControleTeatro
{
    public partial class FrmListaRegistros : Form
    {
        private static string retValores;

        public static string RetValores
        {
            get { return retValores; }
            set { retValores = value; }
        }

        /// <summary>
        /// Construtor padrão da classe FrmListaRegistros.
        /// </summary>
        public FrmListaRegistros()
        {
            // Incializa os controles deste formulário.
            InitializeComponent();
        }

        /// <summary>
        /// Construtor sobrecarregado da classe FrmListaRegistros.
        /// </summary>
        /// <param name="pSql">pSql - comando sql que será processado para retorno dos dados no DataGridView</param>
        /// <param name="pTitulo">pTitulo - Título opcional para contextualizar a consulta exibida no DataGridView</param>
        public FrmListaRegistros(string pSql, string pTitulo = "")
        {
            // Inicializa os controles deste formulário.
            InitializeComponent();

            // Se o parâmetro título for diferente de vazio.
            if (pTitulo != "")
            {
                // Adiciona ao valor do título o valor do parâmetro.
                this.Text += " - " + pTitulo;
            }

            // Configura o controle DataGridViewer.
            this.ConfiguraDataGridView();
            // Obtém os dados da tabela para a fonte de dados do controle DataGridView.
            this.dgwRegistros.DataSource = this.ObterDados(pSql);
            // Obtém o total de registros da tabela.
            this.lblResultado.Text = this.ObterDados(pSql).Rows.Count.ToString();
        }

        /// <summary>
        /// Método para tratar o evendo ao carregar este formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmListaRegistros_Load(object sender, EventArgs e)
        {
            // Centraliza o formulário em relação ao monitor.
            FormUtils.CentralizaForm(this);
        }

        /// <summary>
        /// Método para tratar o evento ao encerrar este formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmListaRegistros_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Desreferncia o campo no formulário principal.
            FrmPrincipal.frmListaRegistros = null;
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
            this.dgwRegistros.AllowUserToAddRows = false;
            this.dgwRegistros.AllowUserToDeleteRows = false;
            this.dgwRegistros.AllowUserToResizeColumns = false;
            this.dgwRegistros.AllowUserToResizeRows = false;
            this.dgwRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwRegistros.BackgroundColor = System.Drawing.Color.White;
            this.dgwRegistros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwRegistros.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRegistros.MultiSelect = false;
            this.dgwRegistros.ReadOnly = true;
            this.dgwRegistros.RowHeadersVisible = false;
            this.dgwRegistros.RowTemplate.Height = 18;
            this.dgwRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // -----------------------------------------------------------------------------------------------------------------------------------------------------
        }

        
        /// <summary>
        /// Método para travar evento de duplo clique do mouse na célula do controle DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Envia o valor da 1° coluna da linha selecionada para a caixa de texto
            // do objeto Formulário chamador (botão chamador deste formulário).
            // RetValores = this.dataGridView.CurrentRow.Cells[0].Value.ToString();

            // Percorre o dataGridView em busca dos valores de cada coluna
            // da linha selecionada pelo usuário.
            for (int l = 0; l < this.dgwRegistros.ColumnCount; l++)
            {
                // A propriedade RetValores recebe todos os valores
                // acumulados das// colunas separadas por um pipe "|".
                RetValores += this.dgwRegistros.CurrentRow.Cells[l].Value.ToString() + "|";
            }

            // Encerra o formulário Lista de Registros.
            this.Dispose();
        }

        /// <summary>
        /// Método que trata o evento ao pressionar alguma tecla do teclado.
        /// OBS: A propriedade KeyPreview deste formulário deve estar configurado como true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmListaRegistros_KeyDown(object sender, KeyEventArgs e)
        {
            // Se o código da tecla é igual a ESCAPE (ESC)
            if (e.KeyCode == Keys.Escape)
            {
                // Encerra (dispensa) este formulário.
                this.Dispose();
            }
        }
    }
}
