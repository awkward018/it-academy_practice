using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
           object[] array = new object[3];
            int a = 32;
            array[0] = a;
            array[1] = 'A';
            string s1 = "Hello";
            array[2] = s1;

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            array[0] = (a + 10);
            array[2] = (s1 + ", Guys!");

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);

            Console.ReadLine();
        }
    }
}
