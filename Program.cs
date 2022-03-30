﻿using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros? (ex.: 1,70)");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em Kg? (ex.: 69,2)");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine(
                "{0} sua altura é {1} e seu peso é {2}", nome, altura, peso
            );
            Console.WriteLine("Seu IMC é {0}", imc);
        }
    }
}
