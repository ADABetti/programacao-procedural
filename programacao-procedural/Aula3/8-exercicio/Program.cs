// Crie um programa que receba a idade de uma pessoa e, ao final, imprima true se a pessoa for maior de idade e false se ela for menor de idade.

using System;

class Program
{
  static void Main (string[] args)
  {
    // Console.WriteLine("Digite sua idade: ");
    // int idade = int.Parse(Console.ReadLine());

    // bool maiorDeIdade = (idade >= 18);
    // Console.WriteLine("Maior de idade? " + maiorDeIdade ); 

    // outra forma de solucionar:

    Console.WriteLine("Digite sua idade em dias: ");
    int idadeEmDias = int.Parse(Console.ReadLine());

    int diasEmAnos = idadeEmDias / 360;
    int diasRestantes = idadeEmDias % 360;

    bool maiorDeIdade = (diasEmAnos >= 18);
    Console.WriteLine("Maior de idade? " + maiorDeIdade );
    Console.WriteLine($"Você tem {diasEmAnos} anos." );
  }
}
