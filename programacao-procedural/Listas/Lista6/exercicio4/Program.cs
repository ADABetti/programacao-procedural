using System;

class Program
{
  static void Main(string[] args)
  {
    // Criar matriz:
    const int QUANTIDADE_LINHAS = 3;
    const int QUANTIDADE_COLUNAS = 3;
    int[,] matriz = new int[QUANTIDADE_LINHAS, QUANTIDADE_COLUNAS];

    // Preencher matriz:
    for (int linha = 0; linha < QUANTIDADE_LINHAS; linha++)
    {
      for (int coluna = 0; coluna < QUANTIDADE_COLUNAS; coluna++)
      {
        if (linha + coluna == 2)
        {
          matriz[linha, coluna] = (int.Parse(Console.ReadLine())) * 2;
        }
        else
        {
          matriz[linha, coluna] = int.Parse(Console.ReadLine());
        }
      }
    }

    // Imprimir matriz: 
    for (int linha = 0; linha < QUANTIDADE_LINHAS; linha++)
    {
      for (int coluna = 0; coluna < QUANTIDADE_COLUNAS; coluna++)
      {
        Console.Write(matriz[linha, coluna] + "|");
      }
      Console.WriteLine();
    }
  }
}