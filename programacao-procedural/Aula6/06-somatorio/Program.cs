using System;

class Program
{
  static void Main (string[] args)
  {
    double somatorio = 0;
    string resposta = "s";

    while (resposta =="s")
    {
      Console.WriteLine("Digite o valor que deseja doar. ");
      double valorDigitado = double.Parse(Console.ReadLine());

      somatorio += valorDigitado;
      Console.WriteLine($"A vaquinha arrecadou {somatorio} ate agora");
      Console.WriteLine("Deseja continuar? [s]sim [n]não");
      resposta = Console.ReadLine();
    }
    Console.WriteLine($"Fechamos a vaquinha no valor de {somatorio}");
  }
}