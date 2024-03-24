using System;
class Program
{
  static void Main(string[] args)
  {
    int contador = 0;
    int[] numerosPares = new int[5];

    while (contador < 5)
    {
      int numero = int.Parse(Console.ReadLine());
      if (numero % 2 == 0)
      {
        numerosPares[contador] = numero;
        contador++;
      }
    }
    for (contador = 0; contador < 5; contador++)
    {
      Console.WriteLine(numerosPares[contador]);
    }
  }
}