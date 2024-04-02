using System;

class Program
{
  static void Main(string[] args)
  {
    const int QUANTIDADE_VAGOES = 12;
    int[] vagoes = new int[QUANTIDADE_VAGOES];

    PreencherVagao(vagoes);
    VerificarCarga(vagoes);
  }

  static void PreencherVagao(int[] vagoes)
  {
    for (int i = 0; i < vagoes.Length; i++)
    {
      vagoes[i] = int.Parse(Console.ReadLine());
    }
  }

  static void VerificarCarga(int[] vagoes)
  {
    for (int i = 0; i < vagoes.Length; i++)
    {
      if (vagoes[i] > 50)
      {
        Console.WriteLine($"{i}º vagão ultrapassou o limite de peso.");
      }
    }
  }
}