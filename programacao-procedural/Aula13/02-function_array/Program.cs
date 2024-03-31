using System;

class Program
{

  static int GetMenorElemento(int[] vetor)
  {
    int menorElemento = int.MaxValue;

    for (int contador = 0; contador < vetor.Length; contador++)
    {
      if (vetor[contador] < menorElemento)
      {
        menorElemento = vetor[contador];
      }
    }

    return menorElemento;
  }
  static void Main(string[] args)
  {
    int[] vetor = { 3, -12, 7, 90, -25, 4 };

    int menorElemento = GetMenorElemento(vetor);

    Console.WriteLine($"O menor elemento eh: {menorElemento}");
  }
}