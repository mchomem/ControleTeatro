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

namespace ControleTeatro.Helpers
{
    /// <summary>
    /// Classe auxiliar para formulários.
    /// </summary>
    public static class FormHelper
    {
        /// <summary>
        /// Método para centralizar formulários no Desktop.
        /// </summary>
        /// <param name="form">Objeto do tipo formulário.</param>
        public static void CentralizarForm(Form form, bool mdiChield = false, Form formParent = null)
        {
            // Se o formulário pertence a um formulário Mdi container.
            // Centraliza o formulário filho pelo formulário pai.
            if (mdiChield)
            {
                form.Top = (formParent.Height - form.Height) / 2;
                form.Left = (formParent.Width - form.Width) / 2; 
            }
            // Se não, centraliza o formulário pelo monitor.
            else
            {
                form.Top = (Screen.PrimaryScreen.Bounds.Height - form.Height) / 2;
                form.Left = (Screen.PrimaryScreen.Bounds.Width - form.Width) / 2;
            }
        }

        /// <summary>
        /// Inicializa os controles (TextBox, CheckBox, etc) de um formulário.
        /// </summary>
        /// <param name="controles">Coleção de controles do formulário.</param>
        public static void InicializarControles(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Text = string.Empty;
                }
                else if (control is CheckBox)
                {
                    (control as CheckBox).Checked = false;
                }
                else if (control is ComboBox)
                {
                    (control as ComboBox).Text = string.Empty;
                }
                else if (control is DateTimePicker)
                {
                    (control as DateTimePicker).Value = DateTime.Now;
                }
                else if (control is MaskedTextBox)
                {
                    (control as MaskedTextBox).Text = string.Empty;
                }

                // Add mais controles conforme necessidade...

                // Uso do método recursivo utilizando o objeto
                // Control.ControlCollection como parâmetro.
                InicializarControles(control.Controls);
            }
        }

        // Misael - 07/11/2012 - 01:09 -----------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Método para identificar em uma string um caractere proibido para uso como um apóstrofo: ' ou pipe: |
        /// </summary>
        /// <param name="controles">Coleção de controles do formulário.</param>
        /// <returns>Retorna true se for encontrado um caractere proibido na string de qualquer controle de caixa de texto.</returns>
        public static bool VerificarCaracterProibido(Control.ControlCollection controles)
        {
            bool existeApostrofo =  false;

            // Varre todos os controles ca coleção
            foreach (Control control in controles)
            {
                // Se o controle é uma caixa de texto.
                if (control is TextBox)
                {
                    // Se a propriedade Texto do controle contiver uma apóstrofo.
                    if ((control as TextBox).Text.Contains("'") || (control as TextBox).Text.Contains("|"))
                    {
                        // Variável recebe true;
                        existeApostrofo = true;
                        // Sendo encontrado um apóstrofe em qualquer controle de texto
                        // não é necessário continuar varrendo os outros controles.
                        break;
                    }
                }

                VerificarCaracterProibido(control.Controls);
            }

            return existeApostrofo;
        }
        // ---------------------------------------------------------------------------------------------------------------------------------------
    }
}
