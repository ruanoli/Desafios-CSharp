using System; 

/*
Desafio
Você recebeu desafio para determinar qual dos produtos é o preferêncial dos clientes de um posto de abastecimento de combustível. Para isso você deve escrever um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4.

Entrada
A entrada contém apenas valores inteiros e positivos.

Saída
Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.
*/

namespace Preferencia_cliente
{
    class Program 
    {

        static void Main(string[] args) {
            int[] contador = new int[3];
            int entradaUsuario = 0;

            do
            {
                entradaUsuario = int.Parse(Console.ReadLine());

                switch (entradaUsuario)
                {
                    case 1:
                        contador[0]++;
                        break;
                    case 2:
                        contador[1]++;
                        break;
                    case 3:
                        contador[2]++;
                        break;
                    case 4:
                        Console.WriteLine("MUITO OBRIGADO");
                        break;
                    default:
                        continue;
                }
        } while (entradaUsuario != 4);

        Console.WriteLine("Alcool: " + contador[0]++);
        Console.WriteLine("Gasolina: " + contador[1]++);
        Console.WriteLine("Diesel: " + contador[2]++);

        }
    }
}