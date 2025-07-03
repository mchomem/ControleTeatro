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
    partial class FrmCadTipoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadTipoUsuario));
            this.tsPadrao = new System.Windows.Forms.ToolStrip();
            this.tsbtnInicializar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnListarRegistros = new System.Windows.Forms.ToolStripButton();
            this.lblCodigoTipoUsuario = new System.Windows.Forms.Label();
            this.txtCodigoTipoUsuario = new System.Windows.Forms.TextBox();
            this.lblDescTipoUsuario = new System.Windows.Forms.Label();
            this.txtDescTipoUsuario = new System.Windows.Forms.TextBox();
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
            this.tsPadrao.Size = new System.Drawing.Size(388, 25);
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
            // lblCodigoTipoUsuario
            // 
            this.lblCodigoTipoUsuario.AutoSize = true;
            this.lblCodigoTipoUsuario.Location = new System.Drawing.Point(12, 43);
            this.lblCodigoTipoUsuario.Name = "lblCodigoTipoUsuario";
            this.lblCodigoTipoUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoTipoUsuario.TabIndex = 2;
            this.lblCodigoTipoUsuario.Text = "Código:";
            // 
            // txtCodigoTipoUsuario
            // 
            this.txtCodigoTipoUsuario.Location = new System.Drawing.Point(73, 40);
            this.txtCodigoTipoUsuario.MaxLength = 10;
            this.txtCodigoTipoUsuario.Name = "txtCodigoTipoUsuario";
            this.txtCodigoTipoUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoTipoUsuario.TabIndex = 3;
            // 
            // lblDescTipoUsuario
            // 
            this.lblDescTipoUsuario.AutoSize = true;
            this.lblDescTipoUsuario.Location = new System.Drawing.Point(12, 73);
            this.lblDescTipoUsuario.Name = "lblDescTipoUsuario";
            this.lblDescTipoUsuario.Size = new System.Drawing.Size(58, 13);
            this.lblDescTipoUsuario.TabIndex = 4;
            this.lblDescTipoUsuario.Text = "Descrição:";
            // 
            // txtDescTipoUsuario
            // 
            this.txtDescTipoUsuario.Location = new System.Drawing.Point(73, 66);
            this.txtDescTipoUsuario.MaxLength = 100;
            this.txtDescTipoUsuario.Multiline = true;
            this.txtDescTipoUsuario.Name = "txtDescTipoUsuario";
            this.txtDescTipoUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescTipoUsuario.Size = new System.Drawing.Size(304, 53);
            this.txtDescTipoUsuario.TabIndex = 5;
            // 
            // FrmCadTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 132);
            this.Controls.Add(this.txtDescTipoUsuario);
            this.Controls.Add(this.lblDescTipoUsuario);
            this.Controls.Add(this.txtCodigoTipoUsuario);
            this.Controls.Add(this.lblCodigoTipoUsuario);
            this.Controls.Add(this.tsPadrao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadTipoUsuario";
            this.Text = "Cadastro de Tipo de Usuário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadTipoUsuario_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadTipoUsuario_Load);
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
        private System.Windows.Forms.Label lblCodigoTipoUsuario;
        private System.Windows.Forms.TextBox txtCodigoTipoUsuario;
        private System.Windows.Forms.Label lblDescTipoUsuario;
        private System.Windows.Forms.TextBox txtDescTipoUsuario;
    }
}