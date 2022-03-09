using System;
using System.Globalization;


namespace PrimeiroProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = 1;

            var b = "Hello";

            Console.WriteLine(b);

            object c = "teste";

            Console.WriteLine(c);

            c = 2;

            Console.WriteLine(c);

            if (a <= 1)
            {
                Console.WriteLine("Menor que 1");
            }
            else
            {
                Console.WriteLine("maior que 1");
            }

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);

            double aa = 1.0, bb = -3.0, cc = -4.0;

            double delta = Math.Pow(bb, 2.0) - 4.0 * aa * cc;

            double x1 = (-bb + Math.Sqrt(delta)) / (2.0 * aa);

            Console.WriteLine(x1);

            //entrada de dados parte 1

            Console.WriteLine("Entrada de dados  em C#");

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine("Você digitou: " + frase);
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            Console.WriteLine("Z = " + z);
            Console.WriteLine("P1 = " + p1);
            Console.WriteLine("P2 = " + p2);
            Console.WriteLine("P3 = " + p3);

            //entrada de dados parte 2

            int nn1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double nn2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');
            string nome = vet2[0];
            char sexo = char.Parse(vet2[1]);
            int idade = int.Parse(vet2[2]);
            double altura = double.Parse(vet2[3], CultureInfo.InvariantCulture);
            
            Console.WriteLine("Você digitou:");
            Console.WriteLine(nn1);
            Console.WriteLine(ch);    
            Console.WriteLine(nn2);

        }
    }
}
