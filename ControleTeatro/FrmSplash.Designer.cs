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
    partial class FrmSplash
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
            this.components = new System.ComponentModel.Container();
            this.pbSplah = new System.Windows.Forms.PictureBox();
            this.lblLinha01 = new System.Windows.Forms.Label();
            this.lblLinha02 = new System.Windows.Forms.Label();
            this.lblLinha03 = new System.Windows.Forms.Label();
            this.trmSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSplah)).BeginInit();
            this.pbSplah.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSplah
            // 
            this.pbSplah.Controls.Add(this.lblLinha01);
            this.pbSplah.Controls.Add(this.lblLinha02);
            this.pbSplah.Controls.Add(this.lblLinha03);
            this.pbSplah.Image = global::ControleTeatro.Properties.Resources.Slpash;
            this.pbSplah.Location = new System.Drawing.Point(0, 0);
            this.pbSplah.Name = "pbSplah";
            this.pbSplah.Size = new System.Drawing.Size(440, 275);
            this.pbSplah.TabIndex = 0;
            this.pbSplah.TabStop = false;
            // 
            // lblLinha01
            // 
            this.lblLinha01.AutoSize = true;
            this.lblLinha01.BackColor = System.Drawing.Color.Transparent;
            this.lblLinha01.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinha01.ForeColor = System.Drawing.Color.White;
            this.lblLinha01.Location = new System.Drawing.Point(12, 218);
            this.lblLinha01.Name = "lblLinha01";
            this.lblLinha01.Size = new System.Drawing.Size(363, 13);
            this.lblLinha01.TabIndex = 1;
            this.lblLinha01.Text = "(c) Copyright Misael da Costa Homem, Controle Teatro, 2012.";
            // 
            // lblLinha02
            // 
            this.lblLinha02.AutoSize = true;
            this.lblLinha02.BackColor = System.Drawing.Color.Transparent;
            this.lblLinha02.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinha02.ForeColor = System.Drawing.Color.White;
            this.lblLinha02.Location = new System.Drawing.Point(12, 236);
            this.lblLinha02.Name = "lblLinha02";
            this.lblLinha02.Size = new System.Drawing.Size(419, 13);
            this.lblLinha02.TabIndex = 2;
            this.lblLinha02.Text = "Cadeira de Linguagem de Programação I - Prof. Lizandro Kirts da Silva.";
            // 
            // lblLinha03
            // 
            this.lblLinha03.AutoSize = true;
            this.lblLinha03.BackColor = System.Drawing.Color.Transparent;
            this.lblLinha03.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinha03.ForeColor = System.Drawing.Color.Transparent;
            this.lblLinha03.Location = new System.Drawing.Point(12, 254);
            this.lblLinha03.Name = "lblLinha03";
            this.lblLinha03.Size = new System.Drawing.Size(207, 13);
            this.lblLinha03.TabIndex = 1;
            this.lblLinha03.Text = "Faculdade Senac Porto Alegre - RS";
            // 
            // trmSplash
            // 
            this.trmSplash.Tick += new System.EventHandler(this.trmSplash_Tick);
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 275);
            this.Controls.Add(this.pbSplah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSplash";
            this.Load += new System.EventHandler(this.FrmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSplah)).EndInit();
            this.pbSplah.ResumeLayout(false);
            this.pbSplah.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSplah;
        private System.Windows.Forms.Label lblLinha01;
        private System.Windows.Forms.Label lblLinha02;
        private System.Windows.Forms.Label lblLinha03;
        private System.Windows.Forms.Timer trmSplash;
    }
}