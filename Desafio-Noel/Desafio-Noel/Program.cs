using System;

namespace _52._36_URI_1759
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                {
                    Console.Write("Ho ");
                }
                else
                {
                    Console.Write("Ho!");
                }
            }

        }
    }
}