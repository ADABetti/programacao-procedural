//Crie um programa que some os números imáres que forem digitados até que sejam maiores que 50.
// Número pares não devem entrar no somatório.

using System;

class Program
{
  static void Main (string[] args)
  {
    int somatorio = 0;
    int numeroDigitado = 0;

    do
    {
      if(numeroDigitado % 2 == 1)
      {
        somatorio = somatorio + numeroDigitado;
      }
      Console.WriteLine("Digite um número:");
      numeroDigitado = int.Parse(Console.ReadLine());
    }
    while (somatorio <= 50);

    Console.WriteLine($"O somatório é: {somatorio}");
  }
}