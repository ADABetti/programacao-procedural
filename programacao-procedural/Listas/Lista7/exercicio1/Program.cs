using System;

class Program
{

  //Receber numero do teclado, chamar funcao de verificacao e imprimir retorno na tela:
  static void Main(string[] args)
  {
    int numeroRecebido = int.Parse(Console.ReadLine());
    bool ehPar = VerificarNumero(numeroRecebido);
    Console.WriteLine(ehPar);

  }

  //Fazer verificacao do numero:
  static bool VerificarNumero(int numero)
  {
    return numero % 2 == 0; // Se numero for divisivel por 2, retorna true.
  }
}