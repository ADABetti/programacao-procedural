using System;

class Program
{


  static void escolherPais()
  {
    Console.WriteLine("Qual país deseja viajar?\n[1]-País do Fogo\n[2] País do Vento");
    string paisEscolhido = Console.ReadLine();

    if (paisEscolhido == "1")
    {
      //função de explorar o país do fogo.
      VisitarPaisDoFogo();
    }
    else if (paisEscolhido == "2")
    {
      //função de explorar o país do vento.
      VisitarPaisDoVento();
    }
  }

  static void VisitarPaisDoFogo()
  {
    Console.WriteLine("Qual área deseja explorar?\n[1]-Aldeia da folha\n[2]-Floresta da morte");
    string pontoExploracao = Console.ReadLine();

    if (pontoExploracao == "1")
    {
      Console.WriteLine("Voce adentrou: Aldeia da folha");
    }
    else
    {
      Console.WriteLine("Voce adentrou: Floresta da morte");
    }
  }

  static void VisitarPaisDoVento()
  {
    Console.WriteLine("Qual área deseja explorar?\n[1]-Aldeia da areia\n[2]-Mina\n[3]-Caatinga");
    string pontoExploracao = Console.ReadLine();

    if (pontoExploracao == "1")
    {
      Console.WriteLine("Voce adentrou: Aldeia da areia");
    }
    else if (pontoExploracao == "2")
    {
      Console.WriteLine("Voce adentrou: Mina");
    }
    else
      Console.WriteLine("Voce adentrou: Caatinga");
  }

  static void Main(string[] args)
  {
    escolherPais();
  }
}