using System;

class Program
{
  static void Main(string[] args)
  {
    int[,] matriz = new int[8, 8];

    //Adicionar valores na matriz
    for (int linha = 0; linha < 8; linha++)
    {
      for (int coluna = 0; coluna < 8; coluna++)
      {
        if (linha == coluna)
        {
          matriz[linha, coluna] = 1;
        }
      }
    }

    //Imprimir Matriz:
    for (int linha = 0; linha < 8; linha++)
    {
      for (int coluna = 0; coluna < 8; coluna++)
      {
        Console.Write(matriz[linha, coluna]);
      }
      Console.WriteLine();
    }
  }
}