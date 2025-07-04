namespace ControleTeatro.Views
{
    partial class FrmPDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPDV));
            this.gbDescItem = new System.Windows.Forms.GroupBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.lblSessao = new System.Windows.Forms.Label();
            this.txtNomePeca = new System.Windows.Forms.TextBox();
            this.lblPecaTeatral = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.gbRegistros = new System.Windows.Forms.GroupBox();
            this.dgvSessoesTemporada = new System.Windows.Forms.DataGridView();
            this.btnEfetuarVenda = new System.Windows.Forms.Button();
            this.pbBandeiraBrasil = new System.Windows.Forms.PictureBox();
            this.gbDescItem.SuspendLayout();
            this.gbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessoesTemporada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBandeiraBrasil)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDescItem
            // 
            this.gbDescItem.Controls.Add(this.txtSituacao);
            this.gbDescItem.Controls.Add(this.lblSessao);
            this.gbDescItem.Controls.Add(this.txtNomePeca);
            this.gbDescItem.Controls.Add(this.lblPecaTeatral);
            this.gbDescItem.ForeColor = System.Drawing.Color.Blue;
            this.gbDescItem.Location = new System.Drawing.Point(12, 339);
            this.gbDescItem.Name = "gbDescItem";
            this.gbDescItem.Size = new System.Drawing.Size(1044, 73);
            this.gbDescItem.TabIndex = 0;
            this.gbDescItem.TabStop = false;
            this.gbDescItem.Text = "Descriminção do Item";
            // 
            // txtSituacao
            // 
            this.txtSituacao.BackColor = System.Drawing.Color.White;
            this.txtSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.ForeColor = System.Drawing.Color.Blue;
            this.txtSituacao.Location = new System.Drawing.Point(761, 25);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ReadOnly = true;
            this.txtSituacao.Size = new System.Drawing.Size(271, 31);
            this.txtSituacao.TabIndex = 13;
            this.txtSituacao.TabStop = false;
            // 
            // lblSessao
            // 
            this.lblSessao.AutoSize = true;
            this.lblSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessao.ForeColor = System.Drawing.Color.Black;
            this.lblSessao.Location = new System.Drawing.Point(665, 28);
            this.lblSessao.Name = "lblSessao";
            this.lblSessao.Size = new System.Drawing.Size(90, 25);
            this.lblSessao.TabIndex = 11;
            this.lblSessao.Text = "Sessão:";
            // 
            // txtNomePeca
            // 
            this.txtNomePeca.BackColor = System.Drawing.Color.White;
            this.txtNomePeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePeca.ForeColor = System.Drawing.Color.Blue;
            this.txtNomePeca.Location = new System.Drawing.Point(153, 25);
            this.txtNomePeca.Name = "txtNomePeca";
            this.txtNomePeca.ReadOnly = true;
            this.txtNomePeca.Size = new System.Drawing.Size(484, 31);
            this.txtNomePeca.TabIndex = 2;
            this.txtNomePeca.TabStop = false;
            // 
            // lblPecaTeatral
            // 
            this.lblPecaTeatral.AutoSize = true;
            this.lblPecaTeatral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPecaTeatral.ForeColor = System.Drawing.Color.Black;
            this.lblPecaTeatral.Location = new System.Drawing.Point(8, 28);
            this.lblPecaTeatral.Name = "lblPecaTeatral";
            this.lblPecaTeatral.Size = new System.Drawing.Size(140, 25);
            this.lblPecaTeatral.TabIndex = 0;
            this.lblPecaTeatral.Text = "Peça Teatral:";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(285, 425);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(178, 25);
            this.lblTotalPagar.TabIndex = 5;
            this.lblTotalPagar.Text = "Total a pagar R$:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BackColor = System.Drawing.Color.White;
            this.txtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalPagar.Location = new System.Drawing.Point(475, 422);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalPagar.Size = new System.Drawing.Size(174, 31);
            this.txtTotalPagar.TabIndex = 6;
            this.txtTotalPagar.TabStop = false;
            this.txtTotalPagar.Text = "0,00";
            // 
            // gbRegistros
            // 
            this.gbRegistros.Controls.Add(this.dgvSessoesTemporada);
            this.gbRegistros.ForeColor = System.Drawing.Color.Blue;
            this.gbRegistros.Location = new System.Drawing.Point(12, 12);
            this.gbRegistros.Name = "gbRegistros";
            this.gbRegistros.Size = new System.Drawing.Size(1044, 321);
            this.gbRegistros.TabIndex = 7;
            this.gbRegistros.TabStop = false;
            this.gbRegistros.Text = "Sessões em Exibição";
            // 
            // dgvSessoesTemporada
            // 
            this.dgvSessoesTemporada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessoesTemporada.Location = new System.Drawing.Point(11, 19);
            this.dgvSessoesTemporada.Name = "dgvSessoesTemporada";
            this.dgvSessoesTemporada.Size = new System.Drawing.Size(1021, 296);
            this.dgvSessoesTemporada.TabIndex = 9;
            this.dgvSessoesTemporada.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSessoesTemporada_CellDoubleClick);
            // 
            // btnEfetuarVenda
            // 
            this.btnEfetuarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfetuarVenda.Location = new System.Drawing.Point(12, 418);
            this.btnEfetuarVenda.Name = "btnEfetuarVenda";
            this.btnEfetuarVenda.Size = new System.Drawing.Size(220, 39);
            this.btnEfetuarVenda.TabIndex = 8;
            this.btnEfetuarVenda.Text = "Efetuar Venda (F5)";
            this.btnEfetuarVenda.UseVisualStyleBackColor = true;
            this.btnEfetuarVenda.Click += new System.EventHandler(this.btnEfetuarVenda_Click);
            // 
            // pbBandeiraBrasil
            // 
            this.pbBandeiraBrasil.Image = global::ControleTeatro.Properties.Resources.BandeiraBrasil;
            this.pbBandeiraBrasil.Location = new System.Drawing.Point(683, 422);
            this.pbBandeiraBrasil.Name = "pbBandeiraBrasil";
            this.pbBandeiraBrasil.Size = new System.Drawing.Size(45, 30);
            this.pbBandeiraBrasil.TabIndex = 9;
            this.pbBandeiraBrasil.TabStop = false;
            // 
            // FrmPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 474);
            this.Controls.Add(this.pbBandeiraBrasil);
            this.Controls.Add(this.btnEfetuarVenda);
            this.Controls.Add(this.gbRegistros);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.gbDescItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmPDV";
            this.Text = "PDV Bilheteria - Venda de Ingressos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPDV_FormClosing);
            this.Load += new System.EventHandler(this.FrmPDV_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPDV_KeyDown);
            this.gbDescItem.ResumeLayout(false);
            this.gbDescItem.PerformLayout();
            this.gbRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessoesTemporada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBandeiraBrasil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDescItem;
        private System.Windows.Forms.Label lblPecaTeatral;
        private System.Windows.Forms.TextBox txtNomePeca;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.GroupBox gbRegistros;
        private System.Windows.Forms.DataGridView dgvSessoesTemporada;
        private System.Windows.Forms.Button btnEfetuarVenda;
        private System.Windows.Forms.Label lblSessao;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.PictureBox pbBandeiraBrasil;
    }
}