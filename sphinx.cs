using System;
using System.Collections.Generic;
class Sphinx
{
  public static string[] Riddles = {"What has hands, but can't clap?","I add lots of flavor and have many layers, but if you get to close I'll make you cry. What am I?"};
  public static string[] Answers = {"a clock", "an onion"};
  
  static void Main()
  {
    Console.WriteLine(Riddles[0]);
    

    string userAns1 = Console.ReadLine();
  if (userAns1 == Answers[0]|| userAns1.Contains("clock"))
    {
      Console.WriteLine("correct");
    }

    else
    {
      Console.WriteLine("The Sphinx has eaten you!");
    }
      Console.WriteLine(Riddles[1]);

    string userAns2 = Console.ReadLine();
    if(userAns2 == Answers[1] || userAns2.Contains("onion"))
    {
     Console.WriteLine("correct");

    }
    
    else
    {
      Console.WriteLine("The Sphinx has eaten you!");
    }
  }
  
}