using System;

class Program {

  static void Main (string[] args)

  {
    Console.WriteLine("Você possui o convite?");
    bool possuiConvite = bool.Parse(Console.ReadLine());

    Console.WriteLine("Digite sua idade:");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Está acompanhada de alguém maior de idade?");
    bool estaAcompanhada = bool.Parse(Console.ReadLine());

    bool podeEntrarNaFesta = possuiConvite && (idade >= 18 || estaAcompanhada);
    Console.WriteLine($"A pessoa pode entrar na festa? {podeEntrarNaFesta}");
  }
  
}