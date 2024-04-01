using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite a medida do cateto 1:");
    double cateto1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a medida do cateto 2:");
    double cateto2 = double.Parse(Console.ReadLine());

    double hipotenusa = CalcularHipotenusa(cateto1, cateto2);
    Console.WriteLine(hipotenusa);
  }

  static double CalcularHipotenusa(double cateto1, double cateto2)
  {
    return Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
  }
}