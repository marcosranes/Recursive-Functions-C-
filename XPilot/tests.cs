using System;
class Subtraction{
  static void Main(string[] args){
    int number1, number2, result;
    Console.Write("Type an int number1: ");
    number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Type an int number2: ");
    number2 = Convert.ToInt32(Console.ReadLine());
    result = subtraction(number1, number2);
    Console.WriteLine(result);

    exit();
  }
  static int subtraction(int n1, int n2){
    if(n2 == 0){
      return n1;
    }else{
      if(n2 < 0)
        return subtraction(n1 + 1, n2 + 1);
    } 
    return subtraction(n1 - 1, n2 - 1);
  }

  static void exit(){
    string message = "\npress any key to exit the process...";
    Console.Write(message);
    Console.ReadKey();
  }
}
