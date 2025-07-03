/* Autor: Misael da Costa Homem.
 * Ano: 2012
 * Cadeira: Linguagem de Programação I
 * Semestre: 3º
 * Turma: ADS3N12/2A
 * Docente: Lizandro Kirts da Silva.
 * Instituição: Faculdade Senac Porto Alegre - RS
 */

using System;
using System.Globalization;
using System.Windows.Forms;

namespace ControleTeatro
{
    /// <summary>
    /// Classe principal da aplicação.
    /// </summary>
    static class Program
    {
        // Campo destinado a armazenar em memória dados de sessão do usuário.
        public static SessaoUsuario sessaoUsuario;

        /// <summary>
        /// O principal ponto de entrada para a aplicação.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Obter a formatação de data abreviada das Configurações de Região e Idioma do sistema operacional.
            string formatoData = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.ToString();


            if (formatoData != "dd/MM/yyyy")
            {
                DialogResult dr;
                dr = MessageBox.Show(null, "Foi encontrado a configuração de Data: " + formatoData + "."
                    + "\nO sistema de Controle de Teatro necessita do padrão dd/MM/yyyy para funcionamento correto."
                    + "\n\nVocê deseja continuar a operar o sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show(null, "O sistema agora estará operando fora do padrão de configuração de data dd/MM/yyyy.\n" 
                    + " Efeitos colaterais indejesáveis poderão ocorrer por conta disto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    InciaSistema();
                }
            }
            else
            {
                InciaSistema();
            }
        }

        private static void InciaSistema()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Instancia o formulário de splash da aplicação.
            FrmSplash frmSplash = new FrmSplash();
            // Exibe o formulário de splash.
            frmSplash.ShowDialog();

            // Instancia o formulário de login.
            FrmLogin frmLogin = new FrmLogin();

            // Se o resulta do diálogo for igual a Ok.
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                // Executa a aplicação no fluxo principal do programa.
                Application.Run(new FrmPrincipal());
            }

            // Encerra somente o formulário de login.
            frmLogin.Close();
        }
    }
}
