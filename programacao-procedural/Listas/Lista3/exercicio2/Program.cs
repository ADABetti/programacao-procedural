using System;

class Program{

  static void Main (string[] args)
  {

    const double VALOR_MINIMO = 150;
     double somatorioItens = 0;

    Console.WriteLine("Você mora no Estado de SP?\n [s]-sim.\n [n]-nao");
    string moraEmSP = Console.ReadLine();

    if (moraEmSP == "s")
    {
      Console.WriteLine("Digite a quantidade de itens comprados");
      int quantidadeItensComprados = int.Parse(Console.ReadLine());

      while (quantidadeItensComprados > 0)
      {
        Console.WriteLine("Digite o valor do item:");
        double valorDoItemAtual = double.Parse(Console.ReadLine());
        somatorioItens = somatorioItens + valorDoItemAtual;
        quantidadeItensComprados--;
      }  

      if(somatorioItens > VALOR_MINIMO)
      {
        Console.WriteLine($"Parabens! Voce ganhou frete gratis em sua compra de valor {somatorioItens}");
      } else {
        Console.WriteLine("A compra nao possui frete gratis.");
      }
    } else {
      Console.WriteLine("A compra nao possui frete gratis.");
    }
  }
}