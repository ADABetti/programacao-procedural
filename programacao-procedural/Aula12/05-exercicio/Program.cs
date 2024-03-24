using System;

class Program
{
  static void Main(string[] args)
  {

    //Criação da matriz
    int[,] matriz = new int[4, 4];

    // Preencher cada posição da matriz com o valor digitado pelo user.
    for (int linha = 0; linha < 4; linha++)
    {
      for (int coluna = 0; coluna < 4; coluna++)
      {
        matriz[linha, coluna] = int.Parse(Console.ReadLine());
      }
    }

    // Fazer somatorio de cada item da matriz
    int somatorio = 0;
    for (int linha = 0; linha < 4; linha++)
    {
      for (int coluna = 0; coluna < 4; coluna++)
      {
        somatorio += matriz[linha, coluna];
      }
    }

    Console.WriteLine($"A soma de todos os elementos da matriz eh: {somatorio}");
  }
}