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
    Game[] games = new Game[10]; // vetor de struct

    for (int i = 0; i < games.Length; i++)
    {
      games[i].id = int.Parse(Console.ReadLine());
      games[i].name = Console.ReadLine();
      games[i].price = double.Parse(Console.ReadLine());
    }

    for (int i = 0; i < games.Length; i++)
    {
      Console.WriteLine(games[i].id);
      Console.WriteLine(games[i].name);
      Console.WriteLine(games[i].price);
    }

  }
}