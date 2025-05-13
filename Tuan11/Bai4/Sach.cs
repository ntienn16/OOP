using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai4
{
    public class Sach
    {
        public string TenSach{get; set;}
        public string TenTacGia{get; set;}
        public int SoLuong{get; set;}
        public int NamXB{get; set;}
        public void Input()
        {
            System.Console.Write("Nhap ten sach: ");
            TenSach=Console.ReadLine();
            System.Console.Write("Nhap ten tac gia: ");
            TenTacGia=Console.ReadLine();
            System.Console.Write("Nhap so luong: ");
            SoLuong=int.Parse(Console.ReadLine());
            System.Console.Write("Nhap nam xuat ban: ");
            NamXB=int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            System.Console.WriteLine($"Sach {TenSach}, tac gia: {TenTacGia}, xuat ban nam {NamXB}, so luong: {SoLuong}");
        }
    }
}