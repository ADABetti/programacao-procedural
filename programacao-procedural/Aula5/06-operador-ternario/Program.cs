using System;

class Program
{
  static void Main(string [] args)
  {
    Console.WriteLine("Digite sua idade:");
    int idadeUsuario = int.Parse(Console.ReadLine());
    bool maiorDeIdade = (idadeUsuario >= 18) ? true : false;
    Console.WriteLine("O usuario eh maior de idade? " + maiorDeIdade);
  }
}

