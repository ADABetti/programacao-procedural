using System;

class Program {

  static void Main(string[] args)

  {
    Console.WriteLine("A lâmpada está ligada?");
    bool lampadaLigada = bool.Parse(Console.ReadLine());

    lampadaLigada = !lampadaLigada;

    Console.WriteLine($"Lampada ligada: {lampadaLigada}");
  }

}