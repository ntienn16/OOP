namespace Bai1;

class Program
{
    static void Main(string[] args)
    {
        Diem diem= new Diem();
        Diem diem1= new Diem();
        diem1.Nhap();
        System.Console.WriteLine($"Khoang cach 2 diem: {diem.KhoangCach(diem1)}");

        HinhTron hinhTron= new HinhTron();
        hinhTron.Nhap();
        hinhTron.In();
        System.Console.WriteLine($"Chu vi hinh tron: {hinhTron.ChuVi()}");
        System.Console.WriteLine($"Dien tich hinh tron: {hinhTron.DienTich()}");
    }
}
