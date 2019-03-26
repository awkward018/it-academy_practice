using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[13];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
                Console.WriteLine(array[i]);
                    }

            Console.WriteLine("max Value:");
            int maxValue = array.Max();
            Console.WriteLine(maxValue);

            Console.ReadLine();
            
        }
    }
}
