using System;

class Program
{
  static void Main (string [] args)
  {
    int idade = (int) 19.5; // int não aceita decimais,mas se usar o casting (int) ele elimina o decimal.
   
    Console.WriteLine(idade);
  }
}