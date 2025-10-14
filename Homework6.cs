namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        //Answer Q1 and Q2
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.salary = 9000;
        p1.PrintProfessorInfo();

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.salary = 8000;
        p2.PrintProfessorInfo();

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.StudentGrade = 90;
        s1.PrintStudentInfo();

        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.StudentGrade = 80;
        s2.PrintStudentInfo();

        Console.WriteLine($"The salary difference between Alice and Bob is: {p1.salary - p2.salary}");
        Console.WriteLine($"The total grade of Lisa and Tom is: {s1.StudentGrade + s2.StudentGrade}");

    }
}

class Professor

{
    //code for professor class
    public string profName;
    public string classTeach;
    public double salary { get; set; }
    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }
    public double GetSalary()
    {
        return salary;
    }

    public void PrintProfessorInfo()
    {
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {salary}");
        }
}
class Student
{
    //code for student class
    public string? studentName;
    public string classEnroll;
    public double StudentGrade { get; set; }
    public void SetGrade(double newGrade)
    {
        StudentGrade = newGrade;
    }
    public double GetGrade()
    {
        return StudentGrade;
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: {StudentGrade}");
    }
}