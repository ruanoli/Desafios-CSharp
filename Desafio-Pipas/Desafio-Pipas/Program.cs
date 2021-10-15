using System;

class TESTE
{

    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        long resposta = (n * (n - 3) / 2); 
        Console.WriteLine(resposta);
    }

}