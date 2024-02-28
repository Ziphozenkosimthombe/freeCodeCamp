using System;

public class MyConditional
{
    public void rolliDice()
    {
        Random dice = new Random();

        int roll_1 = dice.Next(1, 7);
        int roll_2 = dice.Next(1, 7);
        int roll_3 = dice.Next(1, 7);

	    int total = roll_1 + roll_2 + roll_3;

        Console.WriteLine($"total is: {total}");

        if ((roll_1 == roll_2) || (roll_2 == roll_3) || (roll_1 == roll_3))
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }

        if (total >= 15)
        {
            Console.WriteLine("You win!");
        }

        else
        {
            Console.WriteLine("Sorry, you lose.");
        }    
	
    }
}
