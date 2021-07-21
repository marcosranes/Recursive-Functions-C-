using System;
class Power{
  static void Main(string[] args){
    double number1, number2, result, res;
    Console.Write("Type the BASE number: ");
    number1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Define its EXPONENT: ");
    number2 = Convert.ToDouble(Console.ReadLine());
    result = power(number1, number2);
    Console.WriteLine("Recursive SOLUTION: {0} ^ {1} = {2}", number1, number2, result);
    res = Math.Pow(Convert.ToDouble(number1), Convert.ToDouble(number2));
    Console.WriteLine("Proof of Work: Math.Pow({0}, {1}) = {2}", number1, number2, res);
    
    exit("\npress any key to exit the process...");
  }
  static double power(double n1, double n2){
    if(n2 == 0){
      return 1;
    }
    return n1 * power(n1, n2 - 1);
  }
  static void exit(string message){
    Console.Write(message);
    Console.ReadKey();
  }
}
