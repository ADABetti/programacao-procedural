using System;

class Program
{
  static void Main(string[] args)
  {
    const int QUANTIDADE_LINHAS = 4;
    const int QUANTIDADE_COLUNAS = 4;
    int[,] matriz = new int[QUANTIDADE_LINHAS, QUANTIDADE_COLUNAS];

    for (int linha = 0; linha < QUANTIDADE_LINHAS; linha++)
    {
      for (int coluna = 0; coluna < QUANTIDADE_COLUNAS; coluna++)
      {
        matriz[linha, coluna] = int.Parse(Console.ReadLine());
      }
    }

    switch (Console.ReadLine())
    {
      case "1":
        for (int linha = 0; linha < QUANTIDADE_LINHAS; linha++)
        {
          for (int coluna = 0; coluna < QUANTIDADE_COLUNAS; coluna++)
          {
            Console.WriteLine(matriz[linha, coluna]);
          }
        }
        break;

      case "2":
        int somatorio = 0;
        for (int linha = 0; linha < QUANTIDADE_LINHAS; linha++)
        {
          for (int coluna = 0; coluna < QUANTIDADE_COLUNAS; coluna++)
          {
            somatorio += matriz[linha, coluna];
          }
        }
        Console.WriteLine(somatorio);
        break;

      case "3":
        int somatorioLinha = 0;
        for (int linha = 0; linha < QUANTIDADE_LINHAS; linha++)
        {
          for (int coluna = 0; coluna < QUANTIDADE_COLUNAS; coluna++)
          {
            if (linha == 2)
            {
              somatorioLinha += matriz[linha, coluna];
            }
          }
        }
        Console.WriteLine(somatorioLinha);
        break;

      case "4":
        int somatorioDiagonal = 0;
        for (int linha = 0; linha < QUANTIDADE_LINHAS; linha++)
        {
          for (int coluna = 0; coluna < QUANTIDADE_COLUNAS; coluna++)
          {
            if (linha == coluna)
            {
              somatorioDiagonal += matriz[linha, coluna];
            }
          }
        }
        Console.WriteLine(somatorioDiagonal);
        break;

      case "5":
        int somatorioIndicesPares = 0;
        for (int linha = 0; linha < QUANTIDADE_LINHAS; linha++)
        {
          for (int coluna = 0; coluna < QUANTIDADE_COLUNAS; coluna++)
          {
            if (linha == 1 && coluna % 2 == 0)
            {
              somatorioIndicesPares += matriz[linha, coluna];
            }
          }
        }
        Console.WriteLine(somatorioIndicesPares);
        break;

      default:
        Console.WriteLine("Você digitou um número inválido.");
        break;
    }
  }
}