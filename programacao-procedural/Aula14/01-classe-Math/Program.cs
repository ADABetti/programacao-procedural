using System;

class Program
{
  static void Main(string[] args)
  {
    double numero = 16;
    numero = Math.Pow(numero, 2);// Pow = potência.

    Console.WriteLine(numero);

    numero = Math.Sqrt(numero);
    Console.WriteLine(numero);

    Random aleatorio = new Random();
    int numeroAleatorio = aleatorio.Next(0, 8);
    Console.WriteLine(numeroAleatorio);
  }
}