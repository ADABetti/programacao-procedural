using System;

class Program
{
  static void Main(string[] args)
  {
    // Receber idade do teclado e converter:
    int idadeRecebida = int.Parse(Console.ReadLine());

    // VerificarCategoria de acordo com a idade recebida e salvar o retorno em variavel:
    string categoria = VerificarCategoria(idadeRecebida);

    //Imprimir a variavel:
    Console.WriteLine(categoria);
  }

  static string VerificarCategoria(int idade)
  {
    if (idade < 12)
    {
      return "Infantil";
    }
    else if (idade >= 12 && idade <= 14)
    {
      return "Juvenil A";
    }
    else if (idade >= 15 && idade <= 17)
    {
      return "Juvenil B";
    }
    else
    {
      return "Adulto";
    }
  }
}