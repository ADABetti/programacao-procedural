// Crie um programa que receba uma quantidade de dias e converta em anos.

using System;

class Program
{
  static void Main (string[] args)
  {
    Console.WriteLine("Digite a quantidade de dias para converter em anos:");

    int totalDias = int.Parse(Console.ReadLine());

    int quantidadeAnos = totalDias / 365;
    int quantidadeDias = totalDias % 365;

    Console.WriteLine($"A quantidade de dias {totalDias}, é igual a {quantidadeAnos} ano(s) e {quantidadeDias} dia(s).");
  }
}