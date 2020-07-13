using System;
namespace Games.Riddles
{
  public class Riddle
  {
    public string Question { get; set; }
    public string Answer { get; set; }

    public Riddle(string question, string answer)
    {
      Question = question;
      Answer = answer;
    }
    public string GetQuestion()
    {
      return Question;
    }
    public string GetAnswer()
    {
      return Answer;
    }
  }
}
