
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P1Questao1{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o seu nome completo composto do Primeiro nome, nome do meio e sobrenome: ");
            string nome = Console.ReadLine();
            NomeProprio nomeProprio = new NomeProprio(nome);
            nomeProprio.ImprimeNomePaper();

        }
    }
}