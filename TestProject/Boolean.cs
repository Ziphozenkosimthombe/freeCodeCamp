using System;

public class MyBoolean{
    public void Boolean(){
        string message = "The quick brown fox jumps over the lazy dog.";
        bool result = message.ToLower().Contains("dog");
        Console.WriteLine(result);

        if (message.ToLower().Contains("fox")){
            Console.WriteLine("What does the fox says");
        }
    }
}