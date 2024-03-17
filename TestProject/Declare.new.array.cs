using System;
/**
 - The new operator creates a new instance of an array in the computer's memory that can hold three string values.
 - The new operator is followed by the data type of the array elements, which is string in this case.
 - The square brackets indicate that the variable fraudulentOrderIDs is an array.
    - The number 3 in the square brackets indicates that the array can hold three string values.
    - The assignment operator = assigns the new array to the variable fraudulentOrderIDs.
    - The new array is created in the computer's memory, and the variable fraudulentOrderIDs refers to the new array.
*/ 
public class DeclareNewArray
{
    public void arr(){
        
        /*
        string[] fraudulentOrderIDs = new String[3];
        fraudulentOrderIDs[0] = "A123"; // Assigning values to the array elements
        fraudulentOrderIDs[1] = "B456"; // Assigning values to the array elements
        fraudulentOrderIDs[2] = "C789"; // Assigning values to the array elements
        */

        //Initialize an array
        string[] fraudulentOrderIDs = {"A123", "B456", "C789"}; // Initialize an array with values

        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");// Accessing the array elements
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}"); // Accessing the array elements
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");// Accessing the array elements


        // Reassigning the value of an array
        fraudulentOrderIDs[0] = "FOOD"; // Reassigning the first value of an array
        Console.WriteLine($"Reassigned First: {fraudulentOrderIDs[0]}");// Accessing the array elements

        Console.WriteLine(fraudulentOrderIDs.Length);

        
    }
}