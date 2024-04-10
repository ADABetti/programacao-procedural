using System;

struct Pizza
{
  public int id;
  public string flavor;
  public double price;
}

class Program
{
  static void Main(string[] args)
  {
    Pizza pizza1;
    pizza1.id = int.Parse(Console.ReadLine());
    pizza1.flavor = Console.ReadLine();
    pizza1.price = double.Parse(Console.ReadLine());

    Console.WriteLine(pizza1.id);
    Console.WriteLine(pizza1.flavor);
    Console.WriteLine(pizza1.price);
  }
}