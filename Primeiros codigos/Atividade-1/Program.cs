using System;
using System.Globalization;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço da compra?");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu último nome, idade e altura (na mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');

            string ultimonome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine("Seu nome é " + nome);
            Console.WriteLine("Na sua casa tem " + quartos + " quartos");
            Console.WriteLine("O valor da compra foi " + preco + " reais");
            Console.WriteLine("Seu ultimo nome é " + ultimonome + ", você tem " + idade + " anos, e tem " + altura + " de altura");
        }
    }
}