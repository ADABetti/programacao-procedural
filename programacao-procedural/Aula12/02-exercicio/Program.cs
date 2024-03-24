//Crie uma matriz de char 3x3 que receba 9 letras e guarde cada uma delas em uma posição. Ao final, seu programa deve exibir as letras guardadas de trás para frente. Seu programa deve pular uma linha após imprimir uma linha completa da matriz

using System;

class Program
{
  static void Main(string[] args)
  {
    char[,] matriz = new char[3, 3];

    //Preencher a matriz:
    for (int linha = 0; linha < 3; linha++)
    {
      for (int coluna = 0; coluna < 3; coluna++)
      {
        matriz[linha, coluna] = char.Parse(Console.ReadLine());
      }
    }

    // Imprimir a matriz:
    for (int linha = 2; linha >= 0; linha--)
    {
      for (int coluna = 2; coluna >= 0; coluna--)
      {
        Console.WriteLine(matriz[linha, coluna]);
      }
      Console.WriteLine();
    }
  }
}