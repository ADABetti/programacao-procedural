using System;

class Program
{
  static void Main(string[] args)
  {
    double resultado = ElevarAoQuadrado(Somar(1, 1));
    Console.WriteLine(resultado);
  }

  static double Somar(double a, double b)
  {
    return a + b;
  }

  static double ElevarAoQuadrado(double numero)
  {
    return numero * numero;
  }
}
