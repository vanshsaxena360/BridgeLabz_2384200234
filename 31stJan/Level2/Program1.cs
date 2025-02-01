using System;

class NumberGuessingGame
{
    static void PlayGame()
    {
        int low = 1, high = 100;
        bool guessCorrectly = false;

        while (!guessCorrectly){
            int guess = GenerateGuess(low, high);
            char feedback = GetUserFeedback(guess);

            if (feedback == 'C'){
                Console.WriteLine("\nYay! I guessed your number correctly!");
                guessCorrectly = true;
            }
            else if (feedback == 'H'){
                high = guess - 1;
            }
            else if (feedback == 'L'){
                low = guess + 1;
            }
            else{
                Console.WriteLine("Invalid input! Please enter H, L, or C.");
            }

            if (low > high){
                Console.WriteLine("Did you give correct hints?");
                break;
            }
        }
    }

    static int GenerateGuess(int low, int high){
        Random random = new Random();
        return random.Next(low, high + 1);
    }

    static char GetUserFeedback(int guess){
        Console.WriteLine("\nIs your number "+guess+"? (H/L/C): ");
        return char.ToUpper(Console.ReadKey().KeyChar);
    }
	
	static void Main(){
        Console.WriteLine("Think of a number between 1 and 100");
        Console.WriteLine("Type 'H' if my guess is too high, 'L' if it's too low, and 'C' if I guessed correctly.");
        
        PlayGame();
    }
}
