namespace Bai6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so luong sinh vien: ");
        int n=int.Parse(Console.ReadLine());
        List<SinhVien> dsSinhVien=new List<SinhVien>();
        for(int i=0; i<n;i++)
        {
            System.Console.WriteLine($"Nhap thong tin sinh vien {i+1}:");
            SinhVien sinhVien=new SinhVien();
            sinhVien.Input();
            dsSinhVien.Add(sinhVien);
        }
        System.Console.WriteLine("Danh sach sinh vien: ");
        foreach(SinhVien sv in dsSinhVien)
        {
            System.Console.WriteLine(sv);
        }
        SinhVien svMax=dsSinhVien[0];
        foreach(SinhVien sv in dsSinhVien)
        {
            if(sv.DTB>svMax.DTB)
            {
                svMax=sv;
            }
        }
        System.Console.WriteLine($"Sinh vien co diem trung binh cao nhat: {svMax}");
    }
}