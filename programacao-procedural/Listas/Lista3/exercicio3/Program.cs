using System;

class Program
{

  static void Main(string[] args)
  {

    string usuarioDigitado = "";
    string senhaDigitada = "";
    int contador = 0;


    do
    {

      Console.WriteLine("Digite seu usuario: ");
      usuarioDigitado = Console.ReadLine();

      Console.WriteLine("Digite sua senha: ");
      senhaDigitada = Console.ReadLine();

      contador++;

      if (usuarioDigitado == "admin" && senhaDigitada == "123senha")
      {
        Console.WriteLine("Login realizado com sucesso.");
      }
      else if (contador == 3)
      {
        Console.WriteLine("Sua conta foi bloqueada.");
        break;
      }
      else
      {
        Console.WriteLine("Senha ou usuário incorreto(s). Tente novamente");
      }
    }

    while (usuarioDigitado != "admin" || senhaDigitada != "123senha");
  }
}
