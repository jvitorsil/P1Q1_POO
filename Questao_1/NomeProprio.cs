
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P1Questao1{
    class NomeProprio
    {
        string nome_completo;
        string nome_paper;

        public NomeProprio(){ }

        public NomeProprio(string _nome_completo){
            nome_completo = _nome_completo;
         }


        public void ImprimeNomePaper(){
            string primeiro_nome = nome_completo.Split(' ')[0];
            string segundo_nome = nome_completo.Split(' ')[1];
            string sobrenome = nome_completo.Split(' ')[2];

            String nome_paper = sobrenome + ", " + primeiro_nome + " " + segundo_nome[0] + ".";
            Console.WriteLine(nome_paper);
        }

    }
}