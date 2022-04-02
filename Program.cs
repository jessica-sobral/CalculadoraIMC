using System;

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
            Console.WriteLine("Seu IMC é {0}", Math.Round(imc, 2));

            if(imc < 18.5)
                Console.WriteLine("Você está abaixo do peso");
            
            if(imc >= 18.5 && imc <= 24.9)
                Console.WriteLine("Você está com o peso normal");
            
            if(imc >= 25 && imc <= 29.9)
                Console.WriteLine("Você está com sobrepeso");
            
            if(imc >= 30 && imc <= 34.9)
                Console.WriteLine("Você está com obesidade grau I");
            
            if(imc >= 35 && imc <= 39.9)
                Console.WriteLine("Você está com obesidade grau II");
            
            else if(imc >= 40)
                Console.WriteLine("Você está com obesidade grau III ou mórbida");
            
            double pesoNormal = 0.0;

            if(imc <= 18.5)
            {
                pesoNormal = 18.50 * altura * altura;
                double pesoGanhar = pesoNormal - peso;
                Console.WriteLine("Para alcançar seu peso normal o ideal é ganhar {0} Kg", Math.Round(pesoGanhar, 3));
            }
            
            else if(imc >= 24.9)
            {
                pesoNormal = 24.9 * altura * altura;
                double pesoPerder = peso - pesoNormal;
                Console.WriteLine("Para alcançar seu peso normal o ideal é perder {0} Kg", Math.Round(pesoPerder, 3));
            }
        }
    }
}
