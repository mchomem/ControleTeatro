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
    public class Usuario
    {
        private string codigo;
        private string nome;
        private string dataInclusao;

        public Usuario() { }

        public Usuario(string codigo, string nome, string dataInclusao)
        {
            Codigo = codigo;
            Nome = nome;
            DataInclusao = dataInclusao;
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string DataInclusao
        {
            get { return dataInclusao; }
            set { dataInclusao = value; }
        }
    }
}
