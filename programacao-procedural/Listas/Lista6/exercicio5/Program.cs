using System;

class Program
{
  static void Main(string[] args)
  {
    // Criar vetor:
    int[] vetor = new int[10];
    int numeroDigitado = 0;

    // Preencher vetor SE número recebido do usuário for >= 10 e <= 50: 
    for (int contador = 0; contador < vetor.Length; contador++)
    {
      bool valido = false;
      while (valido == false)
      {
        Console.WriteLine("Digite um número: ");
        numeroDigitado = int.Parse(Console.ReadLine());

        if (numeroDigitado >= 10 && numeroDigitado <= 50)
        {
          vetor[contador] = numeroDigitado;
          valido = true; // Quando esta varíavel é true, o programa sai do "while".
        }
      }
    }

    // Imprimir vetor:
    for (int contador = 0; contador < vetor.Length; contador++)
    {
      Console.WriteLine(vetor[contador]);
    }
  }
}