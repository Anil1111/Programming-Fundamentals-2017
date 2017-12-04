using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class Student
{
    public string Name { get; set; }
    public List<string> Comments { get; set; }
    public List<DateTime> Attendance { get; set; }
}
    class Program
{
    static void Main(string[] args)
    {

        SortedDictionary<string, Student> dataBase = new SortedDictionary<string, Student>();
        var input = Console.ReadLine().Split(' ').ToList();
        var name = input[0];
        while (input[0] != "end")
        {
            //checking if there are any dates as input at all;
            if (input.Count == 1)
            {
                if (!dataBase.ContainsKey(name))
                {
                    Student newStudent = new Student()
                    {
                        Name = name,
                        Comments = new List<string>(),
                        Attendance = new List<DateTime>(),

                    };
                    dataBase.Add(newStudent.Name, newStudent);
                }
                continue;
            }
            

            var dateTokens = input[1].Split(',').ToList();
            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < dateTokens.Count; i++)
            {
                dates.Add(DateTime.ParseExact(dateTokens[i],"dd/MM/yyyy", CultureInfo.InvariantCulture));
            }
            Student student = new Student()
            {
                Name = name,
                Attendance = dates,
                Comments = new List<string>()

            };
            if (dataBase.ContainsKey(student.Name))
            {
                dataBase[student.Name].Attendance.AddRange(student.Attendance);
            }
            else
            {
                dataBase.Add(student.Name, student);
            };
            input = Console.ReadLine().Split(' ').ToList();
        }

        input = Console.ReadLine().Split('-').ToList();
        while (input[0] != "end of comments")
        {
            if (input.Count <= 1)
            { continue; }

            var namee = input[0];
            var comment = input[1];

            if (dataBase.ContainsKey(namee))
            {
                dataBase[name].Comments.Add(comment);
            }

            input = Console.ReadLine().Split('-').ToList();
        }

        foreach (var student in dataBase)
        {
            Console.WriteLine(student.Key);
            Console.WriteLine("Comments:");
            if (student.Value.Comments.Count > 0)
             {
                for (int i = 0; i < student.Value.Comments.Count; i++)
                {
                    Console.WriteLine($"- {student.Value.Comments[i]}");
                }

            }
            Console.WriteLine("Dates attended:");
            student.Value.Attendance.Sort();
            student.Value.Attendance.Distinct();
            for (int i = 0; i < student.Value.Attendance.Count; i++)
            {
                var day = student.Value.Attendance[i].Day;
                var month = student.Value.Attendance[i].Month;
                var year = student.Value.Attendance[i].Year;
                Console.WriteLine($"{day}/{month}/{year}");
            }
        }
    }
    

    
}

