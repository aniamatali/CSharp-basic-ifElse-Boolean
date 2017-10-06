using System;

class StartsWithZ
{
  static void Main()
  {
    Console.WriteLine("What is yourname?");
    string userName = Console.ReadLine();
    if (userName.StartsWith("z"))
    {
      Console.WriteLine("Your name starts with Z!");
    }
    else
    {
      Console.WriteLine("your name doesn't start with Z. :(");
    }
  }
}
