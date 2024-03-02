using System;

class Program
{
  static void Main (string[] args)
  {
    const int VALOR_MAXIMO = 10;
    Console.WriteLine("Digite o numero para calcular a tabuada.");
    int numeroParaCalcularTabuada = int.Parse(Console.ReadLine());

    int contador = 1;

    while (contador <= VALOR_MAXIMO)
    { 
      Console.WriteLine($"{numeroParaCalcularTabuada} * {contador} = {numeroParaCalcularTabuada * contador}");
      contador++;
    }
  }
}