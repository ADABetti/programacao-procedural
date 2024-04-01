using System;

class Program
{
  static void Main(string[] args)
  {
    int tentativas = 0;
    bool estaLogado = false;
    do
    {
      Console.WriteLine("Digite o nome do usuário: ");
      string nomeUsuario = Console.ReadLine();

      Console.WriteLine("Digite a senha: ");
      string senhaUsuario = Console.ReadLine();

      if (Login(nomeUsuario, senhaUsuario))
      {
        estaLogado = true;
        break;
      }
      Console.WriteLine("Credenciais inválidas, tente novamente.");
      tentativas++;
    }

    while (tentativas <= 3);

    if (estaLogado)
    {
      Console.WriteLine("Login realizado com sucesso.");
    }
    else
    {
      Console.WriteLine("Senha bloqueada.");
    }
  }

  static bool Login(string nomeUsuario, string senha)
  {
    return nomeUsuario == "admin" && senha == "senha123";
  }
}