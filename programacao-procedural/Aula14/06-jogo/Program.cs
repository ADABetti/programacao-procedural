using System;

class Program
{
  static void Main(string[] args)
  {
    const int TAMANHO_EXERCITO = 5;
    int[] exercitoA = new int[TAMANHO_EXERCITO];
    int[] exercitoB = new int[TAMANHO_EXERCITO];

    PosicionarExercito(exercitoA);
    PosicionarExercito(exercitoB);

    Batalhar(exercitoA, exercitoB);

    ImprimirExercito(exercitoA);
    ImprimirExercito(exercitoB);

    ValidarExercitoVitorioso(exercitoA, exercitoB);
  }

  static void PosicionarExercito(int[] exercito)
  {
    for (int i = 0; i < exercito.Length; i++)
    {
      exercito[i] = int.Parse(Console.ReadLine());
    }
  }

  static void Batalhar(int[] exercitoA, int[] exercitoB)
  {
    for (int i = 0; i < exercitoA.Length; i++)
    {
      if (exercitoA[i] > exercitoB[i])
      {
        exercitoB[i] = 0;
      }
      else if (exercitoA[i] < exercitoB[i])
      {
        exercitoA[i] = 0;
      }
    }
  }

  static void ImprimirExercito(int[] exercito)
  {
    for (int i = 0; i < exercito.Length; i++)
    {
      Console.Write(exercito[i] + "|");
    }
    Console.WriteLine();
  }

  static void ValidarExercitoVitorioso(int[] exercitoA, int[] exercitoB)
  {
    int qtdMortosExercitoA = 0;
    int qtdMortosExercitoB = 0;

    for (int i = 0; i < exercitoA.Length; i++)
    {
      if (exercitoA[i] == 0)
      {
        qtdMortosExercitoA++;
      }
      else if (exercitoB[i] == 0)
      {
        qtdMortosExercitoB++;
      }
    }

    if (qtdMortosExercitoA < qtdMortosExercitoB)
    {
      Console.WriteLine("Vitoria do exercito A");
    }
    else if (qtdMortosExercitoA > qtdMortosExercitoB)
    {
      Console.WriteLine("Vitoria do exercito B");
    }
    else
    {
      Console.WriteLine("Empate");
    }
  }
}