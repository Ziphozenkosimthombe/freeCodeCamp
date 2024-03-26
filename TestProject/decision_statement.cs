public class Decisions
{
    public static void decision()
    {
        Console.WriteLine("a" == "a"); //Tue
        Console.WriteLine("a" == "A"); // False
        Console.WriteLine(1 == 2); // False

        string myValue = "a";
        Console.WriteLine(myValue == "a");//True




        string value1 = " a";
        string value2 = "A ";
        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); //True



        // Use the inequality operator

        Console.WriteLine("a" != "a");//False
        Console.WriteLine("a" != "A");//True
        Console.WriteLine(1 != 2);//True

        string myValue1 = "a";
        Console.WriteLine(myValue1 != "a");//False


        // Methods that return a Boolean value

        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(pangram.Contains("fox"));//True
        Console.WriteLine(pangram.Contains("cow"));//False



    }
}