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

	Console.WriteLine($"Dice roll: {roll_1} + {roll_2} + {roll_3} = {total}");
    }
}
