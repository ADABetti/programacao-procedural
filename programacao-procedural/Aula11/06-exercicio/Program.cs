//Crie um programa que receba o nome de 4 pessoas e armazene em um vetor de string. Depois de receber os nomes, seu programa deve percorrer o vetor verificando se um dos nomes digitados era “Jose”. Se o nome “Jose” estiver no vetor, seu programa deve exibir a mensagem “Jose foi encontrado na lista”, caso contrário deve ser impressa a mensagem “Jose nao foi encontrado na lista”
using System;

class Program
{
  static void Main(string[] args)
  {

    const int NUMERO_PESSOAS = 5;

    string[] nomes = new string[NUMERO_PESSOAS];
    int[] idades = new int[NUMERO_PESSOAS];
    bool[] ehCasado = new bool[NUMERO_PESSOAS];

    for (int contador = 0; contador < NUMERO_PESSOAS; contador++)
    {
      Console.WriteLine("Digite o nome da pessoa: ");
      nomes[contador] = Console.ReadLine();

      Console.WriteLine("Digite a idade da pessoa: ");
      idades[contador] = int.Parse(Console.ReadLine());

      Console.WriteLine("A pessoa é casada? ");
      ehCasado[contador] = bool.Parse(Console.ReadLine());
    }

    Console.WriteLine("As pessoas casadas sao:");

    for (int contador = 0; contador < NUMERO_PESSOAS; contador++)
    {
      if (ehCasado[contador])
      {
        Console.WriteLine($"{nomes[contador]},de {idades[contador]} anos");
      }
    }
  }
}