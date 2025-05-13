using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai3
{
    public class NhanVien:NguoiLaoDong
    {
        public double LuongCoBan{get; set;}
        public double Thuong{get; set;}
        public override double TinhLuong()
        {
            return LuongCoBan+Thuong;
        }
        public override void Nhap()
        {
            base.Nhap();
            System.Console.Write("Nhap luong co ban: ");
            LuongCoBan=double.Parse(System.Console.ReadLine());
            System.Console.Write("Nhap thuong: ");
            Thuong=double.Parse(System.Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString()+$", thuong: {Thuong}, luong: {TinhLuong()}";
        }
    }
}