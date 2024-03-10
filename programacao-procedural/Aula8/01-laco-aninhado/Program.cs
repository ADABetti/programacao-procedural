using System;

class Program
{
  static void Main(string[] args)
  {
    Tabuleiro.InicializaTabuleiro();

    for (int linha = 0; linha < 8; linha++)
    {
      for (int coluna = 0; coluna < 8; coluna++)
      {
        Tabuleiro.Adicionar(linha, coluna, "A"); // Faz todas as repetições do laço interno, depois sai do laço.
      }
    }
    Tabuleiro.ImprimeTabuleiro();
  }
}

