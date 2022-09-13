using System;
using System.Collections.Generic;
using System.Linq;

namespace ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack <int> numeros = new Stack <int>();
            List <int> auxNums = new List <int>();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                numeros.Push(random.Next(-100,100));
            }

            Console.WriteLine("lista inicial");

            foreach (int num in numeros) 
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("lista ordenada 1");
            auxNums = numeros.ToList();
            auxNums.Sort();
            numeros = new Stack <int>(auxNums);

            foreach (int num in numeros)
            {
                if (num > 0)
                {
                    Console.WriteLine(num);
                }
            }

            Console.WriteLine("lista ordenada 2");
            auxNums.Reverse();
            numeros = new Stack<int>(auxNums);

            foreach (int num in numeros)
            {
                if (num > 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
