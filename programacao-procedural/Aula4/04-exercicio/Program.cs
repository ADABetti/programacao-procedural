using System;

class Program{

  static void Main (string[] args){

    Console.WriteLine("Qual a sua idade?");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Sua nacionalidade eh xurupitense?");
    bool nacionalidade = bool.Parse(Console.ReadLine());

    Console.WriteLine("Você é graduado em economia?");
    bool graduacaoEconomia = bool.Parse(Console.ReadLine());

    Console.WriteLine("Você é graduado em gestao de politicas publicas?");
    bool graduacaoPoliticas = bool.Parse(Console.ReadLine());

    bool podeSeCandidatar = (idade >= 30 && nacionalidade) && (graduacaoEconomia || graduacaoPoliticas);
    Console.WriteLine($"A pessoa pode se candidatar: {podeSeCandidatar}");

  }
  
}