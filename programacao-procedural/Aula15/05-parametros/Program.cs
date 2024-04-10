using System;

struct Aluno
{
  public int matricula;
  public string nome;
  public double media;
}

class Program
{
  static void Main(string[] args)
  {
    Aluno[] alunos = new Aluno[3];

    for (int i = 0; i < alunos.Length; i++)
    {
      alunos[i].matricula = int.Parse(Console.ReadLine());
      alunos[i].nome = Console.ReadLine();
      alunos[i].media = double.Parse(Console.ReadLine());
    }

    VerificarAprovacao(alunos);
  }

  static void VerificarAprovacao(Aluno[] alunos)
  {
    for (int i = 0; i < alunos.Length; i++)
    {
      if (alunos[i].media >= 5)
      {
        Console.WriteLine($"{i + 1}º Aluno aprovado.");
      }
      else
      {
        Console.WriteLine("Aluno reprovado");
      }
    }
  }
}