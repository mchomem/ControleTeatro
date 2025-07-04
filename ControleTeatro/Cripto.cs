/* Autor: Misael da Costa Homem.
 * Ano: 2012
 * Cadeira: Linguagem de Programação I
 * Semestre: 3º
 * Turma: ADS3N12/2A
 * Docente: Lizandro Kirts da Silva.
 * Instituição: Faculdade Senac Porto Alegre - RS
 */

using System;
using System.Security.Cryptography;
using System.Text;

namespace ControleTeatro
{
    public class Cripto
    {
        public Cripto() { }

        public string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Converter uma string para um array de bytes e calcula o hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Criar um novo StringBuilder para recolher os bytes
            // E criar uma string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop através de cada byte de dados com hash
            // Eo formato de cada um como uma string hexadecimal.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Retorna a string hexadecimal.
            return sBuilder.ToString();
        }

        // Verify a hash against a string. 
        public bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input. 
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return 0 == comparer.Compare(hashOfInput, hash);
        }
    }
}
