using System;

class MainClass{
    public static void Main(string[] args){
        string[] pallets = { "B14", "A11", "B12", "A13" };
        Console.WriteLine("Clear...");
        Console.WriteLine("");
        Console.WriteLine($"Before: {pallets[0]}");
        Array.Clear(pallets, 0, 2);
        Console.WriteLine($"After: {pallets[0]}");
        Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }

        //Resize
        Console.WriteLine("");
        Array.Resize(ref pallets, 6);
        Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
        
        pallets[4] = "C01";
        pallets[5] = "C02";
        
        foreach (var pallet in pallets)
        {
            Console.WriteLine($"-- {pallet}");
        }
    }
}