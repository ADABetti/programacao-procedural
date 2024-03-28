using System;

class Program
{
  static void Main(string[] args)
  {
    //Criar matriz: 
    const int LINHAS = 3;
    const int COLUNAS = 3;
    int[,] numeros = new int[LINHAS, COLUNAS];

    // Criar varíavel para somar os número da diagonal principal:
    int somatorioDiagonal = 0;

    // Preencher matriz:
    for (int linha = 0; linha < LINHAS; linha++)
    {
      for (int coluna = 0; coluna < COLUNAS; coluna++)
      {
        numeros[linha, coluna] = int.Parse(Console.ReadLine());

        if (linha == coluna) // Diagonal principal
        {
          somatorioDiagonal += numeros[linha, coluna];
        }
      }
    }

    // Imprimir valor da varíavel que fez somatório:
    Console.WriteLine(somatorioDiagonal);
  }
}