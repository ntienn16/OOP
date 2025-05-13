namespace Bai11;

class Program
{
    static void Main(string[] args)
    {
        HocVien hocVien1=new HocVien();
        hocVien1.Input();
        System.Console.WriteLine("Thong tin hoc vien 1:");
        hocVien1.Output();
        HocVien hocVien2=new HocVien();
        hocVien2.Input();
        System.Console.WriteLine("Thong tin hoc vien 2:");
        hocVien2.Output();
    }
}
