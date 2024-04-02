using System;

class Program
{
  static void Main(string[] args)
  {
    const int TAMANHO_MATRIZ = 4;
    int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

    PreencherMatriz(matriz);

    if (VerificarNumeroZero(matriz))
    {
      Console.WriteLine("Fique atento! existem balistas no tabuleiro");
    }
    else
    {
      Console.WriteLine("nao ha balistas no tabuleiro");
    }
  }

  static void PreencherMatriz(int[,] matriz)
  {
    for (int i = 0; i < matriz.GetLength(0); i++) // linhas
    {
      for (int j = 0; j < matriz.GetLength(1); j++) // colunas
      {
        matriz[i, j] = int.Parse(Console.ReadLine());
      }
    }
  }

  static bool VerificarNumeroZero(int[,] matriz)
  {
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
      for (int j = 0; j < matriz.GetLength(1); j++)
      {
        if (matriz[i, j] == 0)
        {
          return true;
        }
      }
    }
    return false;
  }
}
