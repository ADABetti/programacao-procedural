using System;

class Program
{
  static void Main(string[] args)
  {
    char[,] marVermelho = new char[9, 9];

    // Adicionar valores na matriz
    for (int linha = 0; linha < 9; linha++)
    {
      for (int coluna = 0; coluna < 9; coluna++)
      {
        if (coluna < 3 || coluna > 5)
        {
          marVermelho[linha, coluna] = '~';
        }
        else
        {
          marVermelho[linha, coluna] = ' ';
        }
      }
    }

    // Imprimir matriz
    for (int linha = 0; linha < 9; linha++)
    {
      for (int coluna = 0; coluna < 9; coluna++)
      {
        Console.Write(marVermelho[linha, coluna]);
      }
      Console.WriteLine();
    }
  }
}