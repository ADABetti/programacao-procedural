using System;

class Program
{
  static void Main (string[] args)
  {
    Console.WriteLine("Digite o nome de usuario: ");
    string nomeDoUsuario = Console.ReadLine();

    Console.WriteLine("Digite sua senha: ");
    string senhaDoUsuario = Console.ReadLine();

    if (nomeDoUsuario == "admin" && senhaDoUsuario == "123senha")
    {
      Console.WriteLine("Login realizado com sucesso!");
    }
    else
    {
      Console.WriteLine("Credenciais invalidas.");
    }
  }
}