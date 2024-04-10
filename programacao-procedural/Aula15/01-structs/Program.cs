using System;

struct Aluno
{
  public string name;
  public int age;
  public bool ehCasado;
}
class Program
{
  static void Main(string[] args)
  {
    Aluno pessoa1;
    pessoa1.name = "Alice";
    pessoa1.age = 23;
    pessoa1.ehCasado = true;
  }
}