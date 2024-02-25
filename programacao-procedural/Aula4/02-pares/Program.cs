using System;

class Program{

  static void Main (string[] args){

    Console.WriteLine("Digite seu sexo:");
    string sexo = Console.ReadLine();

    Console.WriteLine("Digite sua idade:");
    int idade = int.Parse(Console.ReadLine());

    bool femininoEQuinzeAnos = (sexo == "feminino") && (idade == 15);
    Console.WriteLine("Festa de debutante: " + femininoEQuinzeAnos);

  }

}