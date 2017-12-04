using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double Average
    {
        get
        {
            var average = Grades.Sum() / Grades.Count;
            return average;
        }
    }
    public static Student ReadStudent()
    {
        var tokens = Console.ReadLine().Split(' ').ToList();
        Student currentStudent = new Student()
        {
            Name = tokens[0],
            Grades = new List<double>(),
            
        };
        for (int i = 1; i < tokens.Count; i++)
        {
            currentStudent.Grades.Add(double.Parse(tokens[i]));
        }


        return currentStudent;
    

    }
}
class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            var currentStudent = Student.ReadStudent();
            Console.WriteLine($"{currentStudent.Name} -> {currentStudent.Average:f2}");
        }
    }
}

