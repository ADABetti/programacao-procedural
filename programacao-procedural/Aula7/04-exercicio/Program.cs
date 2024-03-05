using System;

class Program
{
  static void Main (string[] args)
  {
    const string REPOSTA_CORRETA = "Karpov";
    const int PONTUACAO_INICIAL = 100;
    const int NUMERO_MAXIMO_TENTATIVAS = 3;

    int contadorTentativas =1;

    do
    {
      Console.WriteLine("[Dica] - Foi campeão mundial de xadrez");
      Console.WriteLine("Digite o valor do campo: ");
      string respostaUsuario = Console.ReadLine();
      if (respostaUsuario == REPOSTA_CORRETA)
      {
        double pontuacaoFinal = PONTUACAO_INICIAL / contadorTentativas;
        Console.WriteLine("Você acertou! A sua pontuacao final foi: " + pontuacaoFinal);
        break;
      } else {
        Console.WriteLine($"Resposta incorreta. Voce tem {NUMERO_MAXIMO_TENTATIVAS - contadorTentativas} chances.");
      }
      contadorTentativas++;

    }
    while (contadorTentativas <= NUMERO_MAXIMO_TENTATIVAS);

    if (contadorTentativas > NUMERO_MAXIMO_TENTATIVAS)
    {
      Console.WriteLine("GAME OVER!");
    }
  }

}