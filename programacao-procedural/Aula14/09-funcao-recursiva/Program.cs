using System;

class Program
{
  static void Main(string[] args)
  {
    Contar(100);
  }

  static void Contar(int numero)
  {
    if (numero < 0)
    {
      return;
    }

    Console.WriteLine(numero);
    numero -= 3;
    Contar(numero);
  }
}
