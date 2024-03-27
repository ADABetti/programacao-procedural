using System;

class Program
{
  static void Main(string[] args)
  {
    const int LINHAS = 3;
    const int COLUNAS = 3;
    int[,] numeros = new int[LINHAS, COLUNAS];
    int somatorioDiagonal = 0;

    for (int linha = 0; linha < LINHAS; linha++)
    {
      for (int coluna = 0; coluna < COLUNAS; coluna++)
      {
        numeros[linha, coluna] = int.Parse(Console.ReadLine());

        if (linha == coluna)
        {
          somatorioDiagonal += numeros[linha, coluna];
        }
      }
    }
    Console.WriteLine(somatorioDiagonal);

  }
}