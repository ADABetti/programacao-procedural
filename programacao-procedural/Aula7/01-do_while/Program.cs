using System;

class Program
{
  static void Main (string[] args)
  {
    
    double somatorio = 0;
    double numeroInserido = 0;

    do 
    {
      somatorio = somatorio + numeroInserido;
      Console.WriteLine("Digite o valor que deseja doar: ");
      numeroInserido = double.Parse(Console.ReadLine()); 
    }
    while(numeroInserido >= 0);

    Console.WriteLine($"O valor inserido é: {Math.Round(somatorio, 2)}");

  }
}