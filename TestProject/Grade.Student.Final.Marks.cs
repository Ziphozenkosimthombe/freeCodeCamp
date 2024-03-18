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


public class GradeStudentFinalMarks
{
    public void studentGrades()
    {
        int currentAssignments = 5;

        int[] sophiaScores = [90, 86, 87, 98, 100];
        int[] andrewScores = [92, 89, 81, 96, 90];
        int[] emmaScores = [90, 85, 87, 98, 68];
        int[] loganScores = [90, 95, 87, 88, 96];



        //studentNames array of strings
        string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

        // studentScores array of integers
        int[] studentScores = new int[10];
        // studentLetterGrades array of strings
        string currentStudentLetterGrade = "";

        // Write the Report Header to the console
        Console.WriteLine("Student\t\tGrade\n");
        // Loop through each student in the studentNames array
        foreach (string name in studentNames)
        {
            // Set the studentScores array to the appropriate student's scores
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
            int sumAssignmentScore = 0;

            // initialize/reset the current student's grade
            decimal currentStudentGrade = 0;
            //initailize/reset the graded assignments
            int gradedAssignments = 0;          
            // Loop through each score in the studentScores array
            foreach (int score in studentScores)
            {
                // increment the gradedAssignments variable
                gradedAssignments += 1;                
                if (gradedAssignments <= currentAssignments)
                {
                    sumAssignmentScore += score;
                }
                else
                {
                    sumAssignmentScore += score / 10;
                }
            }
            // Calculate the current student's grade
            currentStudentGrade = (decimal)(sumAssignmentScore) / currentAssignments;

            if (currentStudentGrade >= 97)
                currentStudentLetterGrade = "A+";
            else if (currentStudentGrade >= 93)
                currentStudentLetterGrade = "A";
            else if (currentStudentGrade >= 90)
                currentStudentLetterGrade = "A-";
            else if (currentStudentGrade >= 87)
                currentStudentLetterGrade = "B+";
            else if (currentStudentGrade >= 83)
                currentStudentLetterGrade = "B";
            else if (currentStudentGrade >= 80)
                currentStudentLetterGrade = "B-";
            else if (currentStudentGrade >= 77)
                currentStudentLetterGrade = "C+";
            else if (currentStudentGrade >= 73)
                currentStudentLetterGrade = "C";
            else if (currentStudentGrade >= 70)
                currentStudentLetterGrade = "C-";
            else if (currentStudentGrade >= 67)
                currentStudentLetterGrade = "D+";
            else if (currentStudentGrade >= 63)
                currentStudentLetterGrade = "D";
            else if (currentStudentGrade >= 60)
                currentStudentLetterGrade = "D-";
            else
                currentStudentLetterGrade = "F";


            Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

        }
        Console.WriteLine("Press Enter to continue...");
        Console.WriteLine();
    }
}