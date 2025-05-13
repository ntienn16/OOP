namespace Bai1
{
    public class Student
    {
        public int ID{ get; set; }
        public string Name{ get; set; }
        public string DateOfBirth{ get; set; }
        public Student()
        {}
        public Student(int ID, string Name, string DateOfBirth)
        {
            this.ID = ID;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Hoc sinh: {Name}, MSSV: {ID}, Ngay sinh: {DateOfBirth}");
        }
        public void Input()
        {
            System.Console.Write("Ten hoc sinh: ");
            Name=Console.ReadLine();
            System.Console.Write("ID: ");
            ID=int.Parse(Console.ReadLine());
            System.Console.Write("Ngay sinh (dd/mm/yyyy): ");
            DateOfBirth=Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Hoc sinh: {Name}, MSSV: {ID}, Ngay sinh: {DateOfBirth}";
        }
    }
}