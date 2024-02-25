using System;

class Program
{
  static void Main (string[] args)
  {
    const double saldo = 200;
    
    Console.WriteLine("Digite o valor do presente:");
    double valorDoPresente = double.Parse(Console.ReadLine());

    if (valorDoPresente <= saldo)
    {
      Console.WriteLine("Compra realizada com sucesso.");
    }
    else
    {
      Console.WriteLine("Saldo insuficiente para realizar a compra.");
    }
  }
}