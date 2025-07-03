/* Autor: Misael da Costa Homem.
 * Ano: 2012
 * Cadeira: Linguagem de Programação I
 * Semestre: 3º
 * Turma: ADS3N12/2A
 * Docente: Lizandro Kirts da Silva.
 * Instituição: Faculdade Senac Porto Alegre - RS
 */

using System;
using System.Windows.Forms;

namespace ControleTeatro
{
    public partial class FrmSplash : Form
    {
        private bool flag = true;

        /// <summary>
        /// Construtor padrão da classe FrmSplash.
        /// </summary>
        public FrmSplash()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que trato o evento ao carregar do formulário de splah
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSplash_Load(object sender, EventArgs e)
        {
            ConfigTimer();
        }

        /// <summary>
        /// Método que configura algumas propriedades do controle Timer des formulário.
        /// </summary>
        public void ConfigTimer()
        {
            this.trmSplash.Interval = 100;
            this.trmSplash.Tick += new EventHandler(this.trmSplash_Tick);
            this.trmSplash.Enabled = true;
            this.Opacity = 0;
        }

        /// <summary>
        /// Método que trata o evento "tique-taque" do timer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trmSplash_Tick(object sender, EventArgs e)
        {
            // Se flat é true
            if (flag)
            {
                // Aumenta a opacidade do formulário em 0.01 (1%);
                this.Opacity += 0.01;
            }

            // Se a opacidade for igual a 1 (100%).
            if (this.Opacity == 1)
            {
                // Configura flag como false.
                flag = false;

                // Para o timer.
                this.trmSplash.Stop();

                // Encerra o formulário de Splah.
                this.Close();
            }
        }
    }
}
