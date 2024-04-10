using System;

// criar struct:
struct Product
{
  public int id;
  public string name;
  public double price;
  public bool available;
}

class Program
{

  // Criar vetor:  
  static void Main(string[] args)
  {
    Product[] products = new Product[4];

    FillArray(products);
    PrintIfAvailable(products);
  }

  // Preencher vetor:
  static void FillArray(Product[] products)
  {
    for (int i = 0; i < products.Length; i++)
    {
      products[i].id = int.Parse(Console.ReadLine());
      products[i].name = Console.ReadLine();
      products[i].price = double.Parse(Console.ReadLine());
      products[i].available = bool.Parse(Console.ReadLine());
    }
  }

  // Imprimir produtos disponíveis:
  static void PrintIfAvailable(Product[] products)
  {
    for (int i = 0; i < products.Length; i++)
    {
      if (products[i].available)
      {
        Console.WriteLine(products[i].name);
        Console.WriteLine(products[i].price);
      }
    }
  }
}