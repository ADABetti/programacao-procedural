using System;

class Program
{
  static void Main(string[] args)
  {
    System.Console.WriteLine("Qual o tamanho do triangulo?");
    int tamanhoTriangulo = int.Parse(Console.ReadLine());

    for (int linha = 0; linha < tamanhoTriangulo; linha++)
    {
      for (int coluna = 0; coluna <= linha; coluna++)
      {
        Console.Write("*"); //Imprime todos os asteriscos de uma coluna na mesma linha
      }
      Console.WriteLine(); //Pula linha depois de sair do primeiro laço de repetição;

    }
  }
}