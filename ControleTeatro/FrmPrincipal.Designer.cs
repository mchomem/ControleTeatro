/* Autor: Misael da Costa Homem.
 * Ano: 2012
 * Cadeira: Linguagem de Programação I
 * Semestre: 3º
 * Turma: ADS3N12/2A
 * Docente: Lizandro Kirts da Silva.
 * Instituição: Faculdade Senac Porto Alegre - RS
 */

namespace ControleTeatro
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regiaoEIdiomaSOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pecaTeatralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temporadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoTemporadatoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaDeIngressosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.historicoDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssFrmPrincipal = new System.Windows.Forms.StatusStrip();
            this.tsslUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTipoUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTipo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDataHoraAtual = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrFrmPrincipal = new System.Windows.Forms.Timer(this.components);
            this.msPrincipal.SuspendLayout();
            this.ssFrmPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.administrativoToolStripMenuItem,
            this.vendaDeIngressosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(692, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracoesToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // configuracoesToolStripMenuItem
            // 
            this.configuracoesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regiaoEIdiomaSOToolStripMenuItem});
            this.configuracoesToolStripMenuItem.Name = "configuracoesToolStripMenuItem";
            this.configuracoesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.configuracoesToolStripMenuItem.Text = "Configurações";
            // 
            // regiaoEIdiomaSOToolStripMenuItem
            // 
            this.regiaoEIdiomaSOToolStripMenuItem.Name = "regiaoEIdiomaSOToolStripMenuItem";
            this.regiaoEIdiomaSOToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.regiaoEIdiomaSOToolStripMenuItem.Text = "Região e Idioma (SO)";
            this.regiaoEIdiomaSOToolStripMenuItem.Click += new System.EventHandler(this.regiaoEIdiomaSOToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeyDisplayString = "Esc";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            this.administrativoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.administrativoToolStripMenuItem.Text = "Administrativo";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.tipoDeUsuarioToolStripMenuItem,
            this.toolStripSeparator1,
            this.salaToolStripMenuItem,
            this.pecaTeatralToolStripMenuItem,
            this.classificacaoToolStripMenuItem,
            this.temporadaToolStripMenuItem,
            this.sessaoToolStripMenuItem,
            this.agendamentoTemporadatoolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.usuarioToolStripMenuItem.Text = "Usuário";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // tipoDeUsuarioToolStripMenuItem
            // 
            this.tipoDeUsuarioToolStripMenuItem.Name = "tipoDeUsuarioToolStripMenuItem";
            this.tipoDeUsuarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.T)));
            this.tipoDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.tipoDeUsuarioToolStripMenuItem.Text = "Tipo de Usuário";
            this.tipoDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.tipoDeUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            this.salaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.salaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.salaToolStripMenuItem.Text = "Sala";
            this.salaToolStripMenuItem.Click += new System.EventHandler(this.salaToolStripMenuItem_Click);
            // 
            // pecaTeatralToolStripMenuItem
            // 
            this.pecaTeatralToolStripMenuItem.Name = "pecaTeatralToolStripMenuItem";
            this.pecaTeatralToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.pecaTeatralToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.pecaTeatralToolStripMenuItem.Text = "Peça Teatral";
            this.pecaTeatralToolStripMenuItem.Click += new System.EventHandler(this.pecaTeatralToolStripMenuItem_Click);
            // 
            // classificacaoToolStripMenuItem
            // 
            this.classificacaoToolStripMenuItem.Name = "classificacaoToolStripMenuItem";
            this.classificacaoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.classificacaoToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.classificacaoToolStripMenuItem.Text = "Classificação";
            this.classificacaoToolStripMenuItem.Click += new System.EventHandler(this.classificacaoToolStripMenuItem_Click);
            // 
            // temporadaToolStripMenuItem
            // 
            this.temporadaToolStripMenuItem.Name = "temporadaToolStripMenuItem";
            this.temporadaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.temporadaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.temporadaToolStripMenuItem.Text = "Temporada";
            this.temporadaToolStripMenuItem.Click += new System.EventHandler(this.temporadaToolStripMenuItem_Click);
            // 
            // sessaoToolStripMenuItem
            // 
            this.sessaoToolStripMenuItem.Name = "sessaoToolStripMenuItem";
            this.sessaoToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.sessaoToolStripMenuItem.Text = "Sessão";
            this.sessaoToolStripMenuItem.Click += new System.EventHandler(this.sessaoToolStripMenuItem_Click);
            // 
            // agendamentoTemporadatoolStripMenuItem
            // 
            this.agendamentoTemporadatoolStripMenuItem.Name = "agendamentoTemporadatoolStripMenuItem";
            this.agendamentoTemporadatoolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.agendamentoTemporadatoolStripMenuItem.Text = "Agendamento Temporada x Sessão";
            this.agendamentoTemporadatoolStripMenuItem.Click += new System.EventHandler(this.agendamentoTemporadatoolStripMenuItem_Click);
            // 
            // vendaDeIngressosToolStripMenuItem
            // 
            this.vendaDeIngressosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pdvToolStripMenuItem,
            this.toolStripMenuItem2,
            this.historicoDeVendasToolStripMenuItem});
            this.vendaDeIngressosToolStripMenuItem.Name = "vendaDeIngressosToolStripMenuItem";
            this.vendaDeIngressosToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.vendaDeIngressosToolStripMenuItem.Text = "Venda de Ingressos";
            // 
            // pdvToolStripMenuItem
            // 
            this.pdvToolStripMenuItem.Name = "pdvToolStripMenuItem";
            this.pdvToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.pdvToolStripMenuItem.Text = "PDV";
            this.pdvToolStripMenuItem.Click += new System.EventHandler(this.pdvToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 6);
            // 
            // historicoDeVendasToolStripMenuItem
            // 
            this.historicoDeVendasToolStripMenuItem.Name = "historicoDeVendasToolStripMenuItem";
            this.historicoDeVendasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.historicoDeVendasToolStripMenuItem.Text = "Histórico de Vendas";
            this.historicoDeVendasToolStripMenuItem.Click += new System.EventHandler(this.historicoDeVendasToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // ssFrmPrincipal
            // 
            this.ssFrmPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUsuarioLogado,
            this.tsslUsuario,
            this.tsslTipoUsuario,
            this.tsslTipo,
            this.tsslDataHora,
            this.tsslDataHoraAtual});
            this.ssFrmPrincipal.Location = new System.Drawing.Point(0, 444);
            this.ssFrmPrincipal.Name = "ssFrmPrincipal";
            this.ssFrmPrincipal.Size = new System.Drawing.Size(692, 22);
            this.ssFrmPrincipal.TabIndex = 2;
            this.ssFrmPrincipal.Text = "statusStrip1";
            // 
            // tsslUsuarioLogado
            // 
            this.tsslUsuarioLogado.Name = "tsslUsuarioLogado";
            this.tsslUsuarioLogado.Size = new System.Drawing.Size(90, 17);
            this.tsslUsuarioLogado.Text = "Usuário logado:";
            // 
            // tsslUsuario
            // 
            this.tsslUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsslUsuario.ForeColor = System.Drawing.Color.Blue;
            this.tsslUsuario.Name = "tsslUsuario";
            this.tsslUsuario.Size = new System.Drawing.Size(16, 17);
            this.tsslUsuario.Text = "...";
            // 
            // tsslTipoUsuario
            // 
            this.tsslTipoUsuario.Name = "tsslTipoUsuario";
            this.tsslTipoUsuario.Size = new System.Drawing.Size(34, 17);
            this.tsslTipoUsuario.Text = "Tipo:";
            // 
            // tsslTipo
            // 
            this.tsslTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsslTipo.ForeColor = System.Drawing.Color.Blue;
            this.tsslTipo.Name = "tsslTipo";
            this.tsslTipo.Size = new System.Drawing.Size(16, 17);
            this.tsslTipo.Text = "...";
            // 
            // tsslDataHora
            // 
            this.tsslDataHora.Name = "tsslDataHora";
            this.tsslDataHora.Size = new System.Drawing.Size(63, 17);
            this.tsslDataHora.Text = "Data/hora:";
            // 
            // tsslDataHoraAtual
            // 
            this.tsslDataHoraAtual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsslDataHoraAtual.ForeColor = System.Drawing.Color.Blue;
            this.tsslDataHoraAtual.Name = "tsslDataHoraAtual";
            this.tsslDataHoraAtual.Size = new System.Drawing.Size(124, 17);
            this.tsslDataHoraAtual.Text = "00/00/0000 00:00:00";
            // 
            // tmrFrmPrincipal
            // 
            this.tmrFrmPrincipal.Tick += new System.EventHandler(this.tmrFrmPrincipal_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(692, 466);
            this.Controls.Add(this.ssFrmPrincipal);
            this.Controls.Add(this.msPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Teatro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipal_KeyDown);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ssFrmPrincipal.ResumeLayout(false);
            this.ssFrmPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssFrmPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuarioLogado;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsslDataHora;
        private System.Windows.Forms.ToolStripStatusLabel tsslDataHoraAtual;
        private System.Windows.Forms.Timer tmrFrmPrincipal;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pecaTeatralToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem classificacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temporadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslTipoUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsslTipo;
        private System.Windows.Forms.ToolStripMenuItem sessaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoTemporadatoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regiaoEIdiomaSOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaDeIngressosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdvToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem historicoDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}