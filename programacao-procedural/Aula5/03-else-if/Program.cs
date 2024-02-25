using System;

class Program

{
  static void Main (string[] args)
  {
    const double pesoLeve = 60;
    const double pesoPena = 57;
    const double pesoGalo = 54;
  
    Console.WriteLine("Digite o seu peso:");
    double pesoLutador = double.Parse(Console.ReadLine());

    if (pesoLutador <= pesoGalo)
    {
      Console.WriteLine("Você está na categoria peso Galo.");
    } 
    else if (pesoLutador <= pesoPena)
    {
      Console.WriteLine("Você está na categoria peso Pena.");
    }
    else if (pesoLutador <= pesoLeve)
    {
      Console.WriteLine("Você está na categoria peso Leve.");
    }
    else
    {
      Console.WriteLine("Você não está apto a competir.");
    }
  }
}