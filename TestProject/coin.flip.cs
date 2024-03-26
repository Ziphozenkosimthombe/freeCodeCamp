public class FlipCoin
{
    public static void flip()
    {
        Random random = new();
        int flip = random.Next(0, 2);
        Console.WriteLine(flip == 0 ? "Heads" : "Tails");
    }
}