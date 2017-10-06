using System;

    class twoDigits
    {
      static void Main()
      {
        Console.WriteLine("Enter a number");
        string inputNumber = Console.ReadLine();
        int inputNumberInt = int.Parse(inputNumber);

        if ((inputNumberInt > 9)  && (inputNumberInt< 100))
        {
          Console.WriteLine("That's a two digit number");
        }
        else
        {
          Console.WriteLine("That's not a two digit number");
        }
      }
    }
