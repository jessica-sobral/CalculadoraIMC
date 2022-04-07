Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual a sua altura em metros? (ex.: 1,70)");
float altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Qual o seu peso em Kg? (ex.: 69,2)");
float peso = Convert.ToSingle(Console.ReadLine());

Individuo i = new Individuo(nome, altura, peso);
double imc = i.CalculoImc(altura, peso);

Console.WriteLine(i.toString(imc));
Console.WriteLine(i.ClassificacaoImc(imc));
Console.WriteLine(i.PesoNormal(altura, peso, imc));