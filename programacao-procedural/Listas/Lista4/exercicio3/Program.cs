using System;

class Program
{
  static void Main(string[] args)
  {

    const int TAMANHO_TABULEIRO = 7;
    Tabuleiro.InicializaTabuleiro();

    for (int linha = 0; linha <= TAMANHO_TABULEIRO; linha++)
    {
      for (int coluna = 0; coluna <= TAMANHO_TABULEIRO; coluna++)
      {
        if (linha == 0 || linha == TAMANHO_TABULEIRO || coluna == 0 || coluna == TAMANHO_TABULEIRO)
        {
          Tabuleiro.Adicionar(linha, coluna, "S");
        }
      }
    }
    Tabuleiro.ImprimeTabuleiro();
  }
}



