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
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace ControleTeatro
{
    class Dal
    {
        public static OleDbConnection  conn;

        public Dal() { }

        public static void Conectar()
        {
            //string stringConnection = @"Provider=Microsoft.Jet.OleDb.4.0;Data Source=G:\Faculdade SENAC\Faculdade\3 Semestre\Linguagem_de_Programacao_I\LP1TF\BDTEATRO.MDB";

            string caminhoBase = String.Empty;

            caminhoBase = Application.StartupPath;
            caminhoBase += @"\BD\";

            try
            {
                // Se o diretório não existe
                if(!(Directory.Exists(caminhoBase)))
                {
                    // Cria a pasta para o banco de dados.
                    Directory.CreateDirectory(caminhoBase);
                }
            }
            catch(Exception except)
            {
                throw except;
            }

            caminhoBase += "BDTEATRO.MDB";
            
            string stringConnection = @"Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + caminhoBase + "";

            conn = new OleDbConnection(stringConnection);
            conn.Open();
        }

        public static void Desconectar()
        {
            conn.Close();
        }
    }
}
