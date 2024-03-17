using System;

public  class Program
{
    static void Main(string[] args)
    {
        // calling the math.cs file
        MyMathClass myNewObject = new();
        myNewObject.math();
        
        // calling the Random.cs file
        MyRandomClass myNewObject2 = new();
        myNewObject2.myRandomNumber();

        //calling the conditional.cs file
        MyConditional myNewObject3 = new();
        myNewObject3.rolliDice();
        
        //calling the Boolean.cs file 
        MyBoolean myNewObject4 = new();
        myNewObject4.Boolean();


        //calling the nested_if_statement
        MyNested myNewObject5 = new();
        myNewObject5.statements();


        //calling the Challenge.cs file

        MyChallengeTask myNewObject6 = new();
        myNewObject6.TaskChallenge();


        //calling the DeclareNewArray.cs file
        DeclareNewArray myNewObject7 = new();
        myNewObject7.arr();
       
       
        

        
    }


}