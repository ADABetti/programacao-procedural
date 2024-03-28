using System;

class Program
{
  static void Main(string[] args)
  {
    // Criar vetor:
    const int QUANTIDADE_NOMES = 10;
    string[] nomes = new string[QUANTIDADE_NOMES];

    // Receber 10 nomes:
    for (int contador = 0; contador < QUANTIDADE_NOMES; contador++)
    {
      Console.WriteLine("Digite um nome: ");
      nomes[contador] = Console.ReadLine();
    }

    // Imprimir nomes do fim para o começo, dos índices pares do vetor:
    for (int contador = QUANTIDADE_NOMES - 1; contador >= 0; contador--)
    {
      if (contador % 2 == 0)
      {
        Console.WriteLine(indicesPares[contador]);
      }
    }
  }
}