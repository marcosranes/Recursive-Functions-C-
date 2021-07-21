using System;
class Factorial{
  static void Main(string[] args){
    int number, result;
    Console.Write("Type an int number: ");
    number = Convert.ToInt32(Console.ReadLine());
    result = factorial(number);
    Console.WriteLine("{0} ! = {1}", number, result);

    exit("\npress any key to exit the process...");
  }
  static int factorial(int num){
    if (num == 0 || num == 1){
      return 1;
    }
    return (num * factorial(num - 1));
  }
  static void exit(string message){
    Console.Write(message);
    Console.ReadKey();
  }
}
