using System;

struct Enxadrista
{
  public int id;
  public string nome;
  public int rating;

}

class Program
{
  static void Main(string[] args)
  {
    Enxadrista[] enxadristas = new Enxadrista[4]; // Enxadrista é o tipo de dado. o vetor é: enxadristas.

    for (int i = 0; i < enxadristas.Length; i++)
    {
      enxadristas[i].id = int.Parse(Console.ReadLine());
      enxadristas[i].nome = Console.ReadLine();
      enxadristas[i].rating = int.Parse(Console.ReadLine());
    }

    for (int i = enxadristas.Length - 1; i >= 0; i--)
    {
      Console.WriteLine(enxadristas[i].id);
      Console.WriteLine(enxadristas[i].nome);
      Console.WriteLine(enxadristas[i].rating);
    }
  }
}