using DiceRollGame;

public class DiceGame
{
    public DiceGame()
    {

    }

    public void Start()
    {
        int diceValue = new NumberGenerator().Generate(1, 7);
        int tries = 3;
        bool guessed = false;
        Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
        while (tries > 0 && !guessed)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            int gueesedNumber;
            if (int.TryParse(input, out gueesedNumber))
            {
                tries--;
                if (gueesedNumber == diceValue)
                {
                    Console.WriteLine("You win");
                    guessed = true;
                }
                else
                {
                    Console.WriteLine($"Wrong number.{tries} tries left");
                }

            }
            else
            {
                Console.WriteLine("Incorrect input.");
            }

        }
        if (!guessed)
        {
            Console.WriteLine("you lost,good luck next time :)");
        }
    }


}