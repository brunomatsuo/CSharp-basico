﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4 - Conversões e Outros Tipos Numéricos");

            double salario = 1200.50;

            // O int é um tipo de variável que suporta valores até 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long é um tipo de variável de 64 bits
            long idade = 13000000000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variável de 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
