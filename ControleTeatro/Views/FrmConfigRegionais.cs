/* Autor: Misael da Costa Homem.
 * Ano: 2012
 * Cadeira: Linguagem de Programação I
 * Semestre: 3º
 * Turma: ADS3N12/2A
 * Docente: Lizandro Kirts da Silva.
 * Instituição: Faculdade Senac Porto Alegre - RS
 */

using System;
using System.Globalization; // para acessar a classe CultureInfo
using System.Windows.Forms;
using ControleTeatro.Helpers;

namespace ControleTeatro.Views
{
    public partial class FrmConfigRegionais : Form
    {
        public FrmConfigRegionais()
        {
            InitializeComponent();
        }

        private void FrmConfigRegionais_Load(object sender, EventArgs e)
        {
            ObterConfiguracoesRegionais();
            FormHelper.CentralizarForm(this);
            this.Text += " da estação local: " + System.Environment.MachineName;
        }

        private void FrmConfigRegionais_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmPrincipal.frmConfigRegionais = null;
        }

        private void ObterConfiguracoesRegionais()
        {
            // Obter a formatação de data abreviada das Configurações de Região e Idioma do sistema operacional.
            string formatoData = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.ToString();

            this.txtFormato.Text = CultureInfo.CurrentCulture.DisplayName.ToString();

            if (formatoData != "dd/MM/yyyy")
            {
                this.txtDataAbreviada.ForeColor = System.Drawing.Color.Red;
            }

            this.txtDataAbreviada.Text = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.ToString();
            this.txtDataExtenso.Text = CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern;
            this.txtHoraAbreviada.Text = CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern.ToString();
            this.txtHoraExtenso.Text = CultureInfo.CurrentCulture.DateTimeFormat.LongTimePattern.ToString();
            this.txtPrimeiroDiaSemana.Text = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek.ToString();
        }
    }
}
