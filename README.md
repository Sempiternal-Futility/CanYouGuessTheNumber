# CAN YOU GUESS THE NUMBER ?

Once you start the game, it will ask your for the maximum number you want to guess from.

After that it will ask your for a number, if the number is very far it will tell you that it's far, otherwise it will tell you that its close

This is how it works:

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
