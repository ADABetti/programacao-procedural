using System;

class Program{

  static void Main (string[] args)
  {
    const int CASAS_DECIMAIS = 2;
    const int QUANTIDADE_HABITANTES = 3;
    double somatorioSalarios = 0;
    double maiorSalario = 0;
    int somatorioFilhos = 0;

    for ( int i = 1; i <= QUANTIDADE_HABITANTES; i++)
    {
      Console.WriteLine($"Habitante {i}, digite seu salario:");
      double salarioHabitanteAtual = double.Parse(Console.ReadLine());
      somatorioSalarios = somatorioSalarios + salarioHabitanteAtual;

      if (salarioHabitanteAtual > maiorSalario)
      {
        maiorSalario = salarioHabitanteAtual;
      }

      Console.WriteLine("Quantos filhos você tem?");
      int quantidadeFilhosHabitanteAtual = int.Parse(Console.ReadLine());
      somatorioFilhos = somatorioFilhos + quantidadeFilhosHabitanteAtual;
    }

    double mediaSalarios = somatorioSalarios / QUANTIDADE_HABITANTES;
    int mediaFilhos = somatorioFilhos / QUANTIDADE_HABITANTES;

    Console.WriteLine($"A media salarial por habitante eh: {Math.Round(mediaSalarios,CASAS_DECIMAIS)} reais.");
    Console.WriteLine($"O maior salario eh: {maiorSalario} reais.");
    Console.WriteLine($"A media de filhos por habitante eh: {mediaFilhos} filho(s).");
    
  }
}