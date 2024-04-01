using System;

class Program
{
  static void Main(string[] args)
  {
    int numero = int.Parse(Console.ReadLine());
    if (!ehPar(numero))
    {
      Console.WriteLine("Só entra no if quando o número for diferente de par");
    }
  }

  static bool ehPar(int numero)
  {
    return numero % 2 == 0;
  }
}