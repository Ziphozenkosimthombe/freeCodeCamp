/**
Suppose you need to quickly determine whether a customer's purchase is eligible for a promotional discount. The details for the promotion indicate that when a purchase value is greater than $1000, the purchase is eligible for a $100 discount. If the purchase amount is $1000 or less, the purchase is eligible for a $50 discount.
*/ 


public class Discount
{
    public static void discount()
    {
        double purchaseValue = 1000;
        double discount = purchaseValue > 1000 ? 100 : 50;
        Console.WriteLine($"The purchase value is {purchaseValue:C} and the discount is {discount:C}.");
    }
}