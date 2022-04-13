public class Individuo
{
    public String Nome { get; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double Imc { get => Peso / (Altura * Altura); }
    public Individuo(String nome, double altura, double peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }

    public String toString(double imc)
    {
        return Nome + " sua altura é " + Math.Round(Altura, 2) + " e seu peso é " + Math.Round(Peso, 2) + ". \nSeu IMC é " + Math.Round(imc, 2) + ".";
    }
    
    public String ClassificacaoImc()
    {
        if(Imc < 18.5)
            return "Abaixo do peso.";
        
        if(Imc >= 18.5 && Imc <= 24.9)
            return "Peso normal.";
        
        if(Imc >= 25 && Imc <= 29.9)
            return "Sobrepeso.";
        
        if(Imc >= 30 && Imc <= 34.9)
            return "Obesidade grau I.";
        
        if(Imc >= 35 && Imc <= 39.9)
            return "Obesidade grau II.";
        
        else if(Imc >= 40)
            return "Obesidade grau III ou mórbida.";

        return "";
    }
    
    public String PesoNormal(double altura, double peso)
    {
        double pesoNormal = 0.0;

        if(Imc <= 18.5)
        {
            pesoNormal = 18.50 * altura * altura;
            double pesoGanhar = pesoNormal - peso;

            return "Para alcançar seu peso ideal, o ideal é ganhar " + Math.Round(pesoGanhar, 3) + " Kg.";
            //return "Para alcançar seu peso normal o ideal é ganhar {0} Kg", Math.Round(pesoGanhar, 3);
        }
    
        else if(Imc >= 24.9)
        {
            pesoNormal = 24.9 * altura * altura;
            double pesoPerder = peso - pesoNormal;

            return "Para alcançar seu peso ideal, o ideal é perder " +  Math.Round(pesoPerder, 3) + " Kg.";
            //return "Para alcançar seu peso normal o ideal é perder {0} Kg", Math.Round(pesoPerder, 3);
        }

        return "Você já está no seu peso ideal.";
    }
}