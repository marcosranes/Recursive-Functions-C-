using System;
class Factorial{
  static void Main(string[] args){
    int number, result;
    Console.Write("Type an int number: ");
    number = Convert.ToInt32(Console.ReadLine());
    result = factorial(number);
    Console.WriteLine("{0} ! = {1}", number, result);
  }
  static int factorial(int num){
    if (num == 0 || num == 1){
      return 1;
    }
    return (num * factorial(num - 1));
  }
}
