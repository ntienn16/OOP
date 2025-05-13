namespace Bai3
{
    public class Hero
    {
        public string Username{get; set; }
        public int Level{get; set; }
        public Hero (string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }
        public void Xuat()
        {
            System.Console.WriteLine($"{Username}, {Level}");
        }
    }
}