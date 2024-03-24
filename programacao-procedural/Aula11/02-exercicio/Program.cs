using System;

class Program
{
  static void Main(string[] args)
  {
    int[] idades = new int[3];

    for (int contador = 0; contador < 3; contador++)
    {
      idades[contador] = int.Parse(Console.ReadLine());
    }

    for (int contador = 2; contador >= 0; contador--)
    {
      Console.WriteLine(idades[contador]);
    }
  }
}