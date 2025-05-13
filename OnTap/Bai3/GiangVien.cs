using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai3
{
    public class GiangVien:NguoiLaoDong
    {
        public int SoTiet{ get; set; }
        public double Thuong{ get; set; }
        public override double TinhLuong()
        {
            double donGian=SoTiet<=200 ?80000:90000;
            return SoTiet*donGian+Thuong;
        }
        public override void Nhap()
        {
            base.Nhap();
            System.Console.Write("Nhap so tiet: ");
            SoTiet=int.Parse(System.Console.ReadLine());
            System.Console.Write("Thuong: ");
            Thuong=double.Parse(System.Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString()+$", so tiet: {SoTiet}, thuong: {Thuong}, luong: {TinhLuong()}";
        }
    }
}