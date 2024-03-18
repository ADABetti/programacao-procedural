// Crie um programa que utilize laços de repetição para imprimir o seguinte padrão numérico:
// 1
// 12
// 123
// 1234
// 12345
// 123456
// 1234567
// 12345678
// 123456789

using System;

class Program
{
  static void Main(string[] args)
  {
    for (int linha = 1; linha <= 9; linha++)
    {
      for (int coluna = 1; coluna <= linha; coluna++)
      {
        Console.Write(coluna);
      }
      Console.WriteLine();
    }
  }
}