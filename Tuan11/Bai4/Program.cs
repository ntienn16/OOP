namespace Bai4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so loai sach: ");
        int n=int.Parse(Console.ReadLine());
        List<Sach> dsSach=new List<Sach>();
        for(int i=0; i<n;i++)
        {
            Sach sach=new Sach();
            System.Console.WriteLine($"Nhap thong tin sach {i+1}: ");
            sach.Input();
            dsSach.Add(sach);
        }
        Sach sachSLMax=new Sach();
        foreach(Sach sach in dsSach)
        {
            if(sach.SoLuong>sachSLMax.SoLuong)
            {
                sachSLMax=sach;
            }
        }
        Console.WriteLine("Sach co so luong lon nhat la: ");
        sachSLMax.Output();
    }
}