using System;

class Program
{
  static void Main(string[] args)
  {

    //Forma de solução 1.
    // for (int i = 0, j = 200; i <= 100; i += 2, j -= 4)// 0
    // {
    //   {
    //     Console.WriteLine($"{i} - {j}");
    //   }
    // }

    //Forma de solução 2.
    int regressivo = 200;
    for (int progressivo = 0; progressivo <= 100; progressivo += 2)
    {
      Console.WriteLine($"{progressivo} - {regressivo}");
      regressivo -= 4;
    }
  }
}