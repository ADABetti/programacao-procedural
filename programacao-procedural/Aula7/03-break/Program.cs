using System;

class Program
{
  static void Main (string[] args)
  {
    int contador = 0;

    while (contador <= 10)
    { 
      Console.WriteLine($"contador = {contador}");
      if (contador > 7)
      {
        break;
      }
      contador++;
    }
  }
}