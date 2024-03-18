using System;

class Program
{
  static void Main(string[] args)
  {

    int somatorioImpares = 0;

    do
    {
      Console.WriteLine("Digite um número inteiro: ");
      int numeroDigitado = int.Parse(Console.ReadLine());

      if (numeroDigitado < 0)
      {
        break;
      }
      else if (numeroDigitado % 2 == 1)
      {
        somatorioImpares = somatorioImpares + numeroDigitado;
      }
    }
    while (true);

    Console.WriteLine($"O somatorio de impares eh: {somatorioImpares}");
  }
}