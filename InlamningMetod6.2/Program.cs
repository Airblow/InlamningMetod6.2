using System;

namespace InlamningMetod6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1 = 15;
            int tal2 = 23;

            int largestNumber = Störst(tal1, tal2);
            Console.WriteLine($"Det största talet utav {tal1} och {tal2} är {largestNumber}");

            Console.ReadKey();

        }

        static int Störst(int tal1, int tal2)
        {
            if (tal1 >= tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }

        }

    }

}
