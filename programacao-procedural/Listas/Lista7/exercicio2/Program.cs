using System;

class Program
{

  static void Main(string[] args)
  {
    //Receber 3 numeros inteiros:
    int numeroRecebido1 = int.Parse(Console.ReadLine());
    int numeroRecebido2 = int.Parse(Console.ReadLine());
    int numeroRecebido3 = int.Parse(Console.ReadLine());

    //Salvar retorno da funcao em uma variavel:
    int maiorNumero = VerificarMaiorNumero(numeroRecebido1, numeroRecebido2, numeroRecebido3);

    //Imprimir valor da variavel:
    Console.WriteLine(maiorNumero);
  }

  static int VerificarMaiorNumero(int numero1, int numero2, int numero3)
  {

    if (numero1 >= numero2 && numero1 >= numero3)//Se numero 1 for o maior:
    {
      return numero1;
    }
    else if (numero1 <= numero2 && numero2 >= numero3) // Se numero 2 for o maior:
    {
      return numero2;
    }
    else // Caso nao entre em nenhum dos outros casos, o maior eh o 3:
    {
      return numero3;
    }
  }
}