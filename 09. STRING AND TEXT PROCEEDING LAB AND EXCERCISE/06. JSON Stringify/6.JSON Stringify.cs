using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> Grades { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        var inputLine = Console.ReadLine();
        List<Student> dataBase = new List<Student>();

        while (inputLine != "stringify")
        {
            var tokens = inputLine.Split(new char[] { '-', '>',':',' ',',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            Student currentStu = new Student()
            {
                Name = tokens[0],
                Age = int.Parse(tokens[1]),
                Grades = new List<int>()

            };
            currentStu.Grades = tokens.Skip(2).Select(int.Parse).ToList();
            dataBase.Add(currentStu);
           

            inputLine = Console.ReadLine();
        }
        StringBuilder db = new StringBuilder();
        foreach (var stu in dataBase)
        {
            db.AppendLine($"[name:\"{stu.Name}\":,age:{stu.Age},grade:[{string.Join(", ",stu.Grades)}]");
        }

        }
    }





