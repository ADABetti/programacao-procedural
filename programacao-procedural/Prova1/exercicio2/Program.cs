// Crie um programa que receba o sexo e a idade de uma pessoa. Se o sexo for masculino e a idade for igual a 18 o programa deve exibir a mensagem “precisa realizar o alistamento militar”. Caso contrário o programa deve exibir a mensagem “não precisa realizar o alistamento militar”

using System;

class program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Digite seu sexo: \n[F]-Feminino\n[M]-Masculino.");
    string sexo = Console.ReadLine();

    Console.WriteLine("Digite sua idade: ");
    int idade = int.Parse(Console.ReadLine());

    if (sexo == "M" && idade == 18)
    {
      Console.WriteLine("precisa realizar o alistamento militar.");
    }
    else
    {
      Console.WriteLine("não precisa realizar o alistamento militar.");
    }
  }
}