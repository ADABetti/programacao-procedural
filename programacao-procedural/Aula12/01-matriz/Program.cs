using System;

class Program
{
  static void Main(string[] args)
  {

    const int LINHAS = 4;
    const int COLUNAS = 5;
    int[,] numeros = new int[LINHAS, COLUNAS]; //Matriz 4 x 5

    // [-, -, -, -, -]
    // [-, -, -, -, -]
    // [-, -, -, -, -]
    // [-, -, -, -, -]

    //PREENCHER MATRIZ:
    for (int linha = 0; linha < LINHAS; linha++)
    {
      for (int coluna = 0; coluna < COLUNAS; coluna++)
      {
        numeros[linha, coluna] = 9;
      }
    }

    //IMPRIMIR MATRIZ:
    for (int linha = 0; linha < LINHAS; linha++)
    {
      for (int coluna = 0; coluna < COLUNAS; coluna++)
      {
        Console.Write(numeros[linha, coluna]);
      }
      Console.WriteLine();
    }

  }
}
