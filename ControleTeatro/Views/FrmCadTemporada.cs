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
    public partial class FrmCadTemporada : Form
    {
        public FrmCadTemporada()
        {
            InitializeComponent();
        }

        private void FrmCadTemporada_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipal.frmCadTemporada = null;
        }

        private void FrmCadTemporada_Load(object sender, EventArgs e)
        {
            FormHelper.CentralizarForm(this);
        }

        private void tsbtnInicializar_Click(object sender, EventArgs e)
        {
            FormHelper.InicializarControles(this.Controls);
        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            /*
             * OBS: Rotina alterada para tratamento com datas no Access
             * na versão anterior desta rotina os campos DT_ESTREIA e DT_TERMINO
             * estavam sendo tratados como texto (10 posições) tanto na base
             * Access quanto no programa e estavam sendo gravadas na base no 
             * formato dd/MM/yyyy.
             * 
             * Na última versão (24/10/2012) desta rotina, esses campos são tratados
             * como número (long do Access) e são gravadas na base Access no formato
             * de data yyyyMMdd.
             * São feitas as devidas conversões para apresentar as datas no formulário
             * no formato dd/MM/yyyy.
             */

            // Faz a consistências dos campos NOT NULL
            // Se o valor dos campos é nulo ou vazio.
            if (String.IsNullOrEmpty(this.txtCodigoPeca.Text) || String.IsNullOrEmpty(this.mtbEstreia.Text) || String.IsNullOrEmpty(this.mtbTermino.Text))
            {
                MessageBox.Show(null, "Os campos requeridos devem ser informados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Se o valor dos campos é nulo ou espaço em branco.
            if (String.IsNullOrWhiteSpace(this.txtCodigoPeca.Text) || String.IsNullOrWhiteSpace(this.mtbEstreia.Text) || String.IsNullOrWhiteSpace(this.mtbTermino.Text))
            {
                MessageBox.Show(null, "Não são aceitos caracteres espaço em branco para os campos requeridos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Validar se os campos com máscara de data estão vazios.
            if (this.mtbEstreia.Text == "  /  /" || this.mtbTermino.Text == "  /  /")
            {
                MessageBox.Show(null, "Os campos requeridos devem ser informados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Se a data de Término é menor que a data de estréia.
            if(Convert.ToDateTime(this.mtbTermino.Text) < Convert.ToDateTime(this.mtbEstreia.Text))
            {
                MessageBox.Show(null, "A data de Término é menor que a data de Estréia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.mtbEstreia.Focus();
                return;
            }

            // Verifia se existe um caractere apóstrofo em todas as caixas de texto do formulário.
            if (FormHelper.VerificarCaracterProibido(this.Controls))
            {
                MessageBox.Show(null, "Não é permitido o uso de caracteres especiais ( ' | ) nos campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Antes de gravar o registro
            // Consulta se já existe a chave CD_USUARIO
            string sql = String.Empty;

            sql = "SELECT";
            sql += " CD_PECA";
            sql += " FROM";
            sql += " TEMPORADA";
            sql += " WHERE";
            sql += " CD_PECA = '" + this.txtCodigoPeca.Text + "'";
            sql += " AND DT_ESTREIA = " + DateTime.Parse(this.mtbEstreia.Text).ToString("yyyyMMdd") + "";
            sql += " AND DT_TERMINO = " + DateTime.Parse(this.mtbTermino.Text).ToString("yyyyMMdd") + "";

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
                    sql += " TEMPORADA";
                    sql += " SET";
                    sql += " AN_OBS = '" + this.txtObs.Text + "'";
                    sql += " WHERE";
                    sql += " CD_PECA = '" + this.txtCodigoPeca.Text + "'";
                    sql += " AND DT_ESTREIA = " + DateTime.Parse(this.mtbEstreia.Text).ToString("yyyyMMdd") + "";
                    sql += " AND DT_TERMINO = " + DateTime.Parse(this.mtbTermino.Text).ToString("yyyyMMdd") + "";

                    mensagem = "Registro alterado com sucesso.";

                    break;

                case "INSERT":
                    sql = "INSERT INTO";
                    sql += " TEMPORADA";
                    sql += "(";
                    sql += "CD_PECA";
                    sql += ", DT_ESTREIA";
                    sql += ", DT_TERMINO";
                    sql += ", AN_OBS";
                    sql += " )";
                    sql += " VALUES";
                    sql += "(";
                    sql += "'" + this.txtCodigoPeca.Text + "'";
                    sql += ", " + DateTime.Parse(this.mtbEstreia.Text).ToString("yyyyMMdd") + "";
                    sql += ", " + DateTime.Parse(this.mtbTermino.Text).ToString("yyyyMMdd") + "";
                    sql += ", '" + this.txtObs.Text + "'";
                    sql += ")";

                    mensagem = "Registro gravado com sucesso.";

                    break;
            }

            try
            {
                //---------------------------------------------------------------------------------------------------------------------------------
                // Para um novo registro de temporada, verificar antes se a DT_ESTREIA
                // para a nova temporada informada na aplicação é MAIOR que a DT_TERMINO
                // registrada na base de dados.

                // É um novo registro
                if (operacao == "INSERT")
                {
                    string regraSql = "SELECT MAX(DT_TERMINO) AS DT_TERMINO FROM TEMPORADA WHERE CD_PECA = '" + this.txtCodigoPeca.Text + "'";
                    // Executa o coamando para fazer a comparação
                    using (OleDbCommand comando = new OleDbCommand(regraSql, Dal.conn))
                    {
                        OleDbDataReader dr = comando.ExecuteReader();
                        dr.Read();

                        string dt_estreia = this.mtbEstreia.Text;
                        string dt_termino = DateTime.ParseExact(dr.GetValue(0).ToString(), "yyyyMMdd", null).ToString("dd/MM/yyyy");
                        
                        // Se a nova DT_ESTREIA informada for menor que DT_TERMINO registrada para a mesma peça teatral.
                        if (Convert.ToDateTime(dt_estreia) < Convert.ToDateTime(dt_termino))
                        {
                            MessageBox.Show(null, "A data de Estréia para uma nova temporada da peça: "
                                + this.txtCodigoPeca.Text
                                + ", deve ser superior a data de Término da última temporada já registrada"
                                + " para essa peça teatral.\n\nData de Término para a última temporada da peça cód: "
                                + this.txtCodigoPeca.Text + " é "
                                + dt_termino + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
                //---------------------------------------------------------------------------------------------------------------------------------

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
            if (String.IsNullOrEmpty(this.txtCodigoPeca.Text))
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
            sql += " CD_PECA";
            sql += " FROM";
            sql += " TEMPORADA";
            sql += " WHERE";
            sql += " CD_PECA = '" + this.txtCodigoPeca.Text + "'";
            sql += " AND DT_ESTREIA = " + DateTime.Parse(this.mtbEstreia.Text).ToString("yyyyMMdd") + "";
            sql += " AND DT_TERMINO = " + DateTime.Parse(this.mtbTermino.Text).ToString("yyyyMMdd") + "";

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
            sql += " TEMPORADA";
            sql += " WHERE";
            sql += " CD_PECA = '" + this.txtCodigoPeca.Text + "'";
            sql += " AND DT_ESTREIA = " + DateTime.Parse(this.mtbEstreia.Text).ToString("yyyyMMdd") + "";
            sql += " AND DT_TERMINO = " + DateTime.Parse(this.mtbTermino.Text).ToString("yyyyMMdd") + "";

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

        private void tsbtnListarRegistros_Click(object sender, EventArgs e)
        {
            string sql = String.Empty;

            sql += "SELECT";
            sql += " CD_PECA AS [Código]";
            // O Código abaixo é para ao executar o sql no Access, formatar a data no grid para apresentação.
            sql += " , cvdate(mid(trim(str(DT_ESTREIA)) , 7, 2) + \"/\" + mid(trim(str(DT_ESTREIA)), 5, 2) + \"/\" + mid(trim(str(DT_ESTREIA)), 1, 4)) AS [Data Estréia]";
            sql += " , cvdate(mid(trim(str(DT_TERMINO)) , 7, 2) + \"/\" + mid(trim(str(DT_TERMINO)), 5, 2) + \"/\" + mid(trim(str(DT_TERMINO)), 1, 4)) AS [Data Término]";
            
            // Tentativa de uso de funções do VBA (Microsoft Access) para formatar os campos de data no sql.
            // sql += ", CStr(DT_ESTREIA) AS [Data Estréia]";
            // sql += ", CStr(DT_TERMINO) AS [Data Término]";

            sql += ", AN_OBS AS [Observações]";
            sql += " FROM";
            sql += " TEMPORADA";
            sql += " ORDER BY";
            sql += " CD_PECA";
            sql += ", DT_ESTREIA";
            sql += ", DT_TERMINO";

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
                this.txtCodigoPeca.Text = dados[0];
                // Como os campos inteiros do Access que representam as datas já estão vindo formatados do sql.
                // não é mais necessário formatá-los (comandos comentados abaixo)
                //this.mtbEstreia.Text = DateTime.ParseExact(dados[1], "yyyyMMdd", null).ToString("ddMMyyyy");
                //this.mtbTermino.Text = DateTime.ParseExact(dados[2],"yyyyMMdd", null).ToString("ddMMyyyy");

                this.mtbEstreia.Text = dados[1];
                this.mtbTermino.Text = dados[2];
                this.txtObs.Text = dados[3];

                // Inicializa o valor de retorno do formulário Lista Registros.
                FrmListaRegistros.RetValores = String.Empty;
            }
        }

        private void btListaRegistroExterna_Click(object sender, EventArgs e)
        {
            string sql = String.Empty;

            sql += "SELECT";
            sql += " CD_PECA AS [Código]";
            sql += ", NM_PECA AS [Nome da Peça]";
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

                // Inicializa o valor de retorno do formulário Lista Registros.
                FrmListaRegistros.RetValores = String.Empty;
            }
        }
    }
}
