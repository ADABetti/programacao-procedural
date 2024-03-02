//Crie um programa para imprimir todos os números de 0 até 100.
//Depois faça a contagem de 100 até 0.

using System;

class Program
{
  static void Main (string[] args)
  {
    const int VALOR_MAXIMO = 100;
    const int VALOR_MINIMO = 0;

    int numero = 0;
    while (numero <= VALOR_MAXIMO)
    {
      Console.WriteLine(numero);
      numero++;
    }

    numero--;

    while (numero >= VALOR_MINIMO)
    {
      Console.WriteLine(numero);
      numero--;
    }
  }
}