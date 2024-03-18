//Crie um programa que receba sucessivamente vários números inteiros do usuário. Os números devem ser salvos em um somatório. O programa deve parar de receber números quando um número negativo for digitado e, ao final, deve-se ser impresso o valor do somatório.

using System;

class Program
{
  static void Main(string[] args)
  {
    // int numeroDigitado = 0;
    // int somatorioPositivos = 0;

    // do
    // {
    //   Console.WriteLine("Digite um numero inteiro");
    //   numeroDigitado = int.Parse(Console.ReadLine());

    //   if (numeroDigitado > 0)
    //   {
    //     somatorioPositivos = somatorioPositivos + numeroDigitado;
    //   }
    // }
    // while (numeroDigitado >= 0);

    // Console.WriteLine("O somatorio eh: " + somatorioPositivos);

    //Outra forma de solucionar:

    int somatorio = 0;

    do
    {
      int numeroRecebido = int.Parse(Console.ReadLine());

      if (numeroRecebido < 0)
      {
        break;
      }
      somatorio = somatorio + numeroRecebido;
    } while (true);

    Console.WriteLine("O somatorio eh: " + somatorio);
  }
}