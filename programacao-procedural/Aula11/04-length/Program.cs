using System;

class Program
{
  static void Main(string[] args)
  {
    double[] salarios = { 1400, 2600, 7100, 1900 };// usar as chaves preenche o vetor com já com os dados
    double maiorSalario = 0;

    for (int contador = 0; contador < salarios.Length; contador++)
    {
      if (salarios[contador] > maiorSalario)
      {
        maiorSalario = salarios[contador];
      }
    }

    System.Console.WriteLine(maiorSalario);
  }
}