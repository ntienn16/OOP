namespace Bai3
{
    public class Wizard: Hero
    {
        public Wizard (string username, int level): base(username, level)
        {

        }
        public new void Xuat()
        {
            base.Xuat();
            System.Console.WriteLine($"{Username} is Wizard");
        }
    }
    public class DarkWizard : Wizard
    {
        public DarkWizard (string username, int level) : base(username, level)
        {

        }
        public new void Xuat()
        {
            base.Xuat();
            System.Console.WriteLine($"{Username} is DarkWizard");
        }
    }
    public class SoulMaster: DarkWizard
    {
        public SoulMaster (string username, int level): base(username, level)
        {
    
        }
        public new void Xuat()
        {
            base.Xuat();
            System.Console.WriteLine($"{Username} is SoulMaster");
        }
    }
}