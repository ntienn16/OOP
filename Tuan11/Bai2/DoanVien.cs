using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai2
{
    public class DoanVien
    {
        public string HoTen{ get; set; }
        public string ChiDoan{get; set; }
        public double DiemXL{get; set; }
        public void Input()
        {
            System.Console.Write("Nhap ho ten: ");
            HoTen=Console.ReadLine();
            System.Console.Write("Nhap ten chi doan: ");
            ChiDoan=Console.ReadLine();
            System.Console.Write("Nhap diem xep loai: ");
            DiemXL=double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            System.Console.WriteLine($"Doan vien {HoTen}; thuoc chi doan: {ChiDoan}, diem xep loai: {DiemXL}");
        }
    }
}