/* Autor: Misael da Costa Homem.
 * Ano: 2012
 * Cadeira: Linguagem de Programação I
 * Semestre: 3º
 * Turma: ADS3N12/2A
 * Docente: Lizandro Kirts da Silva.
 * Instituição: Faculdade Senac Porto Alegre - RS
 */

namespace ControleTeatro.Views
{
    partial class FrmCadAgendSessaoTemporada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadAgendSessaoTemporada));
            this.tsPadrao = new System.Windows.Forms.ToolStrip();
            this.tsbtnInicializar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnListarRegistros = new System.Windows.Forms.ToolStripButton();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.mtbHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataSessao = new System.Windows.Forms.MaskedTextBox();
            this.lblDataSessao = new System.Windows.Forms.Label();
            this.btListaRegistroExternaSessao = new System.Windows.Forms.Button();
            this.btListaRegistroExternaTemporadaPeca = new System.Windows.Forms.Button();
            this.txtTemporadaPeca = new System.Windows.Forms.TextBox();
            this.lblTemporadaPeca = new System.Windows.Forms.Label();
            this.txtCodigoSala = new System.Windows.Forms.TextBox();
            this.lblCodigoSala = new System.Windows.Forms.Label();
            this.mtbTermino = new System.Windows.Forms.MaskedTextBox();
            this.lblTermino = new System.Windows.Forms.Label();
            this.lblEstreia = new System.Windows.Forms.Label();
            this.mtbEstreia = new System.Windows.Forms.MaskedTextBox();
            this.chbConfExibicao = new System.Windows.Forms.CheckBox();
            this.lblQtDispAssento = new System.Windows.Forms.Label();
            this.txtQtDispAssento = new System.Windows.Forms.TextBox();
            this.lblVlBilhete = new System.Windows.Forms.Label();
            this.txtVlBilhete = new System.Windows.Forms.TextBox();
            this.lblNomePeca = new System.Windows.Forms.Label();
            this.tsPadrao.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsPadrao
            // 
            this.tsPadrao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnInicializar,
            this.tsbtnGravar,
            this.tsbtnExcluir,
            this.toolStripSeparator1,
            this.tsbtnListarRegistros});
            this.tsPadrao.Location = new System.Drawing.Point(0, 0);
            this.tsPadrao.Name = "tsPadrao";
            this.tsPadrao.Size = new System.Drawing.Size(501, 25);
            this.tsPadrao.TabIndex = 1;
            this.tsPadrao.Text = "toolStrip1";
            // 
            // tsbtnInicializar
            // 
            this.tsbtnInicializar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnInicializar.Image = global::ControleTeatro.Properties.Resources.page_white;
            this.tsbtnInicializar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInicializar.Name = "tsbtnInicializar";
            this.tsbtnInicializar.Size = new System.Drawing.Size(23, 22);
            this.tsbtnInicializar.Text = "Inicializar";
            this.tsbtnInicializar.Click += new System.EventHandler(this.tsbtnInicializar_Click);
            // 
            // tsbtnGravar
            // 
            this.tsbtnGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnGravar.Image = global::ControleTeatro.Properties.Resources.disk;
            this.tsbtnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGravar.Name = "tsbtnGravar";
            this.tsbtnGravar.Size = new System.Drawing.Size(23, 22);
            this.tsbtnGravar.Text = "Gravar";
            this.tsbtnGravar.Click += new System.EventHandler(this.tsbtnGravar_Click);
            // 
            // tsbtnExcluir
            // 
            this.tsbtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnExcluir.Image = global::ControleTeatro.Properties.Resources.cross;
            this.tsbtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExcluir.Name = "tsbtnExcluir";
            this.tsbtnExcluir.Size = new System.Drawing.Size(23, 22);
            this.tsbtnExcluir.Text = "Excluir";
            this.tsbtnExcluir.Click += new System.EventHandler(this.tsbtnExcluir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnListarRegistros
            // 
            this.tsbtnListarRegistros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnListarRegistros.Image = global::ControleTeatro.Properties.Resources.application_view_list;
            this.tsbtnListarRegistros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnListarRegistros.Name = "tsbtnListarRegistros";
            this.tsbtnListarRegistros.Size = new System.Drawing.Size(23, 22);
            this.tsbtnListarRegistros.Text = "Listar Registros";
            this.tsbtnListarRegistros.Click += new System.EventHandler(this.tsbtnListarRegistros_Click);
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(12, 69);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(63, 13);
            this.lblHoraInicio.TabIndex = 5;
            this.lblHoraInicio.Text = "Hora Início:";
            // 
            // mtbHoraInicio
            // 
            this.mtbHoraInicio.Location = new System.Drawing.Point(133, 66);
            this.mtbHoraInicio.Mask = "00:00";
            this.mtbHoraInicio.Name = "mtbHoraInicio";
            this.mtbHoraInicio.ReadOnly = true;
            this.mtbHoraInicio.Size = new System.Drawing.Size(100, 20);
            this.mtbHoraInicio.TabIndex = 6;
            this.mtbHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDataSessao
            // 
            this.mtbDataSessao.Location = new System.Drawing.Point(133, 40);
            this.mtbDataSessao.Mask = "00/00/0000";
            this.mtbDataSessao.Name = "mtbDataSessao";
            this.mtbDataSessao.ReadOnly = true;
            this.mtbDataSessao.Size = new System.Drawing.Size(100, 20);
            this.mtbDataSessao.TabIndex = 3;
            this.mtbDataSessao.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataSessao
            // 
            this.lblDataSessao.AutoSize = true;
            this.lblDataSessao.Location = new System.Drawing.Point(12, 43);
            this.lblDataSessao.Name = "lblDataSessao";
            this.lblDataSessao.Size = new System.Drawing.Size(33, 13);
            this.lblDataSessao.TabIndex = 2;
            this.lblDataSessao.Text = "Data:";
            // 
            // btListaRegistroExternaSessao
            // 
            this.btListaRegistroExternaSessao.Image = global::ControleTeatro.Properties.Resources.application_go;
            this.btListaRegistroExternaSessao.Location = new System.Drawing.Point(239, 38);
            this.btListaRegistroExternaSessao.Name = "btListaRegistroExternaSessao";
            this.btListaRegistroExternaSessao.Size = new System.Drawing.Size(25, 23);
            this.btListaRegistroExternaSessao.TabIndex = 4;
            this.btListaRegistroExternaSessao.UseVisualStyleBackColor = true;
            this.btListaRegistroExternaSessao.Click += new System.EventHandler(this.btListaRegistroExternaSessao_Click);
            // 
            // btListaRegistroExternaTemporadaPeca
            // 
            this.btListaRegistroExternaTemporadaPeca.Image = global::ControleTeatro.Properties.Resources.application_go;
            this.btListaRegistroExternaTemporadaPeca.Location = new System.Drawing.Point(239, 142);
            this.btListaRegistroExternaTemporadaPeca.Name = "btListaRegistroExternaTemporadaPeca";
            this.btListaRegistroExternaTemporadaPeca.Size = new System.Drawing.Size(25, 23);
            this.btListaRegistroExternaTemporadaPeca.TabIndex = 13;
            this.btListaRegistroExternaTemporadaPeca.UseVisualStyleBackColor = true;
            this.btListaRegistroExternaTemporadaPeca.Click += new System.EventHandler(this.btListaRegistroExternaTemporadaPeca_Click);
            // 
            // txtTemporadaPeca
            // 
            this.txtTemporadaPeca.Location = new System.Drawing.Point(133, 144);
            this.txtTemporadaPeca.MaxLength = 10;
            this.txtTemporadaPeca.Name = "txtTemporadaPeca";
            this.txtTemporadaPeca.ReadOnly = true;
            this.txtTemporadaPeca.Size = new System.Drawing.Size(100, 20);
            this.txtTemporadaPeca.TabIndex = 12;
            // 
            // lblTemporadaPeca
            // 
            this.lblTemporadaPeca.AutoSize = true;
            this.lblTemporadaPeca.Location = new System.Drawing.Point(12, 147);
            this.lblTemporadaPeca.Name = "lblTemporadaPeca";
            this.lblTemporadaPeca.Size = new System.Drawing.Size(107, 13);
            this.lblTemporadaPeca.TabIndex = 11;
            this.lblTemporadaPeca.Text = "Temporada da Peça:";
            // 
            // txtCodigoSala
            // 
            this.txtCodigoSala.Location = new System.Drawing.Point(133, 92);
            this.txtCodigoSala.Name = "txtCodigoSala";
            this.txtCodigoSala.ReadOnly = true;
            this.txtCodigoSala.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoSala.TabIndex = 8;
            // 
            // lblCodigoSala
            // 
            this.lblCodigoSala.AutoSize = true;
            this.lblCodigoSala.Location = new System.Drawing.Point(12, 95);
            this.lblCodigoSala.Name = "lblCodigoSala";
            this.lblCodigoSala.Size = new System.Drawing.Size(67, 13);
            this.lblCodigoSala.TabIndex = 7;
            this.lblCodigoSala.Text = "Código Sala:";
            // 
            // mtbTermino
            // 
            this.mtbTermino.Location = new System.Drawing.Point(133, 196);
            this.mtbTermino.Mask = "00/00/0000";
            this.mtbTermino.Name = "mtbTermino";
            this.mtbTermino.ReadOnly = true;
            this.mtbTermino.Size = new System.Drawing.Size(100, 20);
            this.mtbTermino.TabIndex = 17;
            this.mtbTermino.ValidatingType = typeof(System.DateTime);
            // 
            // lblTermino
            // 
            this.lblTermino.AutoSize = true;
            this.lblTermino.Location = new System.Drawing.Point(12, 199);
            this.lblTermino.Name = "lblTermino";
            this.lblTermino.Size = new System.Drawing.Size(74, 13);
            this.lblTermino.TabIndex = 16;
            this.lblTermino.Text = "Data Término:";
            // 
            // lblEstreia
            // 
            this.lblEstreia.AutoSize = true;
            this.lblEstreia.Location = new System.Drawing.Point(12, 173);
            this.lblEstreia.Name = "lblEstreia";
            this.lblEstreia.Size = new System.Drawing.Size(68, 13);
            this.lblEstreia.TabIndex = 14;
            this.lblEstreia.Text = "Data Estréia:";
            // 
            // mtbEstreia
            // 
            this.mtbEstreia.Location = new System.Drawing.Point(133, 170);
            this.mtbEstreia.Mask = "00/00/0000";
            this.mtbEstreia.Name = "mtbEstreia";
            this.mtbEstreia.ReadOnly = true;
            this.mtbEstreia.Size = new System.Drawing.Size(100, 20);
            this.mtbEstreia.TabIndex = 15;
            this.mtbEstreia.ValidatingType = typeof(System.DateTime);
            // 
            // chbConfExibicao
            // 
            this.chbConfExibicao.AutoSize = true;
            this.chbConfExibicao.Location = new System.Drawing.Point(12, 222);
            this.chbConfExibicao.Name = "chbConfExibicao";
            this.chbConfExibicao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbConfExibicao.Size = new System.Drawing.Size(136, 17);
            this.chbConfExibicao.TabIndex = 18;
            this.chbConfExibicao.Text = "Confirmar para exibição";
            this.chbConfExibicao.UseVisualStyleBackColor = true;
            // 
            // lblQtDispAssento
            // 
            this.lblQtDispAssento.AutoSize = true;
            this.lblQtDispAssento.Location = new System.Drawing.Point(12, 121);
            this.lblQtDispAssento.Name = "lblQtDispAssento";
            this.lblQtDispAssento.Size = new System.Drawing.Size(92, 13);
            this.lblQtDispAssento.TabIndex = 9;
            this.lblQtDispAssento.Text = "Qt. Disp. Assento:";
            // 
            // txtQtDispAssento
            // 
            this.txtQtDispAssento.Location = new System.Drawing.Point(133, 118);
            this.txtQtDispAssento.Name = "txtQtDispAssento";
            this.txtQtDispAssento.ReadOnly = true;
            this.txtQtDispAssento.Size = new System.Drawing.Size(100, 20);
            this.txtQtDispAssento.TabIndex = 10;
            // 
            // lblVlBilhete
            // 
            this.lblVlBilhete.AutoSize = true;
            this.lblVlBilhete.Location = new System.Drawing.Point(12, 248);
            this.lblVlBilhete.Name = "lblVlBilhete";
            this.lblVlBilhete.Size = new System.Drawing.Size(68, 13);
            this.lblVlBilhete.TabIndex = 19;
            this.lblVlBilhete.Text = "Valor bilhete:";
            // 
            // txtVlBilhete
            // 
            this.txtVlBilhete.Location = new System.Drawing.Point(133, 245);
            this.txtVlBilhete.MaxLength = 10;
            this.txtVlBilhete.Name = "txtVlBilhete";
            this.txtVlBilhete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtVlBilhete.Size = new System.Drawing.Size(100, 20);
            this.txtVlBilhete.TabIndex = 20;
            this.txtVlBilhete.Text = "0,00";
            this.txtVlBilhete.Enter += new System.EventHandler(this.txtVlBilhete_Enter);
            this.txtVlBilhete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlBilhete_KeyPress);
            this.txtVlBilhete.Leave += new System.EventHandler(this.txtVlBilhete_Leave);
            // 
            // lblNomePeca
            // 
            this.lblNomePeca.AutoSize = true;
            this.lblNomePeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePeca.ForeColor = System.Drawing.Color.Blue;
            this.lblNomePeca.Location = new System.Drawing.Point(270, 147);
            this.lblNomePeca.Name = "lblNomePeca";
            this.lblNomePeca.Size = new System.Drawing.Size(19, 13);
            this.lblNomePeca.TabIndex = 21;
            this.lblNomePeca.Text = "...";
            // 
            // FrmCadAgendSessaoTemporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 276);
            this.Controls.Add(this.lblNomePeca);
            this.Controls.Add(this.txtVlBilhete);
            this.Controls.Add(this.lblVlBilhete);
            this.Controls.Add(this.txtQtDispAssento);
            this.Controls.Add(this.lblQtDispAssento);
            this.Controls.Add(this.chbConfExibicao);
            this.Controls.Add(this.txtCodigoSala);
            this.Controls.Add(this.lblCodigoSala);
            this.Controls.Add(this.mtbTermino);
            this.Controls.Add(this.mtbEstreia);
            this.Controls.Add(this.lblTermino);
            this.Controls.Add(this.lblEstreia);
            this.Controls.Add(this.btListaRegistroExternaTemporadaPeca);
            this.Controls.Add(this.txtTemporadaPeca);
            this.Controls.Add(this.lblTemporadaPeca);
            this.Controls.Add(this.btListaRegistroExternaSessao);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.mtbHoraInicio);
            this.Controls.Add(this.mtbDataSessao);
            this.Controls.Add(this.lblDataSessao);
            this.Controls.Add(this.tsPadrao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadAgendSessaoTemporada";
            this.Text = "Agendamento de Sessão x Temporada ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadAgendTemporadaSessao_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadAgendSessaoTemporada_Load);
            this.tsPadrao.ResumeLayout(false);
            this.tsPadrao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPadrao;
        private System.Windows.Forms.ToolStripButton tsbtnInicializar;
        private System.Windows.Forms.ToolStripButton tsbtnGravar;
        private System.Windows.Forms.ToolStripButton tsbtnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnListarRegistros;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.MaskedTextBox mtbHoraInicio;
        private System.Windows.Forms.MaskedTextBox mtbDataSessao;
        private System.Windows.Forms.Label lblDataSessao;
        private System.Windows.Forms.Button btListaRegistroExternaSessao;
        private System.Windows.Forms.Button btListaRegistroExternaTemporadaPeca;
        private System.Windows.Forms.TextBox txtTemporadaPeca;
        private System.Windows.Forms.Label lblTemporadaPeca;
        private System.Windows.Forms.TextBox txtCodigoSala;
        private System.Windows.Forms.Label lblCodigoSala;
        private System.Windows.Forms.MaskedTextBox mtbTermino;
        private System.Windows.Forms.Label lblTermino;
        private System.Windows.Forms.Label lblEstreia;
        private System.Windows.Forms.MaskedTextBox mtbEstreia;
        private System.Windows.Forms.CheckBox chbConfExibicao;
        private System.Windows.Forms.Label lblQtDispAssento;
        private System.Windows.Forms.TextBox txtQtDispAssento;
        private System.Windows.Forms.Label lblVlBilhete;
        private System.Windows.Forms.TextBox txtVlBilhete;
        private System.Windows.Forms.Label lblNomePeca;
    }
}