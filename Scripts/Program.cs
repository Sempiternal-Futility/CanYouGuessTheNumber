using System;

sealed class Program
{

    public static bool loopProgram = true;

    public static void Main()
    {
        Console.Clear();
        loopProgram = true;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Title = "C A N   Y O U   G U E S S   T H E   N U M B E R   ?";

        RunProgram();
        Guess.AskPlayAgain();
    }

    static void RunProgram()
    {


      try
      { Guess.AskUserForMaxNumber(); Guess.GenerateRandomAnswer(); }

      //If the user inputs a max number that is too big, the max number becomes 100
      catch (OverflowException) 
      { 
      Console.ForegroundColor = ConsoleColor.Red; 
      Console.WriteLine("NUMBER WAS EITHER TOO BIG OR TOO SMALL!"); Guess.maxNumber = 100; Console.ReadKey();
      Console.ForegroundColor = ConsoleColor.White;
      }


      //If the user doesn't input a number at all, the max number becomes 100
      catch (FormatException) 
      { 
      Console.ForegroundColor = ConsoleColor.Red; 

      Console.WriteLine("Input Was Not In The Correct Format"); 
      Guess.maxNumber = 100;
      Guess.GenerateRandomAnswer();

      Console.ForegroundColor = ConsoleColor.White;
      Console.ReadKey();
      }




      while (loopProgram)
      {
        Console.Clear();

        try
        { Guess.AskUserForAnswer(); Guess.CheckIfAnswerIsTooBig(); Guess.GuessingGame();}

        catch (FormatException) 
        { 
        Console.ForegroundColor = ConsoleColor.Red; 
        Console.WriteLine("Input Was Not In The Correct Format"); 
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
        }


        catch (Exception) {}
     }

 
    }
}
