using System;


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

        }
    }
}
