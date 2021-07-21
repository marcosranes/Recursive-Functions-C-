using System;
class Multiplication{
  static void Main(string[] args){
    int result = multiplication(25, 10);
    Console.WriteLine(result);

    exit("\npress any key to exit the process...");
  }

  static int multiplication(int num1, int num2){
    if (num1 == 0 || num2 == 0){
      return 0;
    }/*else if (num2 == 1){   //optional
      return num1;
    }*/else {
      return (num1 + multiplication(num1, num2 - 1));
    }
  }
  static void exit(string message){
    Console.Write(message);
    Console.ReadKey();
  }
}
