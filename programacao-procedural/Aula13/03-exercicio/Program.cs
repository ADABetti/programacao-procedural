// Crie um programa que contenha uma função para realizar Login. Sua função deve receber como parâmetros o nome e a senha de um usuário e verificar se eles são iguais a "admin" e "senha123", respectivamente. Caso sejam, sua função deve retornar true, caso contrário, deve retornar false.
// Ao final, seu programa deve exibir a mensagem "Login realizado com sucesso!" caso a função retorne true e "Falha no login" caso contrário.

using System;

class Program
{

  static bool FazerLogin(string usuario, string senha)
  {
    return usuario == "admin" && senha == "senha123";
  }
  static void Main(string[] args)
  {
    string usuarioDigitado = Console.ReadLine();
    string senhaDigitada = Console.ReadLine();

    if (FazerLogin(usuarioDigitado, senhaDigitada))
    {
      Console.WriteLine("Login realizado com sucesso!");
    }
    else
    {
      Console.WriteLine("Falha no login");
    }
  }
}