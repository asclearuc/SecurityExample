using System;

namespace SecurityExample
{
    class Program
    {
        static public int getElement(int[] array, int index)
        {
            return array[index] * 2;
        }
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
                sum += Program.getElement(array, i);

            Console.WriteLine($"Sum is: {sum}");

            Environment.Exit(sum > 100 ? 0 : -1);
        }
    }
}
