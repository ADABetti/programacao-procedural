//Uma ótica criou uma promoção baseada na idade de seus clientes. Ela
//verifica qual a idade de uma pessoa e desconta do preço do óculos o equivalente 
//ao valor da idade (em reais). Crie um programa que receba a idade de uma pessoa
// e o preço do óculos que ela deseja comprar.
//Ao final seu programa deve exibir o preço do óculos descontado do valor da idade.

using System;

class Program{

  static void Main(string[] args)
  {
    Console.WriteLine("Digite sua idade.");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor do óculos.");
    double preco = double.Parse(Console.ReadLine());

    preco -= idade;

    Console.WriteLine($"O preco com desconto é {preco} reais.");
  }
}