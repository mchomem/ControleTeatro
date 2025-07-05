/* Autor: Misael da Costa Homem.
 * Ano: 2012
 * Cadeira: Linguagem de Programação I
 * Semestre: 3º
 * Turma: ADS3N12/2A
 * Docente: Lizandro Kirts da Silva.
 * Instituição: Faculdade Senac Porto Alegre - RS
 */

namespace ControleTeatro.Models
{
    /// <summary>
    /// Classe para tratar os dados de conexão lógica do usuário com a aplicação.
    /// </summary>
    public class SessaoUsuario
    {
        private string nome;
        private string tipoUsuario;
        private string dataHoraLogin;
        private string dataHoraLogout;
        
        public SessaoUsuario(string nome, string tipoUsuario, string dataHoraLogin, string dataHoraLogout)
        {
            Nome = nome;
            TipoUsuario = tipoUsuario;
            Dthr_login = dataHoraLogin;
            Dthr_logout = dataHoraLogout;
        }
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

        public string Dthr_login
        {
            get { return dataHoraLogin; }
            set { dataHoraLogin = value; }
        }

        public string Dthr_logout
        {
            get { return dataHoraLogout; }
            set { dataHoraLogout = value; }
        }
    }
}
