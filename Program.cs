/*
 Author: Thanh Nguyen
 Date: 09/16/2021
 Comment: This C# Console application code demonstrates the use of 
            conditional statements after getting input from users
 */


using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user what the grade to input
            Console.WriteLine("Please enter your grade you expect to get in ISM 4300: ");

            // Read the grade from standard input
            int Grade = 0;

            try
            {
                Grade = Convert.ToInt32(Console.ReadLine());
            }// end try

            catch (Exception e)
            {
                // Handle Incorrect input type provided.
                // Extract information from this exception, and exit

                /* 
                 This IF/ELSE/ statement is used to conditionally test
                    the users input. Various options are available depending on the 
                    grade entered by the user. Then, inside of each IF/ELSE IF/ELSE there is 
                    a switch conditional statement that displays a message depending on the number 
                    of grades entered by the user.
                */
                if (e.Source != null)
                    Console.WriteLine("Incorrect input type provided. Ensure that an integer is provided. Exception source: {0}", e.Source);
                Environment.Exit(1);
            }// end catch

            // Exit with 1 failure exit code if the user enter a number outside of acceptable values for a percentage
            if (Grade < 0 || Grade > 100)
            {
                Console.WriteLine("Require an integer value between 0 and 100... Exiting.");
                Environment.Exit(1);
            } 

            // Create a character array with two elements
            char[] degree = new char[2];

            // Initilize element 0 as the lowest grade (Effectively a replacement of else in the following statement set)
            degree[0] = 'F';

            // Handle the "Tens" of the grade to get the letter grade
            if (Grade >= 90)
                degree[0] = 'A';
            else if (Grade >= 80)
                degree[0] = 'B';
            else if (Grade >= 70)
                degree[0] = 'C';
            else if (Grade >= 60)
                degree[0] = 'D';

            // Handle the "Ones" of the grade by means of a modulo calculation to get the letter grade's 
            // upper middle or lower indicator
            int modValue = Grade % 10;
            if (modValue > 7)
                degree[1] = '+';
            else if (modValue > 1)
                degree[1] = ' ';
            else
                degree[1] = '-';

            // Initialize a new result string by using the character array
            string result = new string(degree);

            // Print a message with the result string
            Console.WriteLine("Your Letter Grade per the Syllabus is " + result);

            // Exit with 0 success exit code
            Environment.Exit(0);
        }// end of Main
    } // end of class
}// end of namspace
