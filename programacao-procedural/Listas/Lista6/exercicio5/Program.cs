using System;

class Program
{
  static void Main(string[] args)
  {

    int[] vetor = new int[10];
    int numeroDigitado = 0;

    for (int contador = 0; contador < vetor.Length; contador++)
    {
      Console.WriteLine("Digite um número: ");
      numeroDigitado = int.Parse(Console.ReadLine());

      if (numeroDigitado >= 10 && numeroDigitado <= 50)
      {
        vetor[contador] = numeroDigitado;
      }
      else
      {
        contador--;
      }
    }

    for (int contador = 0; contador < vetor.Length; contador++)
    {
      Console.WriteLine(vetor[contador]);
    }
  }
}