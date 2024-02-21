// Crie um programa que receba o peso e altura de uma pessoa e calcule seu IMC.

using System;

class Program
{
  static void Main (string [] args)
  {
    Console.WriteLine("Digite seu peso em KG.");
    double peso = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite sua altura em metros.");
    double altura = double.Parse(Console.ReadLine());

    double imc = Math.Round(peso / (altura * altura),2);
    Console.WriteLine($"Seu imc é: {imc}.");
  }
}