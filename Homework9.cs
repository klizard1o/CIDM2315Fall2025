using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework9
{
    class Student
    {
        // Private fields
        private int studentID;
        private string studentName;

        // Static list to hold all Student objects
        public static List<Student> studentList = new List<Student>();

        // Constructor
        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            // Add the newly created student to the list
            studentList.Add(this);
        }

        // Public method to print student info
        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
        }

        // Getter for student name (for later gradebook reference)
        public string GetName()
        {
            return studentName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 2: Create 4 students
            Student s1 = new Student(111, "Alice");
            Student s2 = new Student(222, "Bob");
            Student s3 = new Student(333, "Cathy");
            Student s4 = new Student(444, "David");

            // Step 3: Create gradebook dictionary
            Dictionary<string, double> gradebook = new Dictionary<string, double>()
            {
                {"Alice", 4.0},
                {"Bob", 3.6},
                {"Cathy", 2.5},
                {"David", 1.8}
            };

            // Step 4: Check if "Tom" exists, if not, add him
            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook["Tom"] = 3.3;
            }

            // Step 5: Calculate average GPA
            double avgGPA = gradebook.Values.Average();
            Console.WriteLine($"The average GPA is: {avgGPA:F2}");

            // Step 6: Print info of students with GPA > average
            Console.WriteLine();
            foreach (var student in Student.studentList)
            {
                string name = student.GetName();
                if (gradebook.ContainsKey(name) && gradebook[name] > avgGPA)
                {
                    student.PrintInfo();
                    Console.WriteLine();
                }
            }
        }
    }
}
