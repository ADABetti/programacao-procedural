// Crie um programa que utilize laços de repetição para imprimir o seguinte padrão numérico:
// 123456789
// 12345678
// 1234567
// 123456
// 12345
// 1234
// 123
// 12
// 1

using System;

class Program
{
  static void Main(string[] args)
  {
    for (int linha = 9; linha >= 1; linha--)
    {
      for (int coluna = 1; coluna <= linha; coluna++)
      {
        Console.Write(coluna);
      }
      Console.WriteLine();
    }
  }
}