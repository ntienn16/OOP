namespace Bai3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("UserName: ");
        string username1=Console.ReadLine();
        System.Console.WriteLine("Level: ");
        int level1= int.Parse(Console.ReadLine());
        MuseElf elf=new MuseElf(username1,level1);
        elf.Xuat();

        System.Console.WriteLine("\nUserName: ");
        string username2=Console.ReadLine();
        System.Console.WriteLine("Level: ");
        int level2= int.Parse(Console.ReadLine());
        SoulMaster soulMaster=new SoulMaster(username2,level2);
        soulMaster.Xuat();

        System.Console.WriteLine("\nUserName: ");
        string username3=Console.ReadLine();
        System.Console.WriteLine("Level: ");
        int level3= int.Parse(Console.ReadLine());
        BladeKnight bladeKnight=new BladeKnight(username3,level3);
        bladeKnight.Xuat();
    }
}
