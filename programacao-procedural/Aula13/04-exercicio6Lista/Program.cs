using System;

class Program
{

  static void PreencherMatriz(int[,] matriz)
  {
    for (int linha = 0; linha < matriz.GetLength(0); linha++)
    {
      for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
      {
        matriz[linha, coluna] = int.Parse(Console.ReadLine());
      }
    }
  }

  static void ImprimirMatriz(int[,] matriz)
  {
    for (int linha = 0; linha < matriz.GetLength(0); linha++)
    {
      for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
      {
        Console.WriteLine(matriz[linha, coluna]);
      }
    }
  }

  static void SomarElementosMatriz(int[,] matriz)
  {
    int somatorio = 0;
    for (int linha = 0; linha < matriz.GetLength(0); linha++)
    {
      for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
      {
        somatorio += matriz[linha, coluna];
      }
    }
    Console.WriteLine(somatorio);
  }
  static void ExecutarAcao(int[,] matriz)
  {
    Console.WriteLine("EScolha a ação que deseja realizar: ");
    Console.WriteLine("[1] - Imprimir todos os elementos da matriz:");
    Console.WriteLine("[2] - Somar todos os elementos da matriz:");

    int acaoEscolhida = int.Parse(Console.ReadLine());

    if (acaoEscolhida == 1)
    {
      ImprimirMatriz(matriz);
    }
    else if (acaoEscolhida == 2)
    {
      SomarElementosMatriz(matriz);
    }
  }
  public static void Main(string[] args)
  {
    const int TAMANH0_MATRIZ = 4;
    int[,] matriz = new int[TAMANH0_MATRIZ, TAMANH0_MATRIZ];

    PreencherMatriz(matriz);

    ExecutarAcao(matriz);
  }
}