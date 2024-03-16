//Você deve criar um programa que simule um timer (um relógio que conta o tempo regressivamente). Seu timer deve ser capaz de exibir corretamente a contagem regressiva de dois minutos (120 segundos) no formato:

using System;

class Program
{
  static void Main(string[] args)
  {
    // Console.WriteLine("2:0");
    // for (int minutos = 1; minutos >= 0; minutos--)
    // {
    //   for (int segundos = 59; segundos >= 0; segundos--)
    //   {
    //     Console.WriteLine($"{minutos}:{segundos}");
    //   }
    // }

    //Outra forma de solucionar:
    for (int cotador = 120; contador >= 0; contador--)
    {
      int minutos = contador / 60;
      int segundos = contador % 60;

      Console.WriteLine($"{minutos}:{segundos}");
    }
  }
}