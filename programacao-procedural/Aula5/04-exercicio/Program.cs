using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite a idade da pessoa 1.");
    int idadePessoa1 = int.Parse(Console.ReadLine());
  
    Console.WriteLine("Digite a idade da pessoa 2.");
    int idadePessoa2 = int.Parse(Console.ReadLine());
  
    Console.WriteLine("Digite a idade da pessoa 3.");
    int idadePessoa3 = int.Parse(Console.ReadLine());

    if (idadePessoa1 > idadePessoa2 && idadePessoa1 > idadePessoa3)
    {
     Console.WriteLine("A maior das tres idades eh " + idadePessoa1);
    }         
    else if (idadePessoa1 < idadePessoa2 && idadePessoa2 > idadePessoa3)
    {
      Console.WriteLine("A maior das tres idades eh " + idadePessoa2);
    }
    else if (idadePessoa1 < idadePessoa3 && idadePessoa3 > idadePessoa2) 
    {
      Console.WriteLine("A maior das tres idades eh "+ idadePessoa3);
    }
    else
    {
      Console.WriteLine("A maior das idades eh "+ idadePessoa1);
    }
  }
}