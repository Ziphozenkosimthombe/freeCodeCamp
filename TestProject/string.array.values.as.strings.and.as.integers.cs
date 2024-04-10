using System;

class MainClass {
    public static void Main(string[] args) {
        string [] values = { "12.3", "45", "ABC", "11", "DEF" };

        double total = 0;
        string message = "";

        foreach(string value in values){
            double nuemericalValue;
            if(double.TryParse(value, out nuemericalValue)){
                total += nuemericalValue;
            } else {
                message += value + " ";
            }
        }
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {total}");
    }
}