using System;

class Program
{
  static void Main (string[] args)
  {
    Console.WriteLine ("Digite a nota da prova 1.");
    double notaProva1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine ("Digite a nota da prova 2.");
    double notaProva2 = double.Parse(Console.ReadLine());

    Console.WriteLine ("Digite a nota da prova 3.");
    double notaProva3 = double.Parse(Console.ReadLine());

    Console.WriteLine ("Digite a nota da prova 4.");
    double notaProva4 = double.Parse(Console.ReadLine());

    double mediaDoAluno = (notaProva1 + notaProva2 + notaProva3 + notaProva4) / 4;
  
    if (mediaDoAluno >= 5)
    {
      Console.WriteLine("Aluno aprovado.");
    }
    else if (mediaDoAluno < 5 && mediaDoAluno >= 3)
    {
      Console.WriteLine("Aluno em recuperacao.");
    }
    else
    {
      Console.WriteLine("Aluno reprovado.");
    }
  }
}