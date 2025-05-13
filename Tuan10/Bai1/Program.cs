using System;
using System.Collections.Generic;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classRoom = new ClassRoom();
            classRoom.AddStudent(new Student(1, "Nguyen Van A", "20/05/2001"));
            classRoom.AddStudent(new Student(2, "Tran Thi B", "15/08/2002"));
            classRoom.AddStudent(new Student(3, "Le Van C", "10/12/2000"));
            classRoom.DisplayStudent();

            System.Console.WriteLine("Tim hoc sinh");
            var student = classRoom.FindStudent(2);
            Console.WriteLine(student != null ? student.ToString() : "Khong tim thay");

            System.Console.WriteLine("Xoa hoc sinh");
            classRoom.RemoveStudent(3);
            classRoom.DisplayStudent();

            System.Console.WriteLine("Sap xep hoc sinh");
            classRoom.SortStudents();
            classRoom.DisplayStudent();
            System.Console.WriteLine("Them hoc sinh");
            var newStudent = new Student();
            newStudent.Input();
            classRoom.AddStudent(newStudent);
            classRoom.DisplayStudent();
        }
    }
}
