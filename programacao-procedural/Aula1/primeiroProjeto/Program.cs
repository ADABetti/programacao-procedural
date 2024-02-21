using System;

class Program {

static void countToTen (){
  for(int i = 0; i <10; i++){
    System.Console.WriteLine(i);
  }
}
  static void Main(string [] args){
    string name = System.Console.ReadLine();
    System.Console.Write("Hello" + name);
  countToTen();
  }

}