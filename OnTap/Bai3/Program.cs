namespace Bai3;

class Program
{
    static void Main(string[] args)
    {
        DaiHoc daiHoc = new DaiHoc();
        while (true)
        {
            System.Console.WriteLine("Chon chuc nang: ");
            System.Console.WriteLine("1. Them nguoi lao dong");
            System.Console.WriteLine("2. Hien thi danh sach nguoi lao dong");
            System.Console.WriteLine("3. Tim nguoi lao dong theo ma");
            System.Console.WriteLine("4. Tinh tong luong cua gian vien");
            System.Console.WriteLine("5. In danh sach nhan vien co luong tren 10000000");
            System.Console.WriteLine("6. Sap xep danh sach");
            System.Console.WriteLine("7. In ra so giang vien va nhan vien");
            System.Console.WriteLine("0. Thoat");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    System.Console.WriteLine("Chon loai nguoi lao dong:");
                    System.Console.WriteLine("1. Nhan vien/ 2. Giang vien: ");
                    int choice1=int.Parse(Console.ReadLine());
                    NguoiLaoDong nld=null;
                    if (choice1 == 1)
                    {
                        nld=new NhanVien();
                    }
                    else if (choice1 == 2)
                    {
                        nld=new GiangVien();
                    }
                    else
                    {
                        System.Console.WriteLine("Khong hop le");
                        continue;
                    }
                    nld.Nhap();
                    daiHoc.Them(nld);
                    break;
                case 2:
                    daiHoc.HienThi();
                    break;
                case 3:
                    System.Console.Write("Nhap ma can tim: ");
                    string maTim=Console.ReadLine();
                    daiHoc.TimKiem(maTim);
                    break;
                case 4:
                    System.Console.WriteLine($"Tong luong giang vien: {daiHoc.TongLuongGiangVien()}");
                    break;
                case 5:
                    daiHoc.InNhanVienLuong10m();
                    break;
                case 6:
                    daiHoc.SapXep();
                    System.Console.WriteLine(daiHoc);
                    break;
                case 7:
                    daiHoc.ThongKe();
                    break;
                case 0:
                    return;
                default:
                    System.Console.WriteLine("Khong hop le");
                    return;
            }
        }
    }
}
