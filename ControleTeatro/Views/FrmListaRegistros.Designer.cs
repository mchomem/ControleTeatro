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
    partial class FrmListaRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaRegistros));
            this.gbRegistros = new System.Windows.Forms.GroupBox();
            this.dgwRegistros = new System.Windows.Forms.DataGridView();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.gbRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRegistros
            // 
            this.gbRegistros.Controls.Add(this.dgwRegistros);
            this.gbRegistros.Location = new System.Drawing.Point(12, 12);
            this.gbRegistros.Name = "gbRegistros";
            this.gbRegistros.Size = new System.Drawing.Size(660, 396);
            this.gbRegistros.TabIndex = 0;
            this.gbRegistros.TabStop = false;
            this.gbRegistros.Text = "Registros";
            // 
            // dgwRegistros
            // 
            this.dgwRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRegistros.Location = new System.Drawing.Point(3, 16);
            this.dgwRegistros.Name = "dgwRegistros";
            this.dgwRegistros.Size = new System.Drawing.Size(651, 374);
            this.dgwRegistros.TabIndex = 0;
            this.dgwRegistros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRegistros_CellDoubleClick);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(12, 432);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(91, 13);
            this.lblTotalRegistros.TabIndex = 1;
            this.lblTotalRegistros.Text = "Total de registros:";
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.Control;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Blue;
            this.lblResultado.Location = new System.Drawing.Point(132, 432);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(14, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "0";
            // 
            // FrmListaRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.gbRegistros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmListaRegistros";
            this.Text = "Lista de Registros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListaRegistros_FormClosing);
            this.Load += new System.EventHandler(this.FrmListaRegistros_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmListaRegistros_KeyDown);
            this.gbRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistros;
        private System.Windows.Forms.DataGridView dgwRegistros;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label lblResultado;
    }
}