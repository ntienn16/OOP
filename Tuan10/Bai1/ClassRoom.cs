namespace Bai1
{
    public class ClassRoom
    {
        public List<Student> Students=new List<Student>();
        public void DisplayStudent()
        {
            foreach (var student in Students)
            {
                student.DisplayInfo();
            }
        }
        public Student FindStudent(int ID)
        {
            return Students.FirstOrDefault(x => x.ID == ID);
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void RemoveStudent(int ID)
        {
            var student=Students.FirstOrDefault(x => x.ID==ID);
            if (student!=null) Students.Remove(student);
        }
        public void SortStudents()
        {
            Students = Students.OrderBy(x => x.Name.ToLower()).ToList();
        }
    }
}