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
    public partial class FrmPrincipal : Form
    {
        public static FrmListaRegistros frmListaRegistros;
        public static FrmConfigRegionais frmConfigRegionais;
        public static FrmAlterarSenha frmAlterarSenha;
        public static FrmCadUsuario frmCadUsuario;
        public static FrmCadTipoUsuario frmCadTipoUsuario;
        public static FrmCadSala frmCadSala;
        public static FrmCadPecaTeatral frmCadPecaTeatral;
        public static FrmCadClassificacao frmCadClassificacao;
        public static FrmCadTemporada frmCadTemporada;
        public static FrmCadSessao frmCadSessao;
        public static FrmCadAgendSessaoTemporada frmCadAgendSessaoTemporada;
        public static FrmPDV frmPDV;
        public static FrmHistVendas frmHistVendas;
        public static FrmSobre frmSobre;

        /// <summary>
        /// Construtor padrão da classe FrmPrincipal.
        /// </summary>
        public FrmPrincipal()
        {
            // Inicializa os controles deste formulário.
            InitializeComponent();
        }

        /// <summary>
        /// Método para tratar evento ao carregar este formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Exibe o usuário logado no rótulo (label) do statusStrip deste formulário.
            this.tsslUsuario.Text = Program.sessaoUsuario.Nome;

            // Exibe o tipo do usuário que está logado na sessão da aplicação.
            this.tsslTipo.Text = Program.sessaoUsuario.TipoUsuario;

            // Exibe a versão do aplicativo na barra de título.
            this.Text += " - " + Application.ProductVersion;

            // Inicializa o campo da toolBar com o valor da data/hora atual.
            this.tsslDataHoraAtual.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");

            this.tmrFrmPrincipal = new Timer();
            this.tmrFrmPrincipal.Interval = 1000;
            this.tmrFrmPrincipal.Tick += new EventHandler(this.tmrFrmPrincipal_Tick);
            this.tmrFrmPrincipal.Start();
        }

        /// <summary>
        /// Método para tratar o evento ao encerrar este formulário.
        /// Grava na base de dados a data e horário de saída do usuário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sql = String.Empty;

            sql = "UPDATE";
            sql += " USUARIO";
            sql += " SET DTHR_ULT_ACESSO = '" + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + "'";
            sql += " WHERE";
            sql += " CD_USUARIO = '" + Program.sessaoUsuario.Nome + "'";

            try
            {
                using (OleDbCommand update = new OleDbCommand(sql, Dal.conn))
                {
                    update.ExecuteNonQuery();
                }
            }
            catch (OleDbException except)
            {
                MessageBox.Show(null, "Não foi possível executar o comando de atualização.\n\n"
                    + "Detalhes: " + except.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Método que trata o evento de "tique-taque" do controle Timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrFrmPrincipal_Tick(object sender, EventArgs e)
        {
            this.tsslDataHoraAtual.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }


        /// <summary>
        /// Método que trata o evento ao pressionar alguma tecla do teclado.
        /// OBS: A propriedade KeyPreview deste formulário deve estar configurado como true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            // Se o códido da tecla é igual a ESCAPE (ESC)
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult dr;
                dr = MessageBox.Show(null, "Deseja sair do sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Se o resultado do diáglo for não ou nenhum.
                if (dr == DialogResult.No || dr == DialogResult.None)
                {
                    return;
                }

                // Encerra a aplicação.
                Application.Exit();
            }
        }

        /// <summary>
        /// Método para trara o vento clique de mouse no sub-item de menu "Regiao e Idioma (SO)".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regiaoEIdiomaSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmConfigRegionais == null)
            {
                frmConfigRegionais = new FrmConfigRegionais();
                frmConfigRegionais.MdiParent = this;
                frmConfigRegionais.Show();
            }
        }

        /// <summary>
        /// Método para trara o vento clique de mouse no item de menu "Alterar Senha".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Chama formulário de alteração de senha.
            if (frmAlterarSenha == null)
            {
                frmAlterarSenha = new FrmAlterarSenha();
                frmAlterarSenha.MdiParent = this;
                frmAlterarSenha.Show();
            }
        }

        /// <summary>
        /// Método para trara o vento clique de mouse no item de menu "Sair".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Encerra a aplicação.
            Application.Exit();
        }

        // Itens de menu para administração ------------------------------------------

        /// <summary>
        /// Método para trara o vento clique de mouse no item de menu "Usuário".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se o usuário não for do tipo Adminstrador.
            if(Program.sessaoUsuario.TipoUsuario != "ADMIN")
            {
                MessageBox.Show(null, "Você não tem previlégios para acessar o menu: "
                    + this.usuarioToolStripMenuItem.Text
                    + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (frmCadUsuario == null)
            {
                frmCadUsuario = new FrmCadUsuario();
                frmCadUsuario.MdiParent = this;
                frmCadUsuario.Show();
            }
        }

        /// <summary>
        /// Método para trara o vento clique de mouse no item de menu "Tipo de Usuário".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tipoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se o usuário não for do tipo Adminstrador.
            if (Program.sessaoUsuario.TipoUsuario != "ADMIN")
            {
                MessageBox.Show(null, "Você não tem previlégios para acessar o menu: " + this.tipoDeUsuarioToolStripMenuItem.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (frmCadTipoUsuario == null)
            {
                frmCadTipoUsuario = new FrmCadTipoUsuario();
                frmCadTipoUsuario.MdiParent = this;
                frmCadTipoUsuario.Show();
            }
        }
        // ---------------------------------------------------------------------------



        // Itens de menu para usuários normais ---------------------------------------

        /// <summary>
        /// Método para trara o vento clique de mouse no item de menu "Sala".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se o usuário não for do tipo Adminstrador e normal.
            if ((Program.sessaoUsuario.TipoUsuario != "ADMIN") && (Program.sessaoUsuario.TipoUsuario != "NORMAL"))
            {
                MessageBox.Show(null, "Você não tem previlégios para acessar o menu: " + this.salaToolStripMenuItem.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (frmCadSala == null)
            { 
                frmCadSala = new FrmCadSala();
                frmCadSala.MdiParent = this;
                frmCadSala.Show();
            }
        }

        /// <summary>
        /// /// Método para trara o vento clique de mouse no item de menu "Peça".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pecaTeatralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se o usuário não for do tipo Adminstrador e normal.
            if ((Program.sessaoUsuario.TipoUsuario != "ADMIN") && (Program.sessaoUsuario.TipoUsuario != "NORMAL"))
            {
                MessageBox.Show(null, "Você não tem previlégios para acessar o menu: " + this.pecaTeatralToolStripMenuItem.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (frmCadPecaTeatral == null)
            {
                frmCadPecaTeatral = new FrmCadPecaTeatral();
                frmCadPecaTeatral.MdiParent = this;
                frmCadPecaTeatral.Show();
            }
        }

        /// <summary>
        /// Método para trara o vento clique de mouse no item de menu "Classificação".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void classificacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se o usuário não for do tipo Adminstrador.
            if (Program.sessaoUsuario.TipoUsuario != "ADMIN")
            {
                MessageBox.Show(null, "Você não tem previlégios para acessar o menu: " + this.classificacaoToolStripMenuItem.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (frmCadClassificacao == null)
            {
                frmCadClassificacao = new FrmCadClassificacao();
                frmCadClassificacao.MdiParent = this;
                frmCadClassificacao.Show();
            }
        }

        /// <summary>
        /// Método para trara o vento clique de mouse no item de menu "Temporada".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void temporadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se o usuário não for do tipo Adminstrador e normal.
            if ((Program.sessaoUsuario.TipoUsuario != "ADMIN") && (Program.sessaoUsuario.TipoUsuario != "NORMAL"))
            {
                MessageBox.Show(null, "Você não tem previlégios para acessar o menu: " + this.temporadaToolStripMenuItem.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (frmCadTemporada == null)
            {
                frmCadTemporada = new FrmCadTemporada();
                frmCadTemporada.MdiParent = this;
                frmCadTemporada.Show();
            }
        }

        /// <summary>
        /// Método para trara o vento clique de mouse no item de menu "Sessão".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sessaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se o usuário não for do tipo Adminstrador e normal.
            if ((Program.sessaoUsuario.TipoUsuario != "ADMIN") && (Program.sessaoUsuario.TipoUsuario != "NORMAL"))
            {
                MessageBox.Show(null, "Você não tem previlégios para acessar o menu: " + this.sessaoToolStripMenuItem.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(frmCadSessao == null)
            {
                frmCadSessao = new FrmCadSessao();
                frmCadSessao.MdiParent = this;
                frmCadSessao.Show();
            }
        }


        /// <summary>
        /// Método para trara o vento clique de mouse no item de menu "Agendamento Temporada x Sessão".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void agendamentoTemporadatoolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Se o usuário não for do tipo Adminstrador e normal.
            if ((Program.sessaoUsuario.TipoUsuario != "ADMIN") && (Program.sessaoUsuario.TipoUsuario != "NORMAL"))
            {
                MessageBox.Show(null, "Você não tem previlégios para acessar o menu: " + this.agendamentoTemporadatoolStripMenuItem.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (frmCadAgendSessaoTemporada == null)
            {
                frmCadAgendSessaoTemporada = new FrmCadAgendSessaoTemporada();
                frmCadAgendSessaoTemporada.MdiParent = this;
                frmCadAgendSessaoTemporada.Show();
            }
        }
        // ---------------------------------------------------------------------------


        /// <summary>
        /// Método para trara o vento clique de mouse no item de menu "PDV".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se o usuário não for do tipo Adminstrador e vendedor.
            if ((Program.sessaoUsuario.TipoUsuario != "ADMIN") && (Program.sessaoUsuario.TipoUsuario != "VENDEDOR"))
            {
                MessageBox.Show(null, "Você não tem previlégios para acessar o menu: " + this.pdvToolStripMenuItem.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(frmPDV == null)
            {
                frmPDV = new FrmPDV();
                frmPDV.MdiParent = this;
                frmPDV.Show();
            }
        }

        private void historicoDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Se o usuário não for do tipo Adminstrador e vendedor.
            if ((Program.sessaoUsuario.TipoUsuario != "ADMIN") && (Program.sessaoUsuario.TipoUsuario != "VENDEDOR"))
            {
                MessageBox.Show(null, "Você não tem previlégios para acessar o menu: " + this.historicoDeVendasToolStripMenuItem.Text + ".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(frmHistVendas == null)
            {
                frmHistVendas = new FrmHistVendas();
                frmHistVendas.MdiParent = this;
                frmHistVendas.Show();
            }
        
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmSobre == null)
            {
                frmSobre = new FrmSobre();
                frmSobre.MdiParent = this;
                frmSobre.Show();
            }
        }

    }
}
