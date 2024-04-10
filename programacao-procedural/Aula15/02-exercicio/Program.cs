// Crie um programa que contenha uma struct que representa um Jogo. A struct Jogo deve ter um id, um nome e um preco. O id, nome e preço do jogo devem ser recebidos pelo teclado e armazenados na struct. Ao final, seu programa deve imprimir o id, o nome e o preco do jogo.

using System;

struct Game
{
  public int id;
  public string name;
  public double price;
}
class Program
{
  static void Main(string[] args)
  {
    Game firstGame;
    firstGame.id = int.Parse(Console.ReadLine());
    firstGame.name = Console.ReadLine();
    firstGame.price = double.Parse(Console.ReadLine());

    Console.WriteLine(firstGame.id);
    Console.WriteLine(firstGame.name);
    Console.WriteLine(firstGame.price);
  }
}