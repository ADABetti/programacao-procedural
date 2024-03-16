using System;

class Program
{
  static void Main(string[] args)
  {

    // int numero = 0;

    // do
    // {
    //   Console.WriteLine("Digite um numero de 1 a 9.");
    //   numero = int.Parse(Console.ReadLine());

    //   if (numero >= 1 && numero <= 9)
    //   {
    //     for (int i = 1; i <= numero; i++)
    //     {
    //       for (int j = 1; j <= i; j++)
    //       {
    //         Console.Write(j);
    //       }
    //       Console.WriteLine();
    //     }
    //   }
    //   else
    //   {
    //     Console.WriteLine("Altura invalida, insira uma altura entre 1 e 9.");
    //   }
    // }
    // while (numero < 1 || numero > 9);



    // outra forma de solucionar:
    int numero;
    do
    {
      Console.WriteLine("Digite um numero entre 1 e 9:");
      numero = int.Parse(Console.ReadLine());
      if (numero >= 1 && numero <= 9)
      {
        break;
      }
      Console.WriteLine("Altura invalida, insira uma altura válida");
    }
    while (true);

    if (numero >= 1 && numero <= 9)
    {
      for (int i = 1; i <= numero; i++)
      {
        for (int j = 1; j <= i; j++)
        {
          Console.Write(j);
        }
        Console.WriteLine();
      }
    }
  }
}

