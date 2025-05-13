using System;
using System.Text;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            DaiHoc daiHoc = new DaiHoc();
            int choice;
            do
            {
                Console.WriteLine("\n--- MEMU QUAN LY PHONG HOC ---");
                Console.WriteLine("1. Them phong hoc");
                Console.WriteLine("2. Hien thi thong tin tat ca phong hoc");
                Console.WriteLine("3. Tim kiem phong hoc theo ma");
                Console.WriteLine("4. Tinh tong so phong hoc ");
                Console.WriteLine("5. Tinh tong dien tich phong thuc hanh");
                Console.WriteLine("6. Danh sach phong dat chuan");
                Console.WriteLine("7. Danh sach phong thuc hanh co so may nhieu tren 40");
                Console.WriteLine("8. Sap xep danh sach phong hoc");
                Console.WriteLine("9. Thoat");
                Console.Write("Chon chuc nang: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ThemPhongHoc(daiHoc);
                        break;
                    case 2:
                        Console.WriteLine("\nDanh sach phong hoc:");
                        daiHoc.HienThiTatCaPhongHoc();
                        break;
                    case 3:
                        Console.Write("\nNhap ma phong can tim: ");
                        string maPhong = Console.ReadLine();
                        var phong = daiHoc.TimPhongHoc(maPhong);
                        if (phong != null)
                        {
                            Console.WriteLine("Phong tim duoc:");
                            Console.WriteLine(phong.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Khong tim thay ma phong. Nhap lai");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nTong so phong hoc: " + daiHoc.TinhTongSoPhongHoc());
                        break;
                    case 5:
                        Console.WriteLine("\nTong dien tich phong thuc hanh: " + daiHoc.TinhTongDienTichPhongThucHanh());
                        break;
                    case 6:
                        Console.WriteLine("\nDanh sach phong dat chuan:");
                        daiHoc.InDanhSachPhongHocDatChuan();
                        break;
                    case 7:
                        Console.WriteLine("\nDanh sach phong thuc hanh co so may nhieu hon 40");
                        daiHoc.InDanhSachPhongThucHanhSoMayTren40();
                        break;
                    case 8:
                        daiHoc.SapXepDanhSachPhongHoc();
                        Console.WriteLine("\nDach sach phong hoc sau khi sap xep:");
                        daiHoc.HienThiTatCaPhongHoc();
                        break;
                    case 9:
                        Console.WriteLine("Thoat chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Lua chon chuc nang sai");
                        break;
                }
            } while (choice != 9);
        }
        static void ThemPhongHoc(DaiHoc daiHoc)
        {
            Console.WriteLine("\nChon loai phong hoc:");
            Console.WriteLine("1. Phong ly thuyet");
            Console.WriteLine("2. Phong thuc hanh");
            Console.Write("Lua chon: ");
            int loaiPhong = int.Parse(Console.ReadLine());
            PhongHoc phong;
            switch (loaiPhong)
            {
                case 1:
                    phong = new PhongLyThuyet();
                    break;
                case 2:
                    phong = new PhongThucHanh();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le");
                    return;
            }
            phong.Nhap();
            daiHoc.ThemPhongHoc(phong);
            Console.WriteLine("Them phong hoc thanh cong");
        }
    }
}