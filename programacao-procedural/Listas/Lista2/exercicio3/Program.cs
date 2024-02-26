using System;

class Program
{
  static void Main (string[] args)
  {
    Console.WriteLine("Digite o nome da crianca para consultar sua rotina: ");
    string nomeDaCrianca = Console.ReadLine();

    if (nomeDaCrianca == "Filomena")
    {
      Console.WriteLine("Rotina de Filomena:\n1. Escola das 07h as 12h\n2. Almoco das 12h as 13\n3. Futebol das 14h as 16h\n4. Dever de casa das 16h as 18h");
    }
    else if (nomeDaCrianca == "Joselito")
    {
      Console.WriteLine("Rotina de Joselito:\n1. Escola das 07h as 12:30\n2. Almoco das 13h as 14h\n3. Natacao das 14h as 16h\n4. Reforco escolar das 16h as 19h");
    }
    else 
    {
      Console.WriteLine("Digite um nome valido.");
    }
  }
}