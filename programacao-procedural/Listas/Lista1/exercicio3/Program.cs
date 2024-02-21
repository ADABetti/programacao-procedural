using System;

class Program
{
  static void Main (string[] args)
  {
    Console.WriteLine("Digite a quantidade de moedas.");
    int quantidadeMoedas = int.Parse(Console.ReadLine());

    int quantidadeEmReais = quantidadeMoedas / 100;
    int quantidadeEmCentavos = quantidadeMoedas % 100;

    Console.WriteLine($" O total em dinheiro eh: {quantidadeEmReais} real(is) e {quantidadeEmCentavos} centavo(s).");
  }
}