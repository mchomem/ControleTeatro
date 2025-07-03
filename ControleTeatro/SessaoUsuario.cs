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
    /// <summary>
    /// Classe para tratar os dados de conexão lógica do usuário com a aplicação.
    /// </summary>
    class SessaoUsuario
    {
        private string nome;
        private string tipoUsuario;
        private string dthr_login;
        private string dthr_logout;

        // Construtor padrão da classe.
        public SessaoUsuario() { }
        
        // Sobrecarga do construtor da classe.
        public SessaoUsuario(string pNome, string pTipoUsuario, string pDthr_login, string pDthr_logout)
        {
            this.Nome = pNome;
            this.TipoUsuario = pTipoUsuario;
            this.Dthr_login = pDthr_login;
            this.Dthr_logout = pDthr_logout;
        }

        // Propriedades  da classe ----------------------------
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
            get { return dthr_login; }
            set { dthr_login = value; }
        }

        public string Dthr_logout
        {
            get { return dthr_logout; }
            set { dthr_logout = value; }
        }
        // ----------------------------------------------------
    }
}
