namespace Bai5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong thi sinh: ");
        int n=int.Parse(Console.ReadLine());
        List<ThiSinh> dsThiSinh=new List<ThiSinh>();
        for (int i=0; i<n;i++)
        {
            ThiSinh thiSinh=new ThiSinh();
            System.Console.WriteLine($"Nhap thong tin thi sinh {i+1}");
            thiSinh.Input();
            dsThiSinh.Add(thiSinh);
        }
        System.Console.Write("Nhap diem chuan: ");
        double diemChuan=double.Parse(Console.ReadLine());
        System.Console.WriteLine("Danh sach thi sinh trung tuyen: ");
        foreach(ThiSinh ts in dsThiSinh)
        {
            if(ts.TongDiem()>=diemChuan)
            {
                Console.WriteLine(ts);
            }
        }
    }
}
