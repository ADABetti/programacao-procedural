// Crie um programa que receba o nome da rua e o CEP de uma pessoa e imprima essas infos ao final.

using System;

class Program 
{
  static void Main (string[] args)
  {
    Console.WriteLine ("Digite o nome da rua:");
    string nomeDaRua = Console.ReadLine();

    Console.WriteLine ("Digite o número da sua residência:");
    int numeroResidencia = int.Parse(Console.ReadLine());

    Console.WriteLine ("Digite o seu CEP:");
    string cep = Console.ReadLine();

    Console.WriteLine($"O seu endereço é rua: {nomeDaRua}, {numeroResidencia} - CEP {cep}.");
  }
}