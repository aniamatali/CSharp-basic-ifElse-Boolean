using System;

  class drinkingAge
  {
        static void Main()
        {
          Console.WriteLine("How old are you?");
          string Age = Console.ReadLine();
          int ageInput = int.Parse(Age);

          if (ageInput < 21)
          {
            Console.WriteLine("Sorry youre a youngster");
          }
          else
          {
            Console.WriteLine("Drinking is Bad!");
          }

        }
  }
