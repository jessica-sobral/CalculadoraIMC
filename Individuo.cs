public class Individuo
{
    public string Nome { get; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double Imc { get; }
    public Individuo(string nome, double altura, double peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }

    public string CalculoIMC(string nome, double altura, double peso, double imc)
    {
        imc = peso / (altura * altura);

        return "{0} sua altura é {1} e seu peso é {2}", nome, altura, peso + "\nSeu IMC é {0}", Math.Round(imc, 2);
    }

    public string ClassificacaoIMC(double imc)
    {
        if(imc < 18.5)
            return "Abaixo do peso";
        
        if(imc >= 18.5 && imc <= 24.9)
            return "Peso normal";
        
        if(imc >= 25 && imc <= 29.9)
            return "Você está com sobrepeso";
        
        if(imc >= 30 && imc <= 34.9)
            return "Obesidade grau I";
        
        if(imc >= 35 && imc <= 39.9)
            return "Obesidade grau II";
        
        else if(imc >= 40)
            return "Obesidade grau III ou mórbida";
    }

    public void PesoNormal(double altura, double peso, double imc)
    {
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