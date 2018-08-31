using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|=========FizzBuzz=========|");
            /*FizzBuzz
            Imprimir los números del 0 al 99. Si el número es divisible por 3 imprimir “Fizz” en vez del número.
            Si el número es divisible es por 5 imprimir “Buzz” en vez del número. Si el número es divisible por
            5 y 3 debe imprimir “FizzBuzz” en vez del número.*/
            var print = "";
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0) print = "Fizz";
                if (i % 5 == 0) print = print + "Buzz";
                if (print == String.Empty || i==0) print = i.ToString();
                Console.WriteLine(print);
                print = "";
            }           
            Console.Read();
        }
    }
}
