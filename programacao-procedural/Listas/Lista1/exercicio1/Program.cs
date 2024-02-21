using System;

class Program
{
  static void Main (String[] args)
  {
    Console.WriteLine("Digite a nota da Prova 1.");
    double nota1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota da Prova 2.");
    double nota2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota da Prova 3.");
    double nota3 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota da Prova 4.");
    double nota4 = double.Parse(Console.ReadLine());

    double somaDasNotas = nota1 + nota2 + nota3 + nota4;
    double mediaDasNotas = somaDasNotas / 4;

    Console.WriteLine($" A media do aluno eh: {mediaDasNotas}");
  }
}