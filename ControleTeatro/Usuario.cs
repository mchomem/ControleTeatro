/* Autor: Misael da Costa Homem.
 * Ano: 2012
 * Cadeira: Linguagem de Programação I
 * Semestre: 3º
 * Turma: ADS3N12/2A
 * Docente: Lizandro Kirts da Silva.
 * Instituição: Faculdade Senac Porto Alegre - RS
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleTeatro
{
    class Usuario
    {
        private string codigo;
        private string nome;
        private string dataInclusao;

        public Usuario() { }

        public Usuario(string pCodigo, string pNome, string pDataInclusao)
        {
            // Propriedades recebem os parâmetros do construtor.
            this.Codigo = pCodigo;
            this.Nome = pNome;
            this.DataInclusao = pDataInclusao;
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
