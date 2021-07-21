using System;
class Addiction{
  static void Main(string[] args){
    int number1, number2, result;
    Console.Write("Type a number as INTEGER: ");
    number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Type the second one.....: ");
    number2 = Convert.ToInt32(Console.ReadLine());
    result = addiction(number1, number2);
    Console.WriteLine("RESULT: [{0}] + [{1}] = {2}", number1, number2, result);

    exit("\npress any key to exit the process...");
  }
  static int addiction(int n1, int n2){
    if (n1 == 0){
      return n2;
    }else if(n2 == 0){
      return n1;
    }
    if (n2 < 0) { 
      return addiction(n1 - 1, n2 + 1);
    }
    return (n1 > n2 || n1 < 0) ? addiction(n1 + 1, n2 - 1) : addiction(n1 - 1, n2 + 1);
  }
  static void exit(string message){
    Console.Write(message);
    Console.ReadKey();
  }
}
