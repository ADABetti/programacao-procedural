using System;

class Program
{
  static void Main(string[] args)
  {

    const int QUANTIDADE_PESSOAS = 4;
    const int QUANTIDADE_DADOS = 3;

    //Criação da matriz
    string[,] pessoas = new string[QUANTIDADE_PESSOAS, QUANTIDADE_DADOS];

    for (int pessoaAtual = 0; pessoaAtual < QUANTIDADE_PESSOAS; pessoaAtual++)
    {
      for (int dadoAtual = 0; dadoAtual < QUANTIDADE_DADOS; dadoAtual++)
      {
        pessoas[pessoaAtual, dadoAtual] = Console.ReadLine();
      }
    }

    for (int pessoaAtual = QUANTIDADE_PESSOAS - 1; pessoaAtual >= 0; pessoaAtual--)
    {
      for (int dadoAtual = 0; dadoAtual < QUANTIDADE_DADOS; dadoAtual++)
      {
        Console.WriteLine(pessoas[pessoaAtual, dadoAtual]);
      }
    }
  }
}