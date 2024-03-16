// Crie um programa que exiba, simultâneamente, uma contagem progressiva e uma contagem regressiva na tela. A contagem progressiva deve partir do 0 e chegar ao 50 e a contagem regressiva deve partir do 50 e chegar ao 0. A saída deve ser impressa conforme o exemplo de saída.

using System;

class Program
{
  static void Main(string[] args)
  {

    // int regressivo = 50;

    // for (int progressivo = 0; progressivo <= 50; progressivo++)
    // {
    //   Console.WriteLine($"{progressivo} - {regressivo}");

    //   regressivo--;
    // }

    //Outra forma de resolver:

    for (int progressivo = 0, regressivo = 50; progressivo <= 50; progressivo++, regressivo--)
    {
      Console.WriteLine($"{progressivo} - {regressivo}");

    }

  }
}