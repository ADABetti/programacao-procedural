//Crie um programa que utilize laços de repetição para imprimir o seguinte padrão numérico:
// 9
// 98
// 987
// 9876
// 98765
// 987654
// 9876543
// 98765432
// 987654321

using System;

class Program
{
  static void Main(string[] args)
  {
    for (int linha = 9; linha > 0; linha--)
    {
      for (int coluna = 9; coluna >= linha; coluna--)
      {
        Console.Write(coluna);
      }
      Console.WriteLine();
    }
  }
}