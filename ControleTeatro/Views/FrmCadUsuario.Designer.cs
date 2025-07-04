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
    partial class FrmCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadUsuario));
            this.tsPadrao = new System.Windows.Forms.ToolStrip();
            this.tsbtnInicializar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnListarRegistros = new System.Windows.Forms.ToolStripButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.lblDtHrInclusao = new System.Windows.Forms.Label();
            this.txtDtHrInclusao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDtHrUltAcesso = new System.Windows.Forms.TextBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtTipoUsuario = new System.Windows.Forms.TextBox();
            this.btListaRegistroExterna = new System.Windows.Forms.Button();
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
            this.tsPadrao.TabIndex = 0;
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
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 43);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(130, 40);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 69);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(96, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome Funcionário:";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(130, 66);
            this.txtNomeFuncionario.MaxLength = 100;
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(218, 20);
            this.txtNomeFuncionario.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(12, 147);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(130, 144);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(150, 20);
            this.txtSenha.TabIndex = 10;
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Location = new System.Drawing.Point(12, 173);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(85, 13);
            this.lblConfirmaSenha.TabIndex = 11;
            this.lblConfirmaSenha.Text = "Confirma Senha:";
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(130, 170);
            this.txtConfSenha.MaxLength = 20;
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(150, 20);
            this.txtConfSenha.TabIndex = 12;
            // 
            // lblDtHrInclusao
            // 
            this.lblDtHrInclusao.AutoSize = true;
            this.lblDtHrInclusao.Location = new System.Drawing.Point(12, 95);
            this.lblDtHrInclusao.Name = "lblDtHrInclusao";
            this.lblDtHrInclusao.Size = new System.Drawing.Size(102, 13);
            this.lblDtHrInclusao.TabIndex = 5;
            this.lblDtHrInclusao.Text = "Data/hora Inclusão:";
            // 
            // txtDtHrInclusao
            // 
            this.txtDtHrInclusao.Location = new System.Drawing.Point(130, 92);
            this.txtDtHrInclusao.Name = "txtDtHrInclusao";
            this.txtDtHrInclusao.ReadOnly = true;
            this.txtDtHrInclusao.Size = new System.Drawing.Size(150, 20);
            this.txtDtHrInclusao.TabIndex = 6;
            this.txtDtHrInclusao.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data/hora últ. acesso:";
            // 
            // txtDtHrUltAcesso
            // 
            this.txtDtHrUltAcesso.Location = new System.Drawing.Point(130, 118);
            this.txtDtHrUltAcesso.Name = "txtDtHrUltAcesso";
            this.txtDtHrUltAcesso.ReadOnly = true;
            this.txtDtHrUltAcesso.Size = new System.Drawing.Size(150, 20);
            this.txtDtHrUltAcesso.TabIndex = 8;
            this.txtDtHrUltAcesso.TabStop = false;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(12, 200);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(85, 13);
            this.lblTipoUsuario.TabIndex = 13;
            this.lblTipoUsuario.Text = "Tipo de Usuário:";
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.Location = new System.Drawing.Point(130, 197);
            this.txtTipoUsuario.MaxLength = 10;
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.Size = new System.Drawing.Size(150, 20);
            this.txtTipoUsuario.TabIndex = 14;
            // 
            // btListaRegistroExterna
            // 
            this.btListaRegistroExterna.Image = global::ControleTeatro.Properties.Resources.application_go;
            this.btListaRegistroExterna.Location = new System.Drawing.Point(286, 195);
            this.btListaRegistroExterna.Name = "btListaRegistroExterna";
            this.btListaRegistroExterna.Size = new System.Drawing.Size(25, 23);
            this.btListaRegistroExterna.TabIndex = 15;
            this.btListaRegistroExterna.UseVisualStyleBackColor = true;
            this.btListaRegistroExterna.Click += new System.EventHandler(this.btListaRegistroExterna_Click);
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 237);
            this.Controls.Add(this.btListaRegistroExterna);
            this.Controls.Add(this.txtTipoUsuario);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.txtDtHrUltAcesso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDtHrInclusao);
            this.Controls.Add(this.lblDtHrInclusao);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.lblConfirmaSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.tsPadrao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadUsuario";
            this.Text = "Cadastro de Usuário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadUsuario_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadUsuario_Load);
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
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Label lblDtHrInclusao;
        private System.Windows.Forms.TextBox txtDtHrInclusao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnListarRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDtHrUltAcesso;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.TextBox txtTipoUsuario;
        private System.Windows.Forms.Button btListaRegistroExterna;
    }
}