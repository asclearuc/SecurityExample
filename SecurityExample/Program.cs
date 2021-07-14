using System;

namespace SecurityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = new int[5];
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
                array[i] = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < num; i++)
                sum += array[i];

            Console.WriteLine($"Sum is: {sum}");
        }
    }
}
