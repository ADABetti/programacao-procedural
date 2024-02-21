// Crie um programa que receba o nome e o sobrenome de uma pessoa e ao final a cumprimente dizendo "Olá, Nome Sobrenome".

using System;
class Program {
  static void Main (string[] args)
  {
    Console.WriteLine("Digite o seu primeiro nome: ");
    string primeiroNome = Console.ReadLine();

    Console.WriteLine("Digite o seu sobrenome: ");
    string sobrenome = Console.ReadLine();

    Console.WriteLine("Olá " + primeiroNome + " " + sobrenome);
    Console.WriteLine($"Olá {primeiroNome} {sobrenome}");
  }
}