using System;

sealed class Guess
{
    static string? numberString { get; set; }
    static ushort inputNumber { get; set; }
    static bool tooBig { get; set; } = false;
    public static ushort maxNumber { get; set; }
    static ushort randomAnswer { get; set; }
    static byte numberOfGuesses { get; set; } = 0;


    //Asks for the maximum number that can be generated
    public static void AskUserForMaxNumber()
    {
        Console.WriteLine("WHAT IS THE LIMIT OF THE RANDOM NUMBER?");
        string? maxNumberString = Console.ReadLine();
        if (maxNumberString != null) { maxNumber = ushort.Parse(maxNumberString); }
    }


    //Generates a random number between 0 and the maximum number   
    public static void GenerateRandomAnswer() { randomAnswer = (ushort) new Random().Next(0, maxNumber + 1); }


    //Asks user for an answer
    public static void AskUserForAnswer()
    {
        Console.WriteLine($"TYPE A NUMBER BETWEEN 0 AND { maxNumber }...");
        numberString = Console.ReadLine();

        if (numberString != null) { inputNumber = ushort.Parse(numberString); }
    }


    //Check if the user's answer is bigger than the maximum number
    public static void CheckIfAnswerIsTooBig()
    {

        if (inputNumber > maxNumber)
        { Console.WriteLine("THIS NUMBER IS TOO BIG!"); tooBig = true; Console.ReadKey(); } 

    }


    //Here is where all the logic of the game takes place
    public static void GuessingGame()
    {

       if (tooBig == false)
       {

        if (inputNumber == randomAnswer) 
        { Win(); }


        else if (inputNumber >= randomAnswer / 1.03 && inputNumber <= randomAnswer * 1.03)
        { Console.ForegroundColor = ConsoleColor.Cyan;   Console.WriteLine("!!!!!!!!!!"); numberOfGuesses++;   Console.ForegroundColor = ConsoleColor.White; }

        else if (inputNumber >= randomAnswer / 1.08 && inputNumber <= randomAnswer * 1.08)
        { Console.ForegroundColor = ConsoleColor.Green;   Console.WriteLine("!!!!!"); numberOfGuesses++;   Console.ForegroundColor = ConsoleColor.White; }

        else if (inputNumber >= randomAnswer / 1.1 && inputNumber <= randomAnswer * 1.1) 
        { Console.ForegroundColor = ConsoleColor.DarkGreen;   Console.WriteLine("!!!"); numberOfGuesses++;   Console.ForegroundColor = ConsoleColor.White; }

        else if (inputNumber >= randomAnswer / 1.2 && inputNumber <= randomAnswer * 1.2) { Console.WriteLine("YOU ARE VERY CLOSE!"); numberOfGuesses++; }
        else if (inputNumber >= randomAnswer / 1.6 && inputNumber <= randomAnswer * 1.6) { Console.WriteLine("GETTING THERE!"); numberOfGuesses++; }
        else if (inputNumber >= randomAnswer / 2   && inputNumber <= randomAnswer * 2  ) { Console.WriteLine("A BIT FAR!"); numberOfGuesses++; }
        else if (inputNumber >= randomAnswer / 2.2 && inputNumber <= randomAnswer * 2.2) { Console.WriteLine("FAR!"); numberOfGuesses++; }
        else if (inputNumber >= randomAnswer / 2.6 && inputNumber <= randomAnswer * 2.6) { Console.WriteLine("VERY FAR!"); numberOfGuesses++; }
        else if (inputNumber >= randomAnswer / 3   && inputNumber <= randomAnswer * 3  ) { Console.WriteLine("VERY VERY FAR!"); numberOfGuesses++; }
        else if (inputNumber >= randomAnswer / 3.5 && inputNumber <= randomAnswer * 3.5) { Console.WriteLine("EXTREMELY FAR!"); numberOfGuesses++; }
        else if (inputNumber >= randomAnswer / 4   && inputNumber <= randomAnswer * 4  ) { Console.WriteLine("EXTREMELY EXTREMLY VERY FAR!"); numberOfGuesses++; }
        else if (inputNumber >= randomAnswer / 6   && inputNumber <= randomAnswer * 6  ) { Console.WriteLine("EXTREMELY EXTREMELY EXTREMLY EXTREMELY VERY OMEGA FAR!"); numberOfGuesses++; }
        else if (inputNumber >= randomAnswer / 8.5 && inputNumber <= randomAnswer * 8.5) { Console.WriteLine("on a galaxy far far away..."); numberOfGuesses++; }
        else { Console.WriteLine("SUPER MEGA POWER OMEAGA SHIT TON OF FART FAR AWAY LMAO"); numberOfGuesses++; }


        Console.ReadKey(true);
       }

        tooBig = false;

    }


    //If the user wins
    public static void Win()
    {
        numberOfGuesses++;
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine("CORRECT!"); 
        Console.WriteLine($"Amount Of Guesses: {numberOfGuesses}");
        
        Program.loopProgram = false;
    }


    //Asks the user if he wants to play again
    public static void AskPlayAgain()
    {

         Console.Clear();
         bool loopSwitchStatement = true;
         Console.ForegroundColor = ConsoleColor.White;


         Console.WriteLine("DO YOU WANT TO PLAY AGAIN? (y/n)");

         while (loopSwitchStatement)
         {
            switch (Console.ReadKey(true).KeyChar)
            {
                case 'y' : loopSwitchStatement = false; numberOfGuesses = 0; Console.Clear(); Program.Main(); 
                break;

                case 'n' : loopSwitchStatement = false; Console.WriteLine("SEE'YA\nHOPE YOU HAD FUN!"); Console.ReadKey(true);
                break;

                default : loopSwitchStatement = true;
                break;
            }
         }

    }
}
