using System;

class Program
{
  static void Main(string[] args)
  {
    // Criar matriz:
    const int QUANTIDADE_LINHAS = 4;
    const int QUANTIDADE_COLUNAS = 4;
    int[,] matriz = new int[QUANTIDADE_LINHAS, QUANTIDADE_COLUNAS];

    // Preencher matriz com dados recebidos do usuário:
    for (int linha = 0; linha < QUANTIDADE_LINHAS; linha++)
    {
      for (int coluna = 0; coluna < QUANTIDADE_COLUNAS; coluna++)
      {
        matriz[linha, coluna] = int.Parse(Console.ReadLine());
      }
    }

    //Receber número do usuário:
    string numeroDigitado = Console.ReadLine();

    // Executar uma ação de acordo com número digitado pelo usuário:
    if (numeroDigitado == "1")
    {
      for (int linha = 0; linha < QUANTIDADE_LINHAS; linha++)
      {
        for (int coluna = 0; coluna < QUANTIDADE_COLUNAS; coluna++)
        {
          Console.WriteLine(matriz[linha, coluna]);
        }
      }
    }
    else if (numeroDigitado == "2")
    {
      int somatorio = 0;
      for (int linha = 0; linha < QUANTIDADE_LINHAS; linha++)
      {
        for (int coluna = 0; coluna < QUANTIDADE_COLUNAS; coluna++)
        {
          somatorio += matriz[linha, coluna];
        }
      }
      Console.WriteLine(somatorio);
    }
    else if (numeroDigitado == "3")
    {
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
    }
    else if (numeroDigitado == "4")
    {
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
    }
    else if (numeroDigitado == "5")
    {
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
    }
    else
    {
      Console.WriteLine("Você digitou um número inválido.");
    }
  }
}