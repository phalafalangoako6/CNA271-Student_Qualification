// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace StudentExamQualification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Exam Qualification Calculator ===");
            Console.WriteLine();

            //  1: Get the four marks from the user
            Console.Write("Enter Test 1 mark: ");
            double test1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Test 2 mark: ");
            double test2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Assignment 1 mark: ");
            double assignment1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Project mark: ");
            double project = Convert.ToDouble(Console.ReadLine());

            // 2: Calculate the weighted average
            // Test 1 = 30%, Test 2 = 50%, Assignment 1 = 10%, Project = 10%
            double weightedAverage = (test1 * 0.30) + (test2 * 0.50) + (assignment1 * 0.10) + (project * 0.10);

            // Step 3: Check if the student qualifies (needs at least 50)
            Console.WriteLine();
            Console.WriteLine("Weighted Average: " + weightedAverage);

            if (weightedAverage >= 50)
            {
                Console.WriteLine("Result: The student QUALIFIES to write the exam.");
            }
            else
            {
                Console.WriteLine("Result: The student DOES NOT QUALIFY to write the exam.");
            }
        }
    }
}
