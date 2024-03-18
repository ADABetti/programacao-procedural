// Crie um programa que conte de 0 até 99, de 3 em 3

using System;

class program
{
  static void Main(string[] args)
  {
    // for (int i = 0; i < 100; i++)
    // {
    //   if (i % 3 == 0)
    //   {
    //     Console.WriteLine(i);
    //   }
    // }

    //Outra solução:
    for (int i = 0; i <= 99; i += 3)
    {
      Console.WriteLine(i);
    }
  }
}