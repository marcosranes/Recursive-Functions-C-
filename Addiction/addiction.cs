using System;
class Addiction{
  static void Main(string[] args){
    int number1, number2, result;
    Console.Write("Type an int number1: ");
    number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Type an int number2: ");
    number2 = Convert.ToInt32(Console.ReadLine());
    result = addiction(number1, number2);
    Console.WriteLine("Solution: {0} + {1} = {2}", number1, number2, result);
  }
  static int addiction(int n1, int n2){
    if (n1 == 0){
      return n2;
    }else if(n2 == 0){
      return n1;
    } 
    return addiction(n1 + 1, n2 - 1);
  }
}
