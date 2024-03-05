//Crie um programa que reveba do usuário um número inteiro e imprima na tela a tabuada
//daquele número.

using System;

class Program
{
  static void Main (string[] args)
  {
    Console.WriteLine("Qual tabuada deseja calcular?");
    int numeroTabuada = int.Parse(Console.ReadLine());

    for (int i = 0; i <= 10 ; i++)
    {
      Console.WriteLine($"{numeroTabuada} * {i} = {numeroTabuada*i}");
    }
  }
}