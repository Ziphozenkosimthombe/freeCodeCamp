/*
- developing a Student Grading application that automates the calculation of grades
- for each student in a class.
-  The parameter for application.

1. start with four Students. Each student has five exam scores.
2. Each exam score is an integer value, 0-100. where 100 represents 100% correct.
3. A student's overall exam score is the average of their five exam scores.
4. A student's letter grade is determined by the following table:
    - 90-100: A
    - 80-89: B
    - 70-79: C
    - 60-69: D
    - 0-59: F
5. Criteria for extra credit assignments:
    - Include extra credit assignment scores in the student's scores array.
    - Extra credit assignments are worth 10% of an exam score (when calculating the final numeric grade)
    - Add extra credit assignment scores to the student's total exam score before calculating the final numeric grade.

6.application needs to automatically assign letter grades based on the calculated final score for each student.
7. application needs to output/display each student’s name and formatted grade.
8. application needs to support adding other students and scores with minimal impact to the code.
*/ 


using System;


public class GradeStudentFinalMarks{
    public void studentGrades(){
        int currentAssignments = 5;

        int[] sophiaScores = {90, 86, 87, 98, 100};
        int[] andrewScores = {92, 89, 81, 96, 90};
        int[] emmaScores = {90, 85, 87, 98, 68};
        int[] loganScores = {90, 95, 87, 88, 96};



        //studentNames

        string[] studentNames = {"Sophia", "Andrew", "Emma", "Logan"};


        int[] studentScores = new int[10];
        
        // Write the Report Header to the console
        Console.WriteLine("Student\t\tGrade\n");
        foreach(string name in studentNames){


            string currentStudent = name;

            if (currentStudent == "Sophia")
                studentScores = sophiaScores;

            else if (currentStudent == "Andrew")
                studentScores = andrewScores;

            else if (currentStudent == "Emma")
                studentScores = emmaScores;

            else if (currentStudent == "Logan")
                studentScores = loganScores;

            // initialize/reset the sum of scored assignments
            int sumAssignmentScores = 0;

            // initialize/reset the calculated average of exam + extra credit scores
            decimal currentStudentGrade = 0;

            foreach (int score in studentScores)
            {
                // add the exam score to the sum
                sumAssignmentScores += score;
            }

            currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

            Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
        }

        

        




    }
}