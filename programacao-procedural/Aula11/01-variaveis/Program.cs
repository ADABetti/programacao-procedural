using System;

class Program
{
  static void Main(string[] args)
  {
    int[] idades = new int[10];//criou uma região 10 vezes maior que o inteiro (4bites) = 40 bites na memória
    idades[0] = 22;
    Console.WriteLine($"A primeira idade eh: {idades[0]}");

    string[] nomes = new string[3]; //string é um vetor de char.
    nomes[0] = "Alice";
    nomes[1] = "Jujuba";
    nomes[2] = "Silvia";

    Console.WriteLine(nomes[2]);
    Console.WriteLine(nomes[1]);
    Console.WriteLine(nomes[0]);

    bool[] ehEaD = new bool[40];
    ehEaD[0] = true;
    ehEaD[30] = false;
    ehEaD[30] = true;
  }
}