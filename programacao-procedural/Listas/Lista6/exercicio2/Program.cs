using System;

class Program
{
  static void Main(string[] args)
  {
    const int QUANTIDADE_NOMES = 10;
    string[] nomes = new string[QUANTIDADE_NOMES];
    string[] indicesPares = new string[5];

    for (int contador = 0; contador < QUANTIDADE_NOMES; contador++)
    {
      Console.WriteLine("Digite um nome: ");
      nomes[contador] = Console.ReadLine();
    }

    int contadorPares = 0;
    for (int contador = 0; contador < QUANTIDADE_NOMES; contador++)
    {
      if (contador % 2 == 0)
      {
        indicesPares[contadorPares] = nomes[contador];
        contadorPares++;
      }
    }

    for (int contador = 4; contador >= 0; contador--)
    {
      Console.WriteLine(indicesPares[contador]);
    }
  }
}