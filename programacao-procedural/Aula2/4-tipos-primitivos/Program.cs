using System;

class Program {

  static void Main (string[] args)
  {
    Console.WriteLine ("Digite sua idade: ");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine ("Digite a sua altura");
    double altura = double.Parse(Console.ReadLine());
  
  Console.WriteLine($"sua idade é {idade} anos e sua altura é {altura}m");
  }
}