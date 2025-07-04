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
    partial class FrmCadSessao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadSessao));
            this.tsPadrao = new System.Windows.Forms.ToolStrip();
            this.tsbtnInicializar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnListarRegistros = new System.Windows.Forms.ToolStripButton();
            this.lblDataSessao = new System.Windows.Forms.Label();
            this.mtbDataSessao = new System.Windows.Forms.MaskedTextBox();
            this.lblCodigoSala = new System.Windows.Forms.Label();
            this.txtCodigoSala = new System.Windows.Forms.TextBox();
            this.btListaRegistroExternaSala = new System.Windows.Forms.Button();
            this.lblQtDispAssento = new System.Windows.Forms.Label();
            this.txtQtDispAssento = new System.Windows.Forms.TextBox();
            this.mtbHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraInicio = new System.Windows.Forms.Label();
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
            this.tsPadrao.Size = new System.Drawing.Size(247, 25);
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
            // lblDataSessao
            // 
            this.lblDataSessao.AutoSize = true;
            this.lblDataSessao.Location = new System.Drawing.Point(12, 43);
            this.lblDataSessao.Name = "lblDataSessao";
            this.lblDataSessao.Size = new System.Drawing.Size(33, 13);
            this.lblDataSessao.TabIndex = 9;
            this.lblDataSessao.Text = "Data:";
            // 
            // mtbDataSessao
            // 
            this.mtbDataSessao.Location = new System.Drawing.Point(106, 40);
            this.mtbDataSessao.Mask = "00/00/0000";
            this.mtbDataSessao.Name = "mtbDataSessao";
            this.mtbDataSessao.Size = new System.Drawing.Size(100, 20);
            this.mtbDataSessao.TabIndex = 10;
            this.mtbDataSessao.ValidatingType = typeof(System.DateTime);
            // 
            // lblCodigoSala
            // 
            this.lblCodigoSala.AutoSize = true;
            this.lblCodigoSala.Location = new System.Drawing.Point(12, 97);
            this.lblCodigoSala.Name = "lblCodigoSala";
            this.lblCodigoSala.Size = new System.Drawing.Size(67, 13);
            this.lblCodigoSala.TabIndex = 13;
            this.lblCodigoSala.Text = "Código Sala:";
            // 
            // txtCodigoSala
            // 
            this.txtCodigoSala.Location = new System.Drawing.Point(106, 92);
            this.txtCodigoSala.Name = "txtCodigoSala";
            this.txtCodigoSala.ReadOnly = true;
            this.txtCodigoSala.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoSala.TabIndex = 14;
            // 
            // btListaRegistroExternaSala
            // 
            this.btListaRegistroExternaSala.Image = global::ControleTeatro.Properties.Resources.application_go;
            this.btListaRegistroExternaSala.Location = new System.Drawing.Point(212, 91);
            this.btListaRegistroExternaSala.Name = "btListaRegistroExternaSala";
            this.btListaRegistroExternaSala.Size = new System.Drawing.Size(25, 23);
            this.btListaRegistroExternaSala.TabIndex = 15;
            this.btListaRegistroExternaSala.UseVisualStyleBackColor = true;
            this.btListaRegistroExternaSala.Click += new System.EventHandler(this.btListaRegistroExternaSala_Click);
            // 
            // lblQtDispAssento
            // 
            this.lblQtDispAssento.AutoSize = true;
            this.lblQtDispAssento.Location = new System.Drawing.Point(12, 121);
            this.lblQtDispAssento.Name = "lblQtDispAssento";
            this.lblQtDispAssento.Size = new System.Drawing.Size(92, 13);
            this.lblQtDispAssento.TabIndex = 16;
            this.lblQtDispAssento.Text = "Qt. Disp. Assento:";
            // 
            // txtQtDispAssento
            // 
            this.txtQtDispAssento.Location = new System.Drawing.Point(106, 118);
            this.txtQtDispAssento.Name = "txtQtDispAssento";
            this.txtQtDispAssento.ReadOnly = true;
            this.txtQtDispAssento.Size = new System.Drawing.Size(100, 20);
            this.txtQtDispAssento.TabIndex = 17;
            // 
            // mtbHoraInicio
            // 
            this.mtbHoraInicio.Location = new System.Drawing.Point(106, 66);
            this.mtbHoraInicio.Mask = "00:00";
            this.mtbHoraInicio.Name = "mtbHoraInicio";
            this.mtbHoraInicio.Size = new System.Drawing.Size(100, 20);
            this.mtbHoraInicio.TabIndex = 12;
            this.mtbHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(12, 69);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(63, 13);
            this.lblHoraInicio.TabIndex = 11;
            this.lblHoraInicio.Text = "Hora Início:";
            // 
            // FrmCadSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 152);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.mtbHoraInicio);
            this.Controls.Add(this.txtQtDispAssento);
            this.Controls.Add(this.lblQtDispAssento);
            this.Controls.Add(this.btListaRegistroExternaSala);
            this.Controls.Add(this.txtCodigoSala);
            this.Controls.Add(this.lblCodigoSala);
            this.Controls.Add(this.mtbDataSessao);
            this.Controls.Add(this.lblDataSessao);
            this.Controls.Add(this.tsPadrao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadSessao";
            this.Text = "Cadastro de Sessão";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadSessao_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadSessao_Load);
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
        private System.Windows.Forms.Label lblDataSessao;
        private System.Windows.Forms.MaskedTextBox mtbDataSessao;
        private System.Windows.Forms.Label lblCodigoSala;
        private System.Windows.Forms.TextBox txtCodigoSala;
        private System.Windows.Forms.Button btListaRegistroExternaSala;
        private System.Windows.Forms.Label lblQtDispAssento;
        private System.Windows.Forms.TextBox txtQtDispAssento;
        private System.Windows.Forms.MaskedTextBox mtbHoraInicio;
        private System.Windows.Forms.Label lblHoraInicio;
    }
}