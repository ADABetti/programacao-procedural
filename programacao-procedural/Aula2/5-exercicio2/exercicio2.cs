// Crie um programa que peça para uma pessoa digitar seu nome e seu salário, armazene em variáveis e ao final imprima uma mensagem "Seu nome é: xx. Seu salário é XX)

using System;

class Program {
  static void Main (string [] args)
  {
    Console.WriteLine ("Digite seu nome: ");
    string nome = Console.ReadLine();

    Console.WriteLine ("Digite seu salário em reais: ");
    double salario = double.Parse(Console.ReadLine()); 
 
    Console.WriteLine($"Seu nome é {nome}. Seu salário é R${salario}.");
  }
}