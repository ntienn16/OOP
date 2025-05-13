using System.Security.Cryptography.X509Certificates;
namespace Bai2
{
    public class Student
    {
        public string CodeID{get; set; }
        public string Name{get; set; }
        public int YearOfBirth{get; set; }
        public double TestMark1{get; set; }
        public double TestMark2{get; set; }
        public double TestMark{get; set; }
        public Student()
        {}
        public Student(string codeID, string name, int yearOfBirth, double testMark1, double testMark2, double testMark)
        {
            CodeID = codeID;
            Name = name;
            YearOfBirth = yearOfBirth;
            TestMark1 = testMark1;
            TestMark2 = testMark2;
            TestMark = testMark;
        }
        public void Input()
        {
            System.Console.Write("CodeID: ");
            CodeID=Console.ReadLine();
            System.Console.Write("Name: ");
            Name=Console.ReadLine();
            System.Console.Write("Year of Birth: ");
            YearOfBirth=int.Parse(Console.ReadLine());
            System.Console.Write("Test mark 1: ");
            TestMark1=double.Parse(Console.ReadLine());
            System.Console.Write("Test mark 2: ");
            TestMark2=double.Parse(Console.ReadLine());
            System.Console.Write("Test mark: ");
            TestMark=double.Parse(Console.ReadLine());
        }
        public double AverageMark()
        {
            return (((TestMark1+TestMark2)/2)+TestMark)/3;
        }
        public string Rank()
        {
            double rankMark=AverageMark();
            if (rankMark<5) return "Fail";
            else if(rankMark<7) return "Average";
            else if(rankMark<8) return "Fairly good";
            else return "Good";
        }
        public bool isPass()
        {
            return AverageMark()>=5;
        }
        public override string ToString()
        {
            return $"CodeID: {CodeID}; Name: {Name}; Year of Birth: {YearOfBirth}; Average Mark: {AverageMark()}; Rank: {Rank()}";
        }
    }
}