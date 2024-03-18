using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite a altura do retângulo");
    int alturaRetangulo = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a base do retângulo");
    int baseRetangulo = int.Parse(Console.ReadLine());

    for (int linha = 1; linha <= alturaRetangulo; linha++)
    {
      for (int coluna = 1; coluna <= baseRetangulo; coluna++)
      {
        Console.Write("*");
      }
      Console.WriteLine();
    }

  }
}