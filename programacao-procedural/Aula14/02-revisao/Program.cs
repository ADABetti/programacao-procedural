using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite o valor de a: ");
    double a = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor de b: ");
    double b = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor de c: ");
    double c = double.Parse(Console.ReadLine());

    double[] raizes = new double CalcularRaizesEquacaoQuadratica(a, b, c);

    Console.WriteLine("X': " + raizes[0]);
    Console.WriteLine("X'': " + raizes[1]);
  }
  // Equação de 2ºgrau:
  // ax² + bx + c = 0;

  static double CalcularRaiz(double a, double b, double c)
  {
    return Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
  }

  static double[] CalcularRaizesEquacaoQuadratica(double a, double b, double c)
  {
    double[] raizes = new double[2];

    raizes[0] = (-b + CalcularRaiz(a, b, c)) / 2 * a;
    raizes[1] = (-b - CalcularRaiz(a, b, c)) / 2 * a;

    return raizes;
  }
}