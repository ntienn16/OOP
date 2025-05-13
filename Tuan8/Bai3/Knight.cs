namespace Bai3
{
    public class Knight: Hero
    {
        public Knight (string username, int level): base(username, level)
        {

        }
        public new void Xuat()
        {
            base.Xuat();
            System.Console.WriteLine($"{Username} is Knight");
        }
    }
    public class DarkKnight : Knight
    {
        public DarkKnight (string username, int level):base(username, level)
        {

        }
        public new void Xuat()
        {
            base.Xuat();
            System.Console.WriteLine($"{Username} is DarkKnight");
        }
    }
    public class BladeKnight: DarkKnight
    {
        public BladeKnight (string username, int level) : base(username, level)
        {

        }
        public new void Xuat()
        {
            base.Xuat ();
            System.Console.WriteLine($"{Username} is BladeKnight");
        }
    }
}