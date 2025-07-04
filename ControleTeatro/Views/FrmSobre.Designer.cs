namespace ControleTeatro.Views
{
    partial class FrmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSobre));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLinha01 = new System.Windows.Forms.Label();
            this.lblLinha02 = new System.Windows.Forms.Label();
            this.lblLinha03 = new System.Windows.Forms.Label();
            this.lblVersaoProduto = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControleTeatro.Properties.Resources.teatro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 275);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(120, 288);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(191, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Controle de Teatro";
            // 
            // lblLinha01
            // 
            this.lblLinha01.AutoSize = true;
            this.lblLinha01.BackColor = System.Drawing.Color.Transparent;
            this.lblLinha01.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinha01.ForeColor = System.Drawing.Color.Black;
            this.lblLinha01.Location = new System.Drawing.Point(12, 352);
            this.lblLinha01.Name = "lblLinha01";
            this.lblLinha01.Size = new System.Drawing.Size(363, 13);
            this.lblLinha01.TabIndex = 4;
            this.lblLinha01.Text = "(c) Copyright Misael da Costa Homem, Controle Teatro, 2012.";
            // 
            // lblLinha02
            // 
            this.lblLinha02.AutoSize = true;
            this.lblLinha02.BackColor = System.Drawing.Color.Transparent;
            this.lblLinha02.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinha02.ForeColor = System.Drawing.Color.Black;
            this.lblLinha02.Location = new System.Drawing.Point(12, 370);
            this.lblLinha02.Name = "lblLinha02";
            this.lblLinha02.Size = new System.Drawing.Size(419, 13);
            this.lblLinha02.TabIndex = 5;
            this.lblLinha02.Text = "Cadeira de Linguagem de Programação I - Prof. Lizandro Kirts da Silva.";
            // 
            // lblLinha03
            // 
            this.lblLinha03.AutoSize = true;
            this.lblLinha03.BackColor = System.Drawing.Color.Transparent;
            this.lblLinha03.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinha03.ForeColor = System.Drawing.Color.Black;
            this.lblLinha03.Location = new System.Drawing.Point(12, 388);
            this.lblLinha03.Name = "lblLinha03";
            this.lblLinha03.Size = new System.Drawing.Size(207, 13);
            this.lblLinha03.TabIndex = 3;
            this.lblLinha03.Text = "Faculdade Senac Porto Alegre - RS";
            // 
            // lblVersaoProduto
            // 
            this.lblVersaoProduto.AutoSize = true;
            this.lblVersaoProduto.Location = new System.Drawing.Point(184, 324);
            this.lblVersaoProduto.Name = "lblVersaoProduto";
            this.lblVersaoProduto.Size = new System.Drawing.Size(46, 13);
            this.lblVersaoProduto.TabIndex = 6;
            this.lblVersaoProduto.Text = "Versão: ";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(178, 438);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 473);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblVersaoProduto);
            this.Controls.Add(this.lblLinha01);
            this.Controls.Add(this.lblLinha02);
            this.Controls.Add(this.lblLinha03);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSobre";
            this.Text = "Sobre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSobre_FormClosing);
            this.Load += new System.EventHandler(this.FrmSobre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLinha01;
        private System.Windows.Forms.Label lblLinha02;
        private System.Windows.Forms.Label lblLinha03;
        private System.Windows.Forms.Label lblVersaoProduto;
        private System.Windows.Forms.Button btnOk;
    }
}