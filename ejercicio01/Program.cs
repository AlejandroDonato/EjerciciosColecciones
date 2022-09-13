using System;
using System.Collections.Generic;
using System.Linq;

namespace ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> numeros = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                numeros.Add(random.Next(-100, 100));
            }
            foreach (int UnNumero in numeros) 
            {
                Console.WriteLine(UnNumero);
            }
            Console.WriteLine();

            numeros.Sort();

            foreach (int numOrden in numeros)
            {
                Console.WriteLine(numOrden);
            }

            if (numeros.Count() > 0)
            { 
                numeros.Reverse();  
            }

            Console.WriteLine("Prdenados mayor a menor");

            foreach (int numOrden in numeros)
            {
                Console.WriteLine(numOrden);
            }
        }
    }
}
