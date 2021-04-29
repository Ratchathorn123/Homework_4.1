using System;

namespace Homework_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int layer;
            Console.WriteLine("Put a layer of Pascal Triangle :");
            layer = int.Parse(Console.ReadLine());
            int layer2 = layer + 1;
            Pascaltriangle(ref layer2);
        }
        static void Pascaltriangle(ref int layer2)
        {
            int row = 1, blank, a, b;
            for (a = 0; a < layer2; a = a + 1)
            {
                for (blank = 10; blank <= layer2 - a; blank++)
                    Console.Write(" ");
                for (b = 0; b <=a; b = b + 1)
                {
                    if (b == 0 || a == 0)
                        row = 1;
                    else
                        row = row * (a - b + 1) / b;
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
