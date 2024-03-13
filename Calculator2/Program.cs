using Calculator2;
using ConsoleTables;
using System;

namespace Calcu
{
    class Program
    {
        static void Main(string[] args)
        {  
            try
            {
                Console.Write("Enter your name: ");
                string studentName = Console.ReadLine();

                Console.Write("Enter number of courses: ");
                int numberOfCourses = Convert.ToInt32(Console.ReadLine());

                Course[] courses = new Course[numberOfCourses];

                for (int i = 0; i < numberOfCourses; i++)
                {
                    Course course = new Course();

                    Console.Write($"Enter course name for course {i + 1}: ");
                    course.Name = Console.ReadLine();

                    //Console.Write($"Enter course code for course {i + 1}: ");
                    //course.Code = Console.ReadLine();

                    Console.Write($"Enter course unit for course {i + 1}: ");
                    course.Unit = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"Enter score for course {i + 1}: ");
                    course.Score = Convert.ToInt32(Console.ReadLine());

                    courses[i] = course;
                }
                int totalQualityPoint = 0;
                int totalGradeUnit = 0;

                GradeManager gradeManager = new GradeManager();

                foreach (Course course in courses)
                {
                    GradePoint gradePoint = gradeManager.GetGradePoint(course.Score);

                    totalQualityPoint += gradePoint.GradeUnit * course.Unit;
                    totalGradeUnit += course.Unit;
                }
                var newTable = new ConsoleTable("Course", "Course Unit", "Score", "grade", "grade Unit", "Remarks");
                foreach (Course course in courses)
                {
                    GradePoint gradePoint = gradeManager.GetGradePoint(course.Score);
                    newTable.AddRow(course.Name,course.Unit,course.Score, gradePoint.Grade, gradePoint.GradeUnit, gradePoint.Remarks);
                }
                newTable.Write();
                decimal gpa = (decimal)totalQualityPoint / totalGradeUnit;
                Console.WriteLine($"\nFinal GPA for {studentName}: {gpa:F2}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}. Please enter a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.ReadKey();
            }
            
        }
        public void CreateTable()
        {
            
        }
    }

}
