namespace ControleTeatro.Views
{
    partial class FrmHistVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistVendas));
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.lblNomePeca = new System.Windows.Forms.Label();
            this.btListaRegistroExterna = new System.Windows.Forms.Button();
            this.mtbDtFim = new System.Windows.Forms.MaskedTextBox();
            this.mtbDtInicio = new System.Windows.Forms.MaskedTextBox();
            this.lblDtFim = new System.Windows.Forms.Label();
            this.lblDtInicio = new System.Windows.Forms.Label();
            this.txtCodigoPeca = new System.Windows.Forms.TextBox();
            this.lblCodigoPeca = new System.Windows.Forms.Label();
            this.tsPadrao = new System.Windows.Forms.ToolStrip();
            this.tsbtnInicializar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConsultar = new System.Windows.Forms.ToolStripButton();
            this.gbRegistros = new System.Windows.Forms.GroupBox();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.gbOpcoesFiltros = new System.Windows.Forms.GroupBox();
            this.rbnNaoOrd = new System.Windows.Forms.RadioButton();
            this.rbnOrdNmPeca = new System.Windows.Forms.RadioButton();
            this.rbnOrdDtEmissBilhete = new System.Windows.Forms.RadioButton();
            this.rbnOrdNrBilhete = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.gbFiltros.SuspendLayout();
            this.tsPadrao.SuspendLayout();
            this.gbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.gbOpcoesFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.lblNomePeca);
            this.gbFiltros.Controls.Add(this.btListaRegistroExterna);
            this.gbFiltros.Controls.Add(this.mtbDtFim);
            this.gbFiltros.Controls.Add(this.mtbDtInicio);
            this.gbFiltros.Controls.Add(this.lblDtFim);
            this.gbFiltros.Controls.Add(this.lblDtInicio);
            this.gbFiltros.Controls.Add(this.txtCodigoPeca);
            this.gbFiltros.Controls.Add(this.lblCodigoPeca);
            this.gbFiltros.ForeColor = System.Drawing.Color.Blue;
            this.gbFiltros.Location = new System.Drawing.Point(12, 38);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(487, 109);
            this.gbFiltros.TabIndex = 0;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // lblNomePeca
            // 
            this.lblNomePeca.AutoSize = true;
            this.lblNomePeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePeca.ForeColor = System.Drawing.Color.Blue;
            this.lblNomePeca.Location = new System.Drawing.Point(215, 28);
            this.lblNomePeca.Name = "lblNomePeca";
            this.lblNomePeca.Size = new System.Drawing.Size(19, 13);
            this.lblNomePeca.TabIndex = 22;
            this.lblNomePeca.Text = "...";
            // 
            // btListaRegistroExterna
            // 
            this.btListaRegistroExterna.Image = global::ControleTeatro.Properties.Resources.application_go;
            this.btListaRegistroExterna.Location = new System.Drawing.Point(184, 23);
            this.btListaRegistroExterna.Name = "btListaRegistroExterna";
            this.btListaRegistroExterna.Size = new System.Drawing.Size(25, 23);
            this.btListaRegistroExterna.TabIndex = 9;
            this.btListaRegistroExterna.UseVisualStyleBackColor = true;
            this.btListaRegistroExterna.Click += new System.EventHandler(this.btListaRegistroExterna_Click);
            // 
            // mtbDtFim
            // 
            this.mtbDtFim.Location = new System.Drawing.Point(78, 77);
            this.mtbDtFim.Mask = "00/00/0000";
            this.mtbDtFim.Name = "mtbDtFim";
            this.mtbDtFim.Size = new System.Drawing.Size(100, 20);
            this.mtbDtFim.TabIndex = 5;
            this.mtbDtFim.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDtInicio
            // 
            this.mtbDtInicio.Location = new System.Drawing.Point(78, 51);
            this.mtbDtInicio.Mask = "00/00/0000";
            this.mtbDtInicio.Name = "mtbDtInicio";
            this.mtbDtInicio.Size = new System.Drawing.Size(100, 20);
            this.mtbDtInicio.TabIndex = 4;
            this.mtbDtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // lblDtFim
            // 
            this.lblDtFim.AutoSize = true;
            this.lblDtFim.ForeColor = System.Drawing.Color.Black;
            this.lblDtFim.Location = new System.Drawing.Point(6, 80);
            this.lblDtFim.Name = "lblDtFim";
            this.lblDtFim.Size = new System.Drawing.Size(52, 13);
            this.lblDtFim.TabIndex = 3;
            this.lblDtFim.Text = "Data Fim:";
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.AutoSize = true;
            this.lblDtInicio.ForeColor = System.Drawing.Color.Black;
            this.lblDtInicio.Location = new System.Drawing.Point(6, 54);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(63, 13);
            this.lblDtInicio.TabIndex = 2;
            this.lblDtInicio.Text = "Data Início:";
            // 
            // txtCodigoPeca
            // 
            this.txtCodigoPeca.Location = new System.Drawing.Point(78, 25);
            this.txtCodigoPeca.Name = "txtCodigoPeca";
            this.txtCodigoPeca.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoPeca.TabIndex = 1;
            // 
            // lblCodigoPeca
            // 
            this.lblCodigoPeca.AutoSize = true;
            this.lblCodigoPeca.ForeColor = System.Drawing.Color.Black;
            this.lblCodigoPeca.Location = new System.Drawing.Point(6, 28);
            this.lblCodigoPeca.Name = "lblCodigoPeca";
            this.lblCodigoPeca.Size = new System.Drawing.Size(35, 13);
            this.lblCodigoPeca.TabIndex = 0;
            this.lblCodigoPeca.Text = "Peça:";
            // 
            // tsPadrao
            // 
            this.tsPadrao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnInicializar,
            this.tsbtnConsultar});
            this.tsPadrao.Location = new System.Drawing.Point(0, 0);
            this.tsPadrao.Name = "tsPadrao";
            this.tsPadrao.Size = new System.Drawing.Size(994, 25);
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
            // tsbtnConsultar
            // 
            this.tsbtnConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnConsultar.Image = global::ControleTeatro.Properties.Resources.accept;
            this.tsbtnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConsultar.Name = "tsbtnConsultar";
            this.tsbtnConsultar.Size = new System.Drawing.Size(23, 22);
            this.tsbtnConsultar.Text = "Consultar";
            this.tsbtnConsultar.Click += new System.EventHandler(this.tsbtnConsultar_Click);
            // 
            // gbRegistros
            // 
            this.gbRegistros.Controls.Add(this.dgvVendas);
            this.gbRegistros.ForeColor = System.Drawing.Color.Blue;
            this.gbRegistros.Location = new System.Drawing.Point(12, 153);
            this.gbRegistros.Name = "gbRegistros";
            this.gbRegistros.Size = new System.Drawing.Size(970, 363);
            this.gbRegistros.TabIndex = 2;
            this.gbRegistros.TabStop = false;
            this.gbRegistros.Text = "Registros";
            // 
            // dgvVendas
            // 
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Location = new System.Drawing.Point(6, 19);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.Size = new System.Drawing.Size(958, 329);
            this.dgvVendas.TabIndex = 0;
            // 
            // gbOpcoesFiltros
            // 
            this.gbOpcoesFiltros.Controls.Add(this.rbnNaoOrd);
            this.gbOpcoesFiltros.Controls.Add(this.rbnOrdNmPeca);
            this.gbOpcoesFiltros.Controls.Add(this.rbnOrdDtEmissBilhete);
            this.gbOpcoesFiltros.Controls.Add(this.rbnOrdNrBilhete);
            this.gbOpcoesFiltros.ForeColor = System.Drawing.Color.Blue;
            this.gbOpcoesFiltros.Location = new System.Drawing.Point(505, 38);
            this.gbOpcoesFiltros.Name = "gbOpcoesFiltros";
            this.gbOpcoesFiltros.Size = new System.Drawing.Size(477, 109);
            this.gbOpcoesFiltros.TabIndex = 23;
            this.gbOpcoesFiltros.TabStop = false;
            this.gbOpcoesFiltros.Text = "Opções de Filtro";
            // 
            // rbnNaoOrd
            // 
            this.rbnNaoOrd.AutoSize = true;
            this.rbnNaoOrd.Checked = true;
            this.rbnNaoOrd.ForeColor = System.Drawing.Color.Black;
            this.rbnNaoOrd.Location = new System.Drawing.Point(6, 19);
            this.rbnNaoOrd.Name = "rbnNaoOrd";
            this.rbnNaoOrd.Size = new System.Drawing.Size(87, 17);
            this.rbnNaoOrd.TabIndex = 4;
            this.rbnNaoOrd.TabStop = true;
            this.rbnNaoOrd.Text = "Não ordenar.";
            this.rbnNaoOrd.UseVisualStyleBackColor = true;
            // 
            // rbnOrdNmPeca
            // 
            this.rbnOrdNmPeca.AutoSize = true;
            this.rbnOrdNmPeca.ForeColor = System.Drawing.Color.Black;
            this.rbnOrdNmPeca.Location = new System.Drawing.Point(6, 88);
            this.rbnOrdNmPeca.Name = "rbnOrdNmPeca";
            this.rbnOrdNmPeca.Size = new System.Drawing.Size(156, 17);
            this.rbnOrdNmPeca.TabIndex = 3;
            this.rbnOrdNmPeca.Text = "Ordenar por nome da Peça.";
            this.rbnOrdNmPeca.UseVisualStyleBackColor = true;
            // 
            // rbnOrdDtEmissBilhete
            // 
            this.rbnOrdDtEmissBilhete.AutoSize = true;
            this.rbnOrdDtEmissBilhete.ForeColor = System.Drawing.Color.Black;
            this.rbnOrdDtEmissBilhete.Location = new System.Drawing.Point(6, 65);
            this.rbnOrdDtEmissBilhete.Name = "rbnOrdDtEmissBilhete";
            this.rbnOrdDtEmissBilhete.Size = new System.Drawing.Size(164, 17);
            this.rbnOrdDtEmissBilhete.TabIndex = 2;
            this.rbnOrdDtEmissBilhete.Text = "Ordenar por data de emissão.";
            this.rbnOrdDtEmissBilhete.UseVisualStyleBackColor = true;
            // 
            // rbnOrdNrBilhete
            // 
            this.rbnOrdNrBilhete.AutoSize = true;
            this.rbnOrdNrBilhete.ForeColor = System.Drawing.Color.Black;
            this.rbnOrdNrBilhete.Location = new System.Drawing.Point(6, 42);
            this.rbnOrdNrBilhete.Name = "rbnOrdNrBilhete";
            this.rbnOrdNrBilhete.Size = new System.Drawing.Size(171, 17);
            this.rbnOrdNrBilhete.TabIndex = 1;
            this.rbnOrdNrBilhete.Text = "Ordenar por número de bilhete.";
            this.rbnOrdNrBilhete.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.Control;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Blue;
            this.lblResultado.Location = new System.Drawing.Point(138, 536);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(14, 13);
            this.lblResultado.TabIndex = 27;
            this.lblResultado.Text = "0";
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(9, 534);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(91, 13);
            this.lblTotalRegistros.TabIndex = 26;
            this.lblTotalRegistros.Text = "Total de registros:";
            // 
            // FrmHistVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 567);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.gbOpcoesFiltros);
            this.Controls.Add(this.gbRegistros);
            this.Controls.Add(this.tsPadrao);
            this.Controls.Add(this.gbFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHistVendas";
            this.Text = "Histórico de Vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHistVendas_FormClosing);
            this.Load += new System.EventHandler(this.FrmHistVendas_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.tsPadrao.ResumeLayout(false);
            this.tsPadrao.PerformLayout();
            this.gbRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.gbOpcoesFiltros.ResumeLayout(false);
            this.gbOpcoesFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblCodigoPeca;
        private System.Windows.Forms.TextBox txtCodigoPeca;
        private System.Windows.Forms.MaskedTextBox mtbDtFim;
        private System.Windows.Forms.MaskedTextBox mtbDtInicio;
        private System.Windows.Forms.Label lblDtFim;
        private System.Windows.Forms.Label lblDtInicio;
        private System.Windows.Forms.Button btListaRegistroExterna;
        private System.Windows.Forms.Label lblNomePeca;
        private System.Windows.Forms.ToolStrip tsPadrao;
        private System.Windows.Forms.ToolStripButton tsbtnInicializar;
        private System.Windows.Forms.ToolStripButton tsbtnConsultar;
        private System.Windows.Forms.GroupBox gbRegistros;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.GroupBox gbOpcoesFiltros;
        private System.Windows.Forms.RadioButton rbnOrdNrBilhete;
        private System.Windows.Forms.RadioButton rbnOrdNmPeca;
        private System.Windows.Forms.RadioButton rbnOrdDtEmissBilhete;
        private System.Windows.Forms.RadioButton rbnNaoOrd;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTotalRegistros;
    }
}