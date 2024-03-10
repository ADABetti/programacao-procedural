// Crie um programa que pergunte as idades de 10 alunos da turma 2024 do Programando seu Futuro e calcule a idade média da turma.

using System;

class Program
{
  static void Main(string[] args)
  {
    const int QUANTIDADE_ALUNOS = 2;
    int somatorio = 0;

    for (int i = 0; i < QUANTIDADE_ALUNOS; i++)
    {
      Console.WriteLine("Digite sua idade: ");
      int idade = int.Parse(Console.ReadLine());
      somatorio = somatorio + idade;
    }

    double mediaIdades = (somatorio / QUANTIDADE_ALUNOS);

    Console.WriteLine($"A média das idades dos alunos eh: {Math.Round(mediaIdades, 2)}");
  }
}