using System;

class Program{

static void Main (string[] args)

  {

    // operadores aritméticos

    const double precoDaDuzia = 14.99;
    int quantidadeLaranjas = int.Parse(Console.ReadLine());

    double duzias = quantidadeLaranjas / 12;
    double resto = quantidadeLaranjas % 12;

    double precoFinal = (precoDaDuzia * duzias) + (resto / 12 * precoDaDuzia);

    Console.WriteLine($"O preco final eh: {precoFinal}");

    // Operadores relacionais

    bool teste = 2 == 1;
    bool teste2 = 7 > 6;
    bool teste3 = 8 != 4;

    Console.WriteLine(teste);
    Console.WriteLine(teste2);
    Console.WriteLine(teste3);

    // Par ou ímpar

    int numero = int.Parse(Console.ReadLine());
    bool ehPar = (numero % 2 == 0);

    Console.WriteLine($"Eh par?: {ehPar}");

  }

}