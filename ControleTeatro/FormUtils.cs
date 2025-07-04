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
    /// <summary>
    /// Classe utilitária para formulários.
    /// </summary>
    public static class FormUtils
    {
        /// <summary>
        /// Método para centralizar formulários no Desktop.
        /// </summary>
        /// <param name="frm">Objeto do tipo formulário.</param>
        public static void CentralizarForm(Form frm, bool mdiChield = false, Form frmParent = null)
        {
            // Se o formulário pertence a um formulário Mdi container.
            // Centraliza o formulário filho pelo formulário pai.
            if (mdiChield)
            {
                frm.Top = (frmParent.Height - frm.Height) / 2;
                frm.Left = (frmParent.Width - frm.Width) / 2; 
            }
            // Se não, centraliza o formulário pelo monitor.
            else
            {
                frm.Top = (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2;
                frm.Left = (Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2;
            }
        }

        /// <summary>
        /// Inicializa os controles (TextBox, CheckBox, etc) de um formulário.
        /// </summary>
        /// <param name="controles">Coleção de controles do formulário.</param>
        public static void InicializarControles(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Text = String.Empty;
                }
                else if (ctrl is CheckBox)
                {
                    (ctrl as CheckBox).Checked = false;
                }
                else if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Text = String.Empty;
                }
                else if (ctrl is DateTimePicker)
                {
                    (ctrl as DateTimePicker).Value = DateTime.Now;
                }
                else if (ctrl is MaskedTextBox)
                {
                    (ctrl as MaskedTextBox).Text = String.Empty;
                }

                // Add mais controles conforme necessidade...

                // Uso do método recursivo utilizando o objeto
                // Control.ControlCollection como parâmetro.
                InicializarControles(ctrl.Controls);
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
            foreach (Control ctrl in controles)
            {
                // Se o controle é uma caixa de texto.
                if (ctrl is TextBox)
                {
                    // Se a propriedade Texto do controle contiver uma apóstrofo.
                    if ((ctrl as TextBox).Text.Contains("'") || (ctrl as TextBox).Text.Contains("|"))
                    {
                        // Variável recebe true;
                        existeApostrofo = true;
                        // Sendo encontrado um apóstrofe em qualquer controle de texto
                        // não é necessário continuar varrendo os outros controles.
                        break;
                    }
                }

                VerificarCaracterProibido(ctrl.Controls);
            }

            return existeApostrofo;
        }
        // ---------------------------------------------------------------------------------------------------------------------------------------
    }
}
