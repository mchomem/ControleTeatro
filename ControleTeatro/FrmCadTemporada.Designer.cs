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
    partial class FrmCadTemporada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadTemporada));
            this.tsPadrao = new System.Windows.Forms.ToolStrip();
            this.tsbtnInicializar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnListarRegistros = new System.Windows.Forms.ToolStripButton();
            this.lblCodigoPeca = new System.Windows.Forms.Label();
            this.txtCodigoPeca = new System.Windows.Forms.TextBox();
            this.btListaRegistroExterna = new System.Windows.Forms.Button();
            this.lblEstreia = new System.Windows.Forms.Label();
            this.lblTermino = new System.Windows.Forms.Label();
            this.mtbEstreia = new System.Windows.Forms.MaskedTextBox();
            this.mtbTermino = new System.Windows.Forms.MaskedTextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs1 = new System.Windows.Forms.Label();
            this.lblObsInfo01 = new System.Windows.Forms.Label();
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
            this.tsPadrao.Size = new System.Drawing.Size(475, 25);
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
            // lblCodigoPeca
            // 
            this.lblCodigoPeca.AutoSize = true;
            this.lblCodigoPeca.Location = new System.Drawing.Point(12, 43);
            this.lblCodigoPeca.Name = "lblCodigoPeca";
            this.lblCodigoPeca.Size = new System.Drawing.Size(71, 13);
            this.lblCodigoPeca.TabIndex = 2;
            this.lblCodigoPeca.Text = "Peça Teatral:";
            // 
            // txtCodigoPeca
            // 
            this.txtCodigoPeca.Location = new System.Drawing.Point(89, 40);
            this.txtCodigoPeca.MaxLength = 10;
            this.txtCodigoPeca.Name = "txtCodigoPeca";
            this.txtCodigoPeca.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPeca.TabIndex = 3;
            // 
            // btListaRegistroExterna
            // 
            this.btListaRegistroExterna.Image = global::ControleTeatro.Properties.Resources.application_go;
            this.btListaRegistroExterna.Location = new System.Drawing.Point(195, 38);
            this.btListaRegistroExterna.Name = "btListaRegistroExterna";
            this.btListaRegistroExterna.Size = new System.Drawing.Size(25, 23);
            this.btListaRegistroExterna.TabIndex = 4;
            this.btListaRegistroExterna.UseVisualStyleBackColor = true;
            this.btListaRegistroExterna.Click += new System.EventHandler(this.btListaRegistroExterna_Click);
            // 
            // lblEstreia
            // 
            this.lblEstreia.AutoSize = true;
            this.lblEstreia.Location = new System.Drawing.Point(12, 69);
            this.lblEstreia.Name = "lblEstreia";
            this.lblEstreia.Size = new System.Drawing.Size(68, 13);
            this.lblEstreia.TabIndex = 5;
            this.lblEstreia.Text = "Data Estréia:";
            // 
            // lblTermino
            // 
            this.lblTermino.AutoSize = true;
            this.lblTermino.Location = new System.Drawing.Point(12, 95);
            this.lblTermino.Name = "lblTermino";
            this.lblTermino.Size = new System.Drawing.Size(74, 13);
            this.lblTermino.TabIndex = 7;
            this.lblTermino.Text = "Data Término:";
            // 
            // mtbEstreia
            // 
            this.mtbEstreia.Location = new System.Drawing.Point(89, 66);
            this.mtbEstreia.Mask = "00/00/0000";
            this.mtbEstreia.Name = "mtbEstreia";
            this.mtbEstreia.Size = new System.Drawing.Size(100, 20);
            this.mtbEstreia.TabIndex = 9;
            this.mtbEstreia.ValidatingType = typeof(System.DateTime);
            // 
            // mtbTermino
            // 
            this.mtbTermino.Location = new System.Drawing.Point(89, 92);
            this.mtbTermino.Mask = "00/00/0000";
            this.mtbTermino.Name = "mtbTermino";
            this.mtbTermino.Size = new System.Drawing.Size(100, 20);
            this.mtbTermino.TabIndex = 10;
            this.mtbTermino.ValidatingType = typeof(System.DateTime);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(12, 121);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(29, 13);
            this.lblObs.TabIndex = 11;
            this.lblObs.Text = "Obs:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(89, 118);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs.Size = new System.Drawing.Size(374, 105);
            this.txtObs.TabIndex = 12;
            // 
            // lblObs1
            // 
            this.lblObs1.AutoSize = true;
            this.lblObs1.ForeColor = System.Drawing.Color.Blue;
            this.lblObs1.Location = new System.Drawing.Point(12, 235);
            this.lblObs1.Name = "lblObs1";
            this.lblObs1.Size = new System.Drawing.Size(32, 13);
            this.lblObs1.TabIndex = 13;
            this.lblObs1.Text = "OBS:";
            // 
            // lblObsInfo01
            // 
            this.lblObsInfo01.AutoSize = true;
            this.lblObsInfo01.Location = new System.Drawing.Point(86, 235);
            this.lblObsInfo01.Name = "lblObsInfo01";
            this.lblObsInfo01.Size = new System.Drawing.Size(360, 13);
            this.lblObsInfo01.TabIndex = 14;
            this.lblObsInfo01.Text = "Uma mesma peça teatral não deve possuir período de exibição conflitante.";
            // 
            // FrmCadTemporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 268);
            this.Controls.Add(this.lblObsInfo01);
            this.Controls.Add(this.lblObs1);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.mtbTermino);
            this.Controls.Add(this.mtbEstreia);
            this.Controls.Add(this.lblTermino);
            this.Controls.Add(this.lblEstreia);
            this.Controls.Add(this.btListaRegistroExterna);
            this.Controls.Add(this.txtCodigoPeca);
            this.Controls.Add(this.lblCodigoPeca);
            this.Controls.Add(this.tsPadrao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadTemporada";
            this.Text = "Cadastro de Temporada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadTemporada_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadTemporada_Load);
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
        private System.Windows.Forms.Label lblCodigoPeca;
        private System.Windows.Forms.TextBox txtCodigoPeca;
        private System.Windows.Forms.Button btListaRegistroExterna;
        private System.Windows.Forms.Label lblEstreia;
        private System.Windows.Forms.Label lblTermino;
        private System.Windows.Forms.MaskedTextBox mtbEstreia;
        private System.Windows.Forms.MaskedTextBox mtbTermino;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label lblObs1;
        private System.Windows.Forms.Label lblObsInfo01;
    }
}