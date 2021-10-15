﻿using System;

/*
Desafio
Para dar conta de toda a fabricação dos presentes de Natal, por várias vezes os elfos precisam ficar até tarde trabalhando para que tudo possa ser terminado a tempo.

Para melhor gerenciar seus cronogramas, os elfos estipularam quantos minutos são necessários para fabricar cada presente.

Já está quase no final do expediente, e um dos elfos pediu sua ajuda.

Faltam N minutos para a hora de ir embora, e restam dois presentes para o elfo Dobby fabricar. Ajude-o a descobrir se ele conseguirá fabricar os dois ainda hoje, ou se deve deixar o trabalho para amanhã.

Entrada
Cada caso de teste inicia com um inteiro N, indicando quantos minutos faltam para o final do expediente (2 <= N <= 100).

Em seguida haverá dois inteiros A e B, indicando quantos minutos são necessários para fabricar os dois presentes que Dobby precisa fabricar (1 <= A, B <= 100).
*/

class Program 
{
    public static void Main (string[] args)  
    {
      
    int n = int.Parse(Console.ReadLine());
    string[] line = Console.ReadLine().Split(" ");
    
    int presente1 = int.Parse(line[0]), presente2 = int.Parse(line[1]);
    int soma = presente1 + presente2;
    
    if (soma > n) 
    {
      Console.Write("Deixa para amanha!");
    } 
    else 
    {
      Console.Write("Farei hoje!");
    }   
  }
}
