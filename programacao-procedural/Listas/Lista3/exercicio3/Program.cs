using System;

class Program{

  static void Main (string[] args)
  {
    const string USUARIO = "adim";
    const string SENHA = "123senha";
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
        if (contador == 3)
        {
          Console.WriteLine("Sua conta foi bloqueada.");
          break;
        }
    }
    while (usuarioDigitado != USUARIO && senhaDigitada != SENHA);

      Console.WriteLine("Login realizado com sucesso.");
  }
}
