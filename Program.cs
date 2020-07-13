using System;
using System.Collections.Generic;
using Games.Sphinx;

namespace Games
{
  public class Program
  {
    public static void Main()
    {
      Riddle one = new Riddle("The more of this there is, the less you see", "darkness");
      Riddle two = new Riddle("It stalks the countryside with ears that can’t hear. What is it?", "corn");
      Riddle three = new Riddle("I am an odd number. Take away a letter and I become even. What number am I?", "seven");
      Riddle four = new Riddle("What 4-letter word can be written forward, backward or upside down, and can still be read from left to right?", "NOON");
      Riddle five = new Riddle("What is so fragile that saying its name breaks it?", "silence");

      List<Riddle> riddles = new List<Riddle>() { one, two, three, four, five };

      Console.WriteLine("Welcome to the Riddle Sphinx! For your first riddle press [Y]");
      string startGame = Console.ReadLine();
      if (startGame == "Y" || startGame == "y")
      {
        for (int index = 0; index < riddles.Count; index++)
        {
          Console.WriteLine(riddles[index].GetQuestion());
          string userResponse = Console.ReadLine();

          if (riddles[index].CheckAnswer(userResponse))
          {
            Console.WriteLine("You're right!");
          }
          else
          {
            Console.WriteLine("The Sphinx has eaten you! The correct answer was " + riddles[index].GetAnswer());
          }
          Console.WriteLine("Do you want to keep playing? [Y] for Yes, press [N] to Quit");
          string endGame = Console.ReadLine();
          if (endGame == "N" || endGame == "n")
          {
            Console.WriteLine("Goodbye!");
            Main();
          }
        }
      }
      else
      {
        Console.WriteLine("Boo!");
      }
    }
  }
}
