//Crie um programa que receba o nome de 4 pessoas e armazene em um vetor de string. Depois de receber os nomes, seu programa deve percorrer o vetor verificando se um dos nomes digitados era “Jose”. Se o nome “Jose” estiver no vetor, seu programa deve exibir a mensagem “Jose foi encontrado na lista”, caso contrário deve ser impressa a mensagem “Jose nao foi encontrado na lista”
using System;

class Program
{
  static void Main(string[] args)
  {
    string[] nomes = new string[4];

    for (int contador = 0; contador < nomes.Length; contador++)
    {
      Console.WriteLine("Digite um nome: ");
      nomes[contador] = Console.ReadLine();
    }

    bool temJose = false;
    for (int contador = 0; contador < nomes.Length; contador++)
    {
      if (nomes[contador] == "Jose")
      {
        temJose = true;
      }
    }

    if (temJose)
    {
      System.Console.WriteLine("Jose foi encontrado na lista");
    }
    else
    {
      System.Console.WriteLine("Jose nao foi encontrado na lista");
    }
  }
}