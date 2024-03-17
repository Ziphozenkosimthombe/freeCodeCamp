// Exercise - Implement the foreach statement

using System;

public class LoopingThroughAnArrayUsingForeach
{
    public void looping()
    {
        /*
        - The foreach statement provides a simple, clean way to iterate through the elements of an array.
        - The foreach statement is used to iterate through the collection to get the information that you want, but cannot be used to add or remove items from the source collection to avoid unpredictable side effects.
        */ 

        string[] names = {"John", "James", "Jane", "Jill"};
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }


        // Create and initialize an array of int
        int[] inventory = { 200, 450, 700, 175, 250 };
        // Loop through the array and print out each value
        int sum = 0;
        int bin = 0;
        foreach (int items in inventory)
        {
            sum += items;
            bin+= 1;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }

        Console.WriteLine($"We have {sum} items in inventory.");
                    
        

    }
}