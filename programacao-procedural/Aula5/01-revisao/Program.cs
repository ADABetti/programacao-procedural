using System;

class Program
{
  static void Main (string[] args)
  {
    Console.WriteLine("Digite um número inteiro:");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
      Console.WriteLine("O numero eh par.");
    } 
    else 
    {
      Console.WriteLine("O numero eh impar");
    }
  }
}