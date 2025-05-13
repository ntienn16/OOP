namespace Bai3
{
    public class Elf: Hero
    {
        public Elf (string username, int level): base (username, level)
        {

        }
        public new void Xuat()
        {
            base.Xuat();
            System.Console.WriteLine($"{Username} is Elf");
        }
    }
    public class MuseElf : Elf
    {
        public MuseElf (string username, int level) : base (username, level)
        {

        }
        public new void Xuat()
        {
            base .Xuat();
            System.Console.WriteLine($"{Username} is MuseElf");
        }
    }
}