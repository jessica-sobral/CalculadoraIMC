Console.WriteLine("Qual o seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual a sua altura em metros? (ex.: 1,70)");
float altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Qual o seu peso em Kg? (ex.: 69,2)");
float peso = Convert.ToSingle(Console.ReadLine());

Individuo i = new Individuo(nome, altura, peso);

Console.WriteLine("{0} sua altura é {1} e seu peso é {2}. Seu IMC é {3}.", nome, Math.Round(altura, 2), Math.Round(peso, 2), Math.Round(i.Imc, 2));
Console.WriteLine(i.ClassificacaoImc());
Console.WriteLine(i.PesoNormal(altura, peso));