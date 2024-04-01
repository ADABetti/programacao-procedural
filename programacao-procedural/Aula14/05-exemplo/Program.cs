//Jogo

/*
Caverna1:
####
####
#O##
####
####

*/

using System;

class Program
{
  static void Main(string[] args)
  {
    const int TAMANHO_MINA = 5;
    char[,] mina = new char[TAMANHO_MINA, TAMANHO_MINA];

    GerarMina(mina);
    ImprimirMina(mina);
  }

  static void ImprimirMina(char[,] mina)
  {
    for (int linha = 0; linha < mina.GetLength(0); linha++)
    {
      for (int coluna = 0; coluna < mina.GetLength(1); coluna++)
      {
        Console.Write(mina[linha, coluna]);
      }
      Console.WriteLine();
    }
  }
  static void GerarMina(char[,] mina)
  {
    Random aleatorio = new Random();
    int linhaSaida = aleatorio.Next(0, mina.GetLength(0) - 1);
    int colunaSaida = aleatorio.Next(0, mina.GetLength(1) - 1);
    mina[linhaSaida, colunaSaida] = 'O';

    for (int linha = 0; linha < mina.GetLength(0); linha++)
    {
      for (int coluna = 0; coluna < mina.GetLength(1); coluna++)
      {
        if (mina[linha, coluna] != 'O')
        {
          mina[linha, coluna] = '#';
        }
      }
    }
  }


}