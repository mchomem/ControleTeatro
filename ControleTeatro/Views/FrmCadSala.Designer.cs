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
    partial class FrmCadSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadSala));
            this.tsPadrao = new System.Windows.Forms.ToolStrip();
            this.tsbtnInicializar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnListarRegistros = new System.Windows.Forms.ToolStripButton();
            this.lblCodigoSala = new System.Windows.Forms.Label();
            this.txtCodigoSala = new System.Windows.Forms.TextBox();
            this.lblDescricaoSala = new System.Windows.Forms.Label();
            this.txtDescricaoSala = new System.Windows.Forms.TextBox();
            this.lblQtMaxAssento = new System.Windows.Forms.Label();
            this.txtQtMaxAssento = new System.Windows.Forms.TextBox();
            this.cbManutencao = new System.Windows.Forms.CheckBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtOBS = new System.Windows.Forms.TextBox();
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
            this.tsPadrao.Size = new System.Drawing.Size(389, 25);
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
            // lblCodigoSala
            // 
            this.lblCodigoSala.AutoSize = true;
            this.lblCodigoSala.Location = new System.Drawing.Point(12, 43);
            this.lblCodigoSala.Name = "lblCodigoSala";
            this.lblCodigoSala.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoSala.TabIndex = 2;
            this.lblCodigoSala.Text = "Código:";
            // 
            // txtCodigoSala
            // 
            this.txtCodigoSala.Location = new System.Drawing.Point(127, 40);
            this.txtCodigoSala.MaxLength = 10;
            this.txtCodigoSala.Name = "txtCodigoSala";
            this.txtCodigoSala.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoSala.TabIndex = 3;
            // 
            // lblDescricaoSala
            // 
            this.lblDescricaoSala.AutoSize = true;
            this.lblDescricaoSala.Location = new System.Drawing.Point(12, 69);
            this.lblDescricaoSala.Name = "lblDescricaoSala";
            this.lblDescricaoSala.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoSala.TabIndex = 4;
            this.lblDescricaoSala.Text = "Descrição:";
            // 
            // txtDescricaoSala
            // 
            this.txtDescricaoSala.Location = new System.Drawing.Point(127, 66);
            this.txtDescricaoSala.MaxLength = 50;
            this.txtDescricaoSala.Name = "txtDescricaoSala";
            this.txtDescricaoSala.Size = new System.Drawing.Size(250, 20);
            this.txtDescricaoSala.TabIndex = 5;
            // 
            // lblQtMaxAssento
            // 
            this.lblQtMaxAssento.AutoSize = true;
            this.lblQtMaxAssento.Location = new System.Drawing.Point(12, 95);
            this.lblQtMaxAssento.Name = "lblQtMaxAssento";
            this.lblQtMaxAssento.Size = new System.Drawing.Size(109, 13);
            this.lblQtMaxAssento.TabIndex = 6;
            this.lblQtMaxAssento.Text = "Qt. Máximo Assentos:";
            // 
            // txtQtMaxAssento
            // 
            this.txtQtMaxAssento.Location = new System.Drawing.Point(127, 92);
            this.txtQtMaxAssento.Name = "txtQtMaxAssento";
            this.txtQtMaxAssento.Size = new System.Drawing.Size(49, 20);
            this.txtQtMaxAssento.TabIndex = 7;
            // 
            // cbManutencao
            // 
            this.cbManutencao.AutoSize = true;
            this.cbManutencao.Location = new System.Drawing.Point(12, 118);
            this.cbManutencao.Name = "cbManutencao";
            this.cbManutencao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbManutencao.Size = new System.Drawing.Size(129, 17);
            this.cbManutencao.TabIndex = 8;
            this.cbManutencao.Text = "Sala em manutenção ";
            this.cbManutencao.UseVisualStyleBackColor = true;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(12, 148);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(68, 13);
            this.lblObs.TabIndex = 9;
            this.lblObs.Text = "Obervações:";
            this.lblObs.Click += new System.EventHandler(this.lblObs_Click);
            // 
            // txtOBS
            // 
            this.txtOBS.Location = new System.Drawing.Point(127, 141);
            this.txtOBS.MaxLength = 255;
            this.txtOBS.Multiline = true;
            this.txtOBS.Name = "txtOBS";
            this.txtOBS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOBS.Size = new System.Drawing.Size(250, 85);
            this.txtOBS.TabIndex = 10;
            // 
            // FrmCadSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 238);
            this.Controls.Add(this.txtOBS);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.cbManutencao);
            this.Controls.Add(this.txtQtMaxAssento);
            this.Controls.Add(this.lblQtMaxAssento);
            this.Controls.Add(this.txtDescricaoSala);
            this.Controls.Add(this.lblDescricaoSala);
            this.Controls.Add(this.txtCodigoSala);
            this.Controls.Add(this.lblCodigoSala);
            this.Controls.Add(this.tsPadrao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadSala";
            this.Text = "Cadastro de Sala";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadSala_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadSala_Load);
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
        private System.Windows.Forms.Label lblCodigoSala;
        private System.Windows.Forms.TextBox txtCodigoSala;
        private System.Windows.Forms.Label lblDescricaoSala;
        private System.Windows.Forms.TextBox txtDescricaoSala;
        private System.Windows.Forms.Label lblQtMaxAssento;
        private System.Windows.Forms.TextBox txtQtMaxAssento;
        private System.Windows.Forms.CheckBox cbManutencao;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtOBS;


    }
}