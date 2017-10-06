using System;

class RatedR
{
  static void Main()
  {
    Console.WriteLine("How old are you?");
    string stringUserAge = Console.ReadLine();
    int intUserAge = int.Parse(stringUserAge);

    if (intUserAge >= 17)
    {
      Console.WriteLine("you can see the movie!");
    }
    else
    {
      Console.WriteLine("Im sorry you're too young");
    }
  }
}
