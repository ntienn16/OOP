using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai1
{
    public abstract class PhongHoc
    {
        public string MaPhong{ get; set; }
        public string DayNha{ get; set;}
        public double DienTich{ get; set; }
        public int SoBongDen { get; set; }
        public PhongHoc()
        {}
        public PhongHoc(string MaPhong, string DayNha, double DienTich, int SoBongDen)
        {
            this.MaPhong = MaPhong;
            this.DayNha = DayNha;
            this.DienTich = DienTich;
            this.SoBongDen = SoBongDen;
        }
        public abstract string DanhGia();
        public virtual void Nhap()
        {
            System.Console.Write("Nhap ma phong: ");
            MaPhong=Console.ReadLine();
            System.Console.Write("Nhap day nha: ");
            DayNha=Console.ReadLine();
            System.Console.Write("Nhap dien tich: ");
            DienTich=double.Parse(Console.ReadLine());
            System.Console.Write("Nhap so bong den: ");
            SoBongDen=int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Phong {MaPhong}, day nha: {DayNha}, dien tich: {DienTich}, so bong den: {SoBongDen}";
        }
    }
}