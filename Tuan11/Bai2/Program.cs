namespace Bai2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so luong doan vien: ");
        int n=int.Parse(Console.ReadLine());
        List<DoanVien> dsDoanVien=new List<DoanVien>();
        for (int i=0; i<n;i++)
        {
            DoanVien dv=new DoanVien();
            Console.WriteLine($"Nhap thong tin doan vien {i+1}:");
            dv.Input();
            dsDoanVien.Add(dv);
        }
        Console.WriteLine("Danh sach doan vien co diemxl >8:");
        foreach (DoanVien dv in dsDoanVien)
        {
            if(dv.DiemXL>=8)
            {
                dv.Output();
            }
        }
    }
}