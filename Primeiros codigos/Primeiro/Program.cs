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
        }
    }
}
