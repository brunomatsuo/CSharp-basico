﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6 - Atribuições de Variáveis");

            int idade = 34;
            int idadeBruno = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeBruno);

            Console.ReadLine();
        }
    }
}
