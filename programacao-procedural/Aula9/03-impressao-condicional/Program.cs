// Crie um programa que receba um número inteiro do usuário. Se o número recebido for positivo, seu programa deve exibir o somatório de todos os números ímpares de 0 até esse número. Se o número recebido for negativo, seu programa deve exibir a contagem de todos os números pares de 0 até esse número. Por fim, se o número digitado for 0, seu programa deve imprimir a mensagem: "nada a fazer aqui" e finalizar;
using System;

class Program
{
  static void Main(string[] args)
  {

    Console.WriteLine("Digite um numero inteiro: ");
    int numeroDigitado = int.Parse(Console.ReadLine());

    if (numeroDigitado > 0)
      int somatorioImpares = 0;
    {
      for (int i = 0; i <= numeroDigitado; i++)
      {
        if (i % 2 == 1)
        {
          somatorioImpares = somatorioImpares + numeroDigitado;
        }
      }
      Console.WriteLine($"O somatorio de todos numeros impares eh: {somatorioImpares}");
    }
    else if (numeroDigitado < 0)
    {
      for (int i = 0; i >= numeroDigitado; i--)
      {
        if (i % 2 == 0)
        {
          Console.WriteLine(i);
        }
      }
    }
    else
    {
      Console.WriteLine("nada a fazer aqui");
    }
  }
}