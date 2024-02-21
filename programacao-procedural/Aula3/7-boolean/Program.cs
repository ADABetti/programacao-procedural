using System;

class Program{
  static void Main(string[] args)
  {
    bool expressaoLogica1 = (2>=2);
    bool expressaoLogica2 = (2==2);
    bool expressaoLogica3 = (1>2);
    Console.WriteLine(expressaoLogica1);
    Console.WriteLine(expressaoLogica2);
    Console.WriteLine(expressaoLogica3);

    Console.WriteLine("Digite sua senha: ");
    string senha = Console.ReadLine();
    bool senhaCorreta = (senha == "123");

    Console.WriteLine ("A senha está correta? " + senhaCorreta);


  }
}