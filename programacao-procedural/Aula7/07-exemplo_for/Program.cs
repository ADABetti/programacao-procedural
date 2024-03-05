using System;

class Program
{
  static void Main(string[] args)
  {
    const int NUMERO_JOGADORES = 5;
    double somatorioAltura = 0;
    double maiorAltura = 0;

    for (int contador = 1; contador <= NUMERO_JOGADORES; contador++)
    {
      Console.WriteLine("Digite a altura do " + contador + "º jogador:");
      double alturaJogadorAtual = double.Parse(Console.ReadLine());

      somatorioAltura = somatorioAltura + alturaJogadorAtual;

      if(alturaJogadorAtual > maiorAltura)
      {
        maiorAltura = alturaJogadorAtual;
      }
    }

    double alturaMediaTime = somatorioAltura / NUMERO_JOGADORES;

    Console.WriteLine($"A media de altura do time eh: "
     + Math.Round(alturaMediaTime, 2) + " m");
    Console.WriteLine($"A pessoa mais alta mede: " 
    + Math.Round(maiorAltura,2) + " m");

  }
}