namespace Bai2;
class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}:");
            Student student = new Student();
            student.Input();
            students.Add(student);
        }

        Console.WriteLine("\nPassed:");
        var passed = students.Where(s => s.isPass()).ToList();
        foreach (var student in passed)
        {
            Console.WriteLine(student);
        }

        students = students.OrderBy(s => s.Name).ToList();
        Console.WriteLine("\nSort by name:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine($"\nNumber of students passed: {passed.Count}");

        Console.WriteLine("\nReprinting students who passed:");
        foreach (var student in passed)
        {
            Console.WriteLine(student);
        }
    }
}
