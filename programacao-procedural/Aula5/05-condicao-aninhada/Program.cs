using System;

class Program 
{
  static void Main (string[] args)
  {
    Console.WriteLine("Escolha um país para visitar: \n[1]- Pais do vento.\n[2]- Pais do fogo.");
    int paisEscolhido = int.Parse(Console.ReadLine());

    if (paisEscolhido == 1)
    {
      Console.WriteLine("Você escolheu o pais do vento!");
      Console.WriteLine("Escolha um ponto de exploracao para voce visitar:");
      Console.WriteLine("[1]- Aldeia da areia");
      Console.WriteLine("[2]- Mina");
      Console.WriteLine("[3]- Caatinga");
      
      int pontoDeExploracao = int.Parse(Console.ReadLine());

      if (pontoDeExploracao == 1)
      {
        Console.WriteLine("Bem vindo a aldeia da areia.");
      }
      else if (pontoDeExploracao == 2)
      {
        Console.WriteLine("Voce esta na minha.");
      }
      else
      {
        Console.WriteLine("Voce adentrou a caatinga.");
      }
    }
    else if (paisEscolhido == 2)
    {
      Console.WriteLine("Você escolheu o pais do fogo!");
      Console.WriteLine("Escolha um ponto de exploracao para voce visitar:");
      Console.WriteLine("[1]- Aldeia da folha.");
      Console.WriteLine("[2]- Floresta da morte.");
      
      int pontoDeExploracao = int.Parse(Console.ReadLine());

      if( pontoDeExploracao == 1)
      {
        Console.WriteLine("Bem vindo a aldeia da folha.");
      }
      else if (pontoDeExploracao == 2)
      {
        Console.WriteLine("Voce entrou na floresta da morte.");
      }
    }
    else
    {
      Console.WriteLine("Pais invalido.");
    }
  }
}