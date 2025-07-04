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
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ControleTeatro.Helpers;

namespace ControleTeatro.Views
{
    public partial class FrmCadPecaTeatral : Form
    {
        private string nomeArquivo;

        public FrmCadPecaTeatral()
        {
            InitializeComponent();
        }

        private void FrmCadPecaTeatral_Load(object sender, EventArgs e)
        {
            // Centraliza este formulário.
            FormHelper.CentralizarForm(this);
        }

        private void FrmCadPecaTeatral_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipal.frmCadPecaTeatral = null;
        }

        private void btListaRegistroExterna_Click(object sender, EventArgs e)
        {
            string sql = String.Empty;

            sql += "SELECT";
            sql += " CD_CLASSIFICACAO AS [Código]";
            sql += ", DS_CLASSIFICACAO AS [Descrição]";
            sql += " FROM";
            sql += " CLASSIFICACAO";
            sql += " ORDER BY";
            sql += " CD_CLASSIFICACAO";

            if (FrmPrincipal.frmListaRegistros == null)
            {
                // Instancia a classe FrmListaRegistros passando o comando sql e o título
                // do formulário de Lista de Registros.
                FrmPrincipal.frmListaRegistros = new FrmListaRegistros(sql, "Classificações");
                FrmPrincipal.frmListaRegistros.ShowDialog();
            }

            //Se o valor de retorno do formulário Lista Registros não é nulo ou vazio.
            if (!(String.IsNullOrEmpty(FrmListaRegistros.RetValores)))
            {
                string[] dados = FrmListaRegistros.RetValores.Split(Convert.ToChar("|"));
                this.txtClassificacao.Text = dados[0];

                // Inicializa o valor de retorno do formulário Lista Registros.
                FrmListaRegistros.RetValores = String.Empty;
            }
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            // Inicializa a propriedade FileName.
            this.ofdCaminhoArquivo.FileName = String.Empty;
            // Configura o filtro para arquivos de imagem e para todos os arquivos.
            this.ofdCaminhoArquivo.Filter = "Todos os arquivos (*.*)|*.*|(*.png)|*.png|(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.bmp)|*.bmp";
            // Abre o diálogo de escolha de arquivo.
            this.ofdCaminhoArquivo.ShowDialog();

            // Se o caminho/arquivo selecionado for diferente de uma string vazia...
            if (this.ofdCaminhoArquivo.FileName != String.Empty)
            {
                // Atribui o valor para o campo Diretório.
                this.txtCaminhoImagem.Text = ofdCaminhoArquivo.FileName;

                try
                {
                    // Configura o diretório padrão onde as imagens ficarão copiadas.
                    string destinoCopia = Application.StartupPath + @"\ImagemCapa";
                    
                    // Se o diretório destino não existe, cria-o.
                    if (!Directory.Exists(destinoCopia))
                    {
                        Directory.CreateDirectory(destinoCopia);
                    }

                    // Define o nome do arquivo com prefixo do dia e hora + nome do arquivo + extensão.
                    nomeArquivo = DateTime.Now.ToString("ddMMyyyy.hhmmss") + "_" + this.ofdCaminhoArquivo.SafeFileName;

                    // Adiciona o nome do arquivo para a cópia.
                    destinoCopia += @"\" + nomeArquivo;

                    // Faz uma cópia da imagem para o diretório ImagemCapa no diretório da aplicação.
                    File.Copy(this.ofdCaminhoArquivo.FileName, destinoCopia, false);

                    // Controle PictureBox recebe a imagem.
                    pbImagemCapa.Image = new Bitmap(this.ofdCaminhoArquivo.FileName);
                }
                catch(Exception except)
                {
                    MessageBox.Show(null, "Não foi possível carregar a imagem.\n\nDetalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsbtnInicializar_Click(object sender, EventArgs e)
        {
            // Inicializa os controles deste formulário.
            FormHelper.InicializarControles(this.Controls);
            // Carrega a imagem da Capa Padrão dos recursos do projeto para o controle PictureBox.
            this.pbImagemCapa.Image = Properties.Resources.CapaPadrao;
        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            // Faz a consistências dos campos NOT NULL
            // Se o valor dos campos é nulo ou vazio.
            if (String.IsNullOrEmpty(this.txtCodigoPeca.Text) || String.IsNullOrEmpty(this.txtNomePeca.Text) || String.IsNullOrEmpty(this.txtClassificacao.Text) || String.IsNullOrEmpty(this.txtAtorPrincipal.Text))
            {
                MessageBox.Show(null, "Os campos requeridos devem ser informados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Se o valor dos campos é nulo ou espaço em branco.
            if (String.IsNullOrWhiteSpace(this.txtCodigoPeca.Text) || String.IsNullOrWhiteSpace(this.txtNomePeca.Text) || String.IsNullOrWhiteSpace(this.txtClassificacao.Text) || String.IsNullOrWhiteSpace(this.txtAtorPrincipal.Text))
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
            // Consulta se já existe a chave CD_PECA
            string sql = String.Empty;

            sql = "SELECT";
            sql += " CD_PECA";
            sql += " FROM";
            sql += " PECA_TEATRAL";
            sql += " WHERE";
            sql += " CD_PECA = '" + this.txtCodigoPeca.Text + "'";

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
                    sql += " PECA_TEATRAL";
                    sql += " SET";
                    sql += " NM_PECA = '" + this.txtNomePeca.Text + "'";
                    sql += ", CD_CLASSIFICACAO = '" + this.txtClassificacao.Text + "'";
                    sql += ", NM_ATOR_PRINCIPAL = '" + this.txtAtorPrincipal.Text + "'";
                    sql += ", NM_ATRIZ_PRINCIPAL = '" + this.txtAtrizPrincipal.Text + "'";
                    sql += ", NM_ATOR_COADJUVANTE = '" + this.txtAtorCoadjuvante.Text + "'";

                    if (!(String.IsNullOrEmpty(nomeArquivo)))
                    {
                        // Grava no banco somente o sub-dretório e o nome da imagem + extensão.
                        sql += ", AN_IMAGEM_CAPA = '" + @"\ImagemCapa\" + nomeArquivo + "'";
                    }
                    else
                    {
                        sql += ", AN_IMAGEM_CAPA = ''";
                    }

                    sql += " WHERE";
                    sql += " CD_PECA = '" + this.txtCodigoPeca.Text + "'";

                    mensagem = "Registro alterado com sucesso.";

                    break;

                case "INSERT":
                    sql = "INSERT INTO";
                    sql += " PECA_TEATRAL";
                    sql += "(";
                    sql += "CD_PECA";
                    sql += ", NM_PECA";
                    sql += ", CD_CLASSIFICACAO";
                    sql += ", NM_ATOR_PRINCIPAL";
                    sql += ", NM_ATRIZ_PRINCIPAL";
                    sql += ", NM_ATOR_COADJUVANTE";
                    sql += ", AN_IMAGEM_CAPA";
                    sql += " )";
                    sql += " VALUES";
                    sql += "(";
                    sql += "'" + this.txtCodigoPeca.Text + "'";
                    sql += ", '" + this.txtNomePeca.Text + "'";
                    sql += ", '" + this.txtClassificacao.Text + "'";
                    sql += ", '" + this.txtAtorPrincipal.Text + "'";
                    sql += ", '" + this.txtAtrizPrincipal.Text + "'";
                    sql += ", '" + this.txtAtorCoadjuvante.Text + "'";

                    if (!(String.IsNullOrEmpty(nomeArquivo)))
                    {
                        // Grava no banco somente o sub-dretório e o nome da imagem + extensão.
                        sql += ", '" + @"\ImagemCapa\" + nomeArquivo + "'";
                    }
                    else
                    {
                        sql += ", ''";
                    }

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
                    // Inicializa os controles deste formulário.
                    FormHelper.InicializarControles(this.Controls);
                    // Carrega a imagem da Capa Padrão dos recursos do projeto para o controle PictureBox.
                    this.pbImagemCapa.Image = Properties.Resources.CapaPadrao;
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
            sql += " PECA_TEATRAL";
            sql += " WHERE";
            sql += " CD_PECA = '" + this.txtCodigoPeca.Text + "'";

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
                        pbImagemCapa.Image = Properties.Resources.CapaPadrao;
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
            sql += " PECA_TEATRAL";
            sql += " WHERE";
            sql += " CD_PECA = '" + this.txtCodigoPeca.Text + "'";

            try
            {
                using (OleDbCommand exclusao = new OleDbCommand(sql, Dal.conn))
                {
                    exclusao.ExecuteNonQuery();
                    MessageBox.Show(null, "Registro excluido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    // Icializa os controles deste formulário.
                    FormHelper.InicializarControles(this.Controls);
                    // Carrega a imagem da Capa Padrão dos recursos do projeto para o controle PictureBox.
                    this.pbImagemCapa.Image = Properties.Resources.CapaPadrao;
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
            sql += ", NM_PECA AS [Nome da Peça Teatral]";
            sql += ", CD_CLASSIFICACAO AS [Classificação]";
            sql += ", NM_ATOR_PRINCIPAL AS [Ator Principal]";
            sql += ", NM_ATRIZ_PRINCIPAL AS [Atriz Principal]";
            sql += ", NM_ATOR_COADJUVANTE AS [Ator Coadjuvante]";
            sql += ", AN_IMAGEM_CAPA AS [Imagem da Capa]";
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
                this.txtNomePeca.Text = dados[1];
                this.txtClassificacao.Text = dados[2];
                this.txtAtorPrincipal.Text = dados[3];
                this.txtAtrizPrincipal.Text = dados[4];
                this.txtAtorCoadjuvante.Text = dados[5];

                // Se a informação de sub-diretório e nome do arquivo não é vazio.
                if (dados[6] != String.Empty)
                {
                    // Campo caminho imagem recebe o valor do caminho da aplicação
                    // + o valor do sub-diretório + o nome do arquivo da imagem.
                    this.txtCaminhoImagem.Text = Application.StartupPath + dados[6];

                    FileInfo fi = new FileInfo(this.txtCaminhoImagem.Text);
                    nomeArquivo = fi.Name;

                }
                else
                {
                    // O campo caminho da imagem é inicializado.
                    this.txtCaminhoImagem.Text = dados[6];
                    // Carrega a imagem da Capa Padrão dos recursos do projeto para o controle PictureBox.
                    this.pbImagemCapa.Image = Properties.Resources.CapaPadrao;
                }

                try
                {
                    if (this.txtCaminhoImagem.Text != String.Empty)
                    {
                        // Carrega a imagem no controle PictureBox, pegando o caminho do array dados.
                        this.pbImagemCapa.Image = new Bitmap(this.txtCaminhoImagem.Text);
                    }
                }
                catch(Exception except)
                {
                    MessageBox.Show(null, "Erro ao carregar a imagem.\n\nDetalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Carrega imagem de não encontrado.
                    this.pbImagemCapa.Image = Properties.Resources.ImagemNaoEncontrada;
                }

                // Inicializa o valor de retorno do formulário Lista Registros.
                FrmListaRegistros.RetValores = String.Empty;
            }
        }
    }
}
