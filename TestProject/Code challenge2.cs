/*
- Your team has found a pattern.
- Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate.
- You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B".
- This will be used by the fraud team to investigate further.
*/ 


using System;

public class MyChallengeForLoopAndArray{
    public void TaskChallengeTwo(){
        string[] orderID = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
        foreach (string order in orderID){
            if (order[0] == 'B'){
                Console.WriteLine(order);
            }
        }
    }
}

