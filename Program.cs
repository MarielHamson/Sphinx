using System;
using Games.Riddles;

namespace Games
{
  public class Program
  {
    public static void Main()
    {
      riddleOne = new Riddle("The more of this there is, the less you see", "darkness");
      Console.WriteLine(riddleOne.question);
      string userResponse = Console.ReadLine();
      if (userResponse == riddleOne.answer)
      {
        Console.WriteLine("You're right!");
      }
      else
      {
        Console.WriteLine("The Sphinx has eaten you! The correct answer was" + riddleOne.answer);
      }
      Console.WriteLine("Do you want to keep playing? [Y] for Yes, press [Enter] to Quit");
      string endGame = Console.ReadLine();
      if (endGame == "Y" || endGame = "y")
      {
        // get another question
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }

    }
  }
}
