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
    partial class FrmCadPecaTeatral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadPecaTeatral));
            this.tsPadrao = new System.Windows.Forms.ToolStrip();
            this.tsbtnInicializar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnListarRegistros = new System.Windows.Forms.ToolStripButton();
            this.lblCodigoPeca = new System.Windows.Forms.Label();
            this.txtCodigoPeca = new System.Windows.Forms.TextBox();
            this.lblNomePeca = new System.Windows.Forms.Label();
            this.txtNomePeca = new System.Windows.Forms.TextBox();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.btListaRegistroExterna = new System.Windows.Forms.Button();
            this.lblAtorPrincipal = new System.Windows.Forms.Label();
            this.txtAtorPrincipal = new System.Windows.Forms.TextBox();
            this.lblAtrizPrincipal = new System.Windows.Forms.Label();
            this.txtAtrizPrincipal = new System.Windows.Forms.TextBox();
            this.lblAtorCoadjuvante = new System.Windows.Forms.Label();
            this.txtAtorCoadjuvante = new System.Windows.Forms.TextBox();
            this.gbImagemCapa = new System.Windows.Forms.GroupBox();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminhoImagem = new System.Windows.Forms.TextBox();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.pbImagemCapa = new System.Windows.Forms.PictureBox();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.ofdCaminhoArquivo = new System.Windows.Forms.OpenFileDialog();
            this.tsPadrao.SuspendLayout();
            this.gbImagemCapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemCapa)).BeginInit();
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
            this.tsPadrao.Size = new System.Drawing.Size(493, 25);
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
            this.lblCodigoPeca.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoPeca.TabIndex = 2;
            this.lblCodigoPeca.Text = "Código:";
            // 
            // txtCodigoPeca
            // 
            this.txtCodigoPeca.Location = new System.Drawing.Point(130, 40);
            this.txtCodigoPeca.Name = "txtCodigoPeca";
            this.txtCodigoPeca.Size = new System.Drawing.Size(130, 20);
            this.txtCodigoPeca.TabIndex = 3;
            // 
            // lblNomePeca
            // 
            this.lblNomePeca.AutoSize = true;
            this.lblNomePeca.Location = new System.Drawing.Point(12, 69);
            this.lblNomePeca.Name = "lblNomePeca";
            this.lblNomePeca.Size = new System.Drawing.Size(81, 13);
            this.lblNomePeca.TabIndex = 4;
            this.lblNomePeca.Text = "Nome da Peça:";
            // 
            // txtNomePeca
            // 
            this.txtNomePeca.Location = new System.Drawing.Point(130, 66);
            this.txtNomePeca.Name = "txtNomePeca";
            this.txtNomePeca.Size = new System.Drawing.Size(347, 20);
            this.txtNomePeca.TabIndex = 5;
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Location = new System.Drawing.Point(12, 95);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(72, 13);
            this.lblClassificacao.TabIndex = 6;
            this.lblClassificacao.Text = "Classificação:";
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Location = new System.Drawing.Point(130, 92);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(73, 20);
            this.txtClassificacao.TabIndex = 7;
            // 
            // btListaRegistroExterna
            // 
            this.btListaRegistroExterna.Image = global::ControleTeatro.Properties.Resources.application_go;
            this.btListaRegistroExterna.Location = new System.Drawing.Point(209, 90);
            this.btListaRegistroExterna.Name = "btListaRegistroExterna";
            this.btListaRegistroExterna.Size = new System.Drawing.Size(25, 23);
            this.btListaRegistroExterna.TabIndex = 8;
            this.btListaRegistroExterna.UseVisualStyleBackColor = true;
            this.btListaRegistroExterna.Click += new System.EventHandler(this.btListaRegistroExterna_Click);
            // 
            // lblAtorPrincipal
            // 
            this.lblAtorPrincipal.AutoSize = true;
            this.lblAtorPrincipal.Location = new System.Drawing.Point(12, 121);
            this.lblAtorPrincipal.Name = "lblAtorPrincipal";
            this.lblAtorPrincipal.Size = new System.Drawing.Size(72, 13);
            this.lblAtorPrincipal.TabIndex = 9;
            this.lblAtorPrincipal.Text = "Ator Principal:";
            // 
            // txtAtorPrincipal
            // 
            this.txtAtorPrincipal.Location = new System.Drawing.Point(130, 118);
            this.txtAtorPrincipal.Name = "txtAtorPrincipal";
            this.txtAtorPrincipal.Size = new System.Drawing.Size(347, 20);
            this.txtAtorPrincipal.TabIndex = 10;
            // 
            // lblAtrizPrincipal
            // 
            this.lblAtrizPrincipal.AutoSize = true;
            this.lblAtrizPrincipal.Location = new System.Drawing.Point(12, 147);
            this.lblAtrizPrincipal.Name = "lblAtrizPrincipal";
            this.lblAtrizPrincipal.Size = new System.Drawing.Size(73, 13);
            this.lblAtrizPrincipal.TabIndex = 11;
            this.lblAtrizPrincipal.Text = "Atriz Principal:";
            // 
            // txtAtrizPrincipal
            // 
            this.txtAtrizPrincipal.Location = new System.Drawing.Point(130, 144);
            this.txtAtrizPrincipal.Name = "txtAtrizPrincipal";
            this.txtAtrizPrincipal.Size = new System.Drawing.Size(347, 20);
            this.txtAtrizPrincipal.TabIndex = 12;
            // 
            // lblAtorCoadjuvante
            // 
            this.lblAtorCoadjuvante.AutoSize = true;
            this.lblAtorCoadjuvante.Location = new System.Drawing.Point(12, 173);
            this.lblAtorCoadjuvante.Name = "lblAtorCoadjuvante";
            this.lblAtorCoadjuvante.Size = new System.Drawing.Size(70, 13);
            this.lblAtorCoadjuvante.TabIndex = 13;
            this.lblAtorCoadjuvante.Text = "Coadjuvante:";
            // 
            // txtAtorCoadjuvante
            // 
            this.txtAtorCoadjuvante.Location = new System.Drawing.Point(130, 170);
            this.txtAtorCoadjuvante.Name = "txtAtorCoadjuvante";
            this.txtAtorCoadjuvante.Size = new System.Drawing.Size(347, 20);
            this.txtAtorCoadjuvante.TabIndex = 14;
            // 
            // gbImagemCapa
            // 
            this.gbImagemCapa.Controls.Add(this.lblInformacao);
            this.gbImagemCapa.Controls.Add(this.lblObs);
            this.gbImagemCapa.Controls.Add(this.label1);
            this.gbImagemCapa.Controls.Add(this.txtCaminhoImagem);
            this.gbImagemCapa.Controls.Add(this.btnCarregarImagem);
            this.gbImagemCapa.Controls.Add(this.pbImagemCapa);
            this.gbImagemCapa.Controls.Add(this.lblCaminho);
            this.gbImagemCapa.ForeColor = System.Drawing.Color.Blue;
            this.gbImagemCapa.Location = new System.Drawing.Point(12, 196);
            this.gbImagemCapa.Name = "gbImagemCapa";
            this.gbImagemCapa.Size = new System.Drawing.Size(465, 416);
            this.gbImagemCapa.TabIndex = 15;
            this.gbImagemCapa.TabStop = false;
            this.gbImagemCapa.Text = "Imagem da Capa";
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.ForeColor = System.Drawing.Color.Black;
            this.lblInformacao.Location = new System.Drawing.Point(115, 379);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(282, 13);
            this.lblInformacao.TabIndex = 23;
            this.lblInformacao.Text = "Resolução máxima para as imagens é de 300 x 300 pixels.";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(16, 379);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(32, 13);
            this.lblObs.TabIndex = 22;
            this.lblObs.Text = "OBS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Visualização:";
            // 
            // txtCaminhoImagem
            // 
            this.txtCaminhoImagem.Location = new System.Drawing.Point(118, 31);
            this.txtCaminhoImagem.MaxLength = 255;
            this.txtCaminhoImagem.Name = "txtCaminhoImagem";
            this.txtCaminhoImagem.Size = new System.Drawing.Size(300, 20);
            this.txtCaminhoImagem.TabIndex = 17;
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Location = new System.Drawing.Point(424, 29);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(25, 23);
            this.btnCarregarImagem.TabIndex = 18;
            this.btnCarregarImagem.Text = "...";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // pbImagemCapa
            // 
            this.pbImagemCapa.Image = global::ControleTeatro.Properties.Resources.CapaPadrao;
            this.pbImagemCapa.Location = new System.Drawing.Point(118, 57);
            this.pbImagemCapa.Name = "pbImagemCapa";
            this.pbImagemCapa.Size = new System.Drawing.Size(300, 300);
            this.pbImagemCapa.TabIndex = 21;
            this.pbImagemCapa.TabStop = false;
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.ForeColor = System.Drawing.Color.Black;
            this.lblCaminho.Location = new System.Drawing.Point(16, 34);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(51, 13);
            this.lblCaminho.TabIndex = 16;
            this.lblCaminho.Text = "Caminho:";
            // 
            // FrmCadPecaTeatral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 624);
            this.Controls.Add(this.gbImagemCapa);
            this.Controls.Add(this.txtAtorCoadjuvante);
            this.Controls.Add(this.lblAtorCoadjuvante);
            this.Controls.Add(this.txtAtrizPrincipal);
            this.Controls.Add(this.lblAtrizPrincipal);
            this.Controls.Add(this.txtAtorPrincipal);
            this.Controls.Add(this.lblAtorPrincipal);
            this.Controls.Add(this.btListaRegistroExterna);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.txtNomePeca);
            this.Controls.Add(this.lblNomePeca);
            this.Controls.Add(this.txtCodigoPeca);
            this.Controls.Add(this.lblCodigoPeca);
            this.Controls.Add(this.tsPadrao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadPecaTeatral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Peça Teatral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadPecaTeatral_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadPecaTeatral_Load);
            this.tsPadrao.ResumeLayout(false);
            this.tsPadrao.PerformLayout();
            this.gbImagemCapa.ResumeLayout(false);
            this.gbImagemCapa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemCapa)).EndInit();
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
        private System.Windows.Forms.Label lblNomePeca;
        private System.Windows.Forms.TextBox txtNomePeca;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Button btListaRegistroExterna;
        private System.Windows.Forms.Label lblAtorPrincipal;
        private System.Windows.Forms.TextBox txtAtorPrincipal;
        private System.Windows.Forms.Label lblAtrizPrincipal;
        private System.Windows.Forms.TextBox txtAtrizPrincipal;
        private System.Windows.Forms.Label lblAtorCoadjuvante;
        private System.Windows.Forms.TextBox txtAtorCoadjuvante;
        private System.Windows.Forms.GroupBox gbImagemCapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminhoImagem;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.PictureBox pbImagemCapa;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.OpenFileDialog ofdCaminhoArquivo;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblInformacao;


    }
}