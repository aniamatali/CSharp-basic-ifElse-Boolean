using System;

class addsubtract
{
  static void Main()
  {
    Console.WriteLine("Please enter a number");
    string inputNumber = Console.ReadLine();
    int inputNumberInt = int.Parse(inputNumber);

    if (inputNumberInt % 2 == 0)
    {
      Console.WriteLine(inputNumberInt + 1);
    }
    else
    {
      Console.WriteLine(inputNumberInt - 1);
    }
  }
}
