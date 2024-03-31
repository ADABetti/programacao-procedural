// Crie um programa que contenha uma função para verificar se uma pessoa é maior de idade. Seu programa deve receber a idade de uma pessoa e passar essa idade como parâmetro para uma função. Se a idade for maior ou igual a 18, sua função deve retornar true. Caso contrário, a função retorna false.
//Por fim, seu programa deve imprimir true quado a pessoa for maior de idade e false quando não for.

using System;

class Program
{

  static bool MaiorDeIdade(int idade)
  {
    // if (idade >= 18)
    // {
    //   return true;
    // }
    // return false;

    return idade >= 18;
  }
  static void Main(string[] args)
  {
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine(MaiorDeIdade(idade));

    if (MaiorDeIdade(idade))
    {
      Console.WriteLine("O usuario eh maior de idade.");
    }
    else
    {
      Console.WriteLine("O usuario eh menor de idade");
    }
  }
}