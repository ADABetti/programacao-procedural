using System;

class Program
{
  static void Main (string[] args)
  {
    int numero1 = 10;
    int numero2 = 3;
  
    double resultadoSoma = numero1 + numero2;
    double resultadoSubtracao = numero1 - numero2;
    double resultadoMultiplicacao = numero1 * numero2;
    double resultadoDivisao = numero1 / numero2;
  
    Console.WriteLine (resultadoSoma);
    Console.WriteLine (resultadoSubtracao);
    Console.WriteLine (resultadoMultiplicacao);
    Console.WriteLine (resultadoDivisao);
  }
}