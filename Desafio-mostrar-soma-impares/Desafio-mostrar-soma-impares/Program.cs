using System;

namespace TESTE
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, menor, maior, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x < y)
            {
                menor = x;
                maior = y;
            }
            else
            {
                menor = y;
                maior = x;
            }

            soma = 0;
            for (int i = menor + 1; i < maior; i++)
            {
                if (i % 2 == 1)
                {
                    soma = i;    
                }
            }

            Console.WriteLine(soma);

        }
    }
}