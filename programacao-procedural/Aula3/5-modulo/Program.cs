using System;

class Program
{
  static void Main (string [] args)
  {
    Console.WriteLine("Digite o tempo em minutos: ");
    int tempoInicial = int.Parse(Console.ReadLine());

    int minutos = tempoInicial / 60;
    int segundos = tempoInicial % 60;

    Console.WriteLine ($"O tempo em minutos é: {minutos}min e {segundos}seg.");
  }
}