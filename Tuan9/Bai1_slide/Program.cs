namespace Bai1_slide;

class Program
{
    static void Main(string[] args)
    {
        HinhChuNhat hcn= new HinhChuNhat(3,4);
        System.Console.WriteLine($"Chu vi hcn: {hcn.ChuVi()}, dien tich hcn: {hcn.DienTich()}");

        HinhTron ht= new HinhTron(4);
        System.Console.WriteLine($"Chu vi hinh tron: {ht.ChuVi()}, dien tich: {ht.DienTich()}");

        HinhTamGiac htg= new HinhTamGiac(3,3,3);
        System.Console.WriteLine($"Chu vi hinh tam giac: {htg.ChuVi()}, dien tich: {htg.DienTich()}");

        HinhVuong hv= new HinhVuong(3);
        System.Console.WriteLine($"Chu vi hinh vuong: {hv.ChuVi()}, dien tich: {hv.DienTich()}");
    }
}
