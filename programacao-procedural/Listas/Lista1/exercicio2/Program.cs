using System;

class Program
{
  static void Main (string[] args)
  { 
    Console.WriteLine("Digite a altura do triangulo:");
    double alturaTriangulo = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a base do triangulo:");
    double baseTriangulo = double.Parse(Console.ReadLine());
  
    double area = (alturaTriangulo * baseTriangulo) / 2;

    bool verificarArea = area > 20;

    Console.WriteLine($"A area do triangulo eh maior que 20? {verificarArea}");
  }
} 
