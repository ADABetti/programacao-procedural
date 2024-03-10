//Crie um programa que receba o peso e a altura de uma pessoa, calcule e exiba seu IMC. A formula para calculo do IMC é:

//imc = peso / (alltura * altura)

using System;

class program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite sua altura:");
    double altura = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite seu peso:");
    double peso = double.Parse(Console.ReadLine());

    double imc = Math.Round(peso / (altura * altura), 2);

    Console.WriteLine($"O IMC dessa pessoa eh: {imc}.");
  }
}