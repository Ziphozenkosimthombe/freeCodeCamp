using System;

public class MyNested{
    public void statements(){
        Random dice = new Random();

        int roll_1 = dice.Next(1, 7);
        int roll_2 = dice.Next(1, 7);
        int roll_3 = dice.Next(1, 7);

        int total = roll_1 + roll_2 + roll_3;

        Console.WriteLine("nested id statement!!!!!!!");
        Console.WriteLine("===============================");


        if ((roll_1 == roll_2) || (roll_2 == roll_3) || (roll_1 == roll_3)){
            if ((roll_1 == roll_2) && (roll_2 == roll_3)){
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;     
            }else{
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }
        }
        if (total >= 16){
            Console.WriteLine("You win a new car!");
        }
        else if (total >= 10){
            Console.WriteLine("You win a new laptop!");
        }
        else if (total == 7){
            Console.WriteLine("You win a trip for two!");
        }
        else{
            Console.WriteLine("You win a kitten!");
        }

    }
}