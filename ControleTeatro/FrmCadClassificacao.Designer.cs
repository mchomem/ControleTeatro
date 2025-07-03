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
    partial class FrmCadClassificacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadClassificacao));
            this.tsPadrao = new System.Windows.Forms.ToolStrip();
            this.tsbtnInicializar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnListarRegistros = new System.Windows.Forms.ToolStripButton();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescDetalhada = new System.Windows.Forms.Label();
            this.txtDescDetalhada = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblObsInfo01 = new System.Windows.Forms.Label();
            this.lblObsInfo02 = new System.Windows.Forms.Label();
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
            this.tsPadrao.Size = new System.Drawing.Size(574, 25);
            this.tsPadrao.TabIndex = 2;
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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 43);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(107, 40);
            this.txtCodigo.MaxLength = 15;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 69);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(107, 66);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(455, 33);
            this.txtDescricao.TabIndex = 6;
            // 
            // lblDescDetalhada
            // 
            this.lblDescDetalhada.AutoSize = true;
            this.lblDescDetalhada.Location = new System.Drawing.Point(12, 111);
            this.lblDescDetalhada.Name = "lblDescDetalhada";
            this.lblDescDetalhada.Size = new System.Drawing.Size(90, 13);
            this.lblDescDetalhada.TabIndex = 7;
            this.lblDescDetalhada.Text = "Desc. Detalhada:";
            // 
            // txtDescDetalhada
            // 
            this.txtDescDetalhada.Location = new System.Drawing.Point(107, 105);
            this.txtDescDetalhada.Multiline = true;
            this.txtDescDetalhada.Name = "txtDescDetalhada";
            this.txtDescDetalhada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescDetalhada.Size = new System.Drawing.Size(455, 106);
            this.txtDescDetalhada.TabIndex = 8;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.ForeColor = System.Drawing.Color.Blue;
            this.lblObs.Location = new System.Drawing.Point(12, 235);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(32, 13);
            this.lblObs.TabIndex = 9;
            this.lblObs.Text = "OBS:";
            // 
            // lblObsInfo01
            // 
            this.lblObsInfo01.AutoSize = true;
            this.lblObsInfo01.Location = new System.Drawing.Point(104, 235);
            this.lblObsInfo01.Name = "lblObsInfo01";
            this.lblObsInfo01.Size = new System.Drawing.Size(464, 13);
            this.lblObsInfo01.TabIndex = 10;
            this.lblObsInfo01.Text = "Classificações conforme DEJUS (Departamento de Justiça, Classificação, Títulos e " +
                "Qualificação)";
            // 
            // lblObsInfo02
            // 
            this.lblObsInfo02.AutoSize = true;
            this.lblObsInfo02.Location = new System.Drawing.Point(104, 253);
            this.lblObsInfo02.Name = "lblObsInfo02";
            this.lblObsInfo02.Size = new System.Drawing.Size(308, 13);
            this.lblObsInfo02.TabIndex = 11;
            this.lblObsInfo02.Text = "De acordo com a PORTARIA nº 1.220, de 11 de julho de 2007.";
            // 
            // FrmCadClassificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 276);
            this.Controls.Add(this.lblObsInfo02);
            this.Controls.Add(this.lblObsInfo01);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.txtDescDetalhada);
            this.Controls.Add(this.lblDescDetalhada);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.tsPadrao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadClassificacao";
            this.Text = "Cadastro de Classificação (Peças de Teatro)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadClassificacao_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadClassificacao_Load);
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
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescDetalhada;
        private System.Windows.Forms.TextBox txtDescDetalhada;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblObsInfo01;
        private System.Windows.Forms.Label lblObsInfo02;
    }
}