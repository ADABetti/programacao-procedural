//Faça um programa em C# que peça para o usuário digitar 10 números e determine quantos números são positivos e quantos são negativos.
// Ao final seu programa deve exibir a quantidade de números positivos e a quantidade de números negativos que foram digitados.
// OBS: Seu programa deve ser capaz de imprimir quantas vezes o número zero foi digitado

using System;

class Program
{
  static void Main(string[] args)
  {

    const int QUANTIDADE_NUMEROS_RECEBIDOS = 10;
    int numero = 0;
    int numerosNegativos = 0;
    int numerosPositivos = 0;
    int zeros = 0;


    for (int i = 0; i < QUANTIDADE_NUMEROS_RECEBIDOS; i++)
    {
      Console.WriteLine("Digite um numero: ");
      numero = int.Parse(Console.ReadLine());

      if (numero < 0)
      {
        numerosNegativos++;
      }
      else if (numero == 0)
      {
        zeros++;
      }
      else
      {
        numerosPositivos++;
      }
    }
    Console.WriteLine($"Numeros positivos: {numerosPositivos}\nNumeros negativos: {numerosNegativos}\nZero(s): {zeros}");
  }
}