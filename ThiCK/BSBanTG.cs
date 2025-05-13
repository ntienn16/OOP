using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThiCK
{
    public class BSBanTG:BacSi
    {
        public double LuongNgay{get;set;}
        public int SoNgayLamViec{get;set;}
        double phuPhiLuong=0;
        public override double TinhLuong()
        {
           
            if (SoNgayLamViec<7)
            {
                phuPhiLuong=500;
            }
            else
            {
                phuPhiLuong=1000;
            }
            return (MucLuong*30)/100 + LuongNgay*SoNgayLamViec + phuPhiLuong;
        }
        public override void Nhap()
        {
            base.Nhap();
            System.Console.Write("Luong ngay: ");
            LuongNgay=double.Parse(System.Console.ReadLine());
            System.Console.Write("So ngay lam viec: ");
            SoNgayLamViec=int.Parse(System.Console.ReadLine());
            
        }
        public override string ToString()
        {
            return base.ToString()+$", luong ngay: {LuongNgay}, so ngay lam viec: {SoNgayLamViec}, phu phi luong: {phuPhiLuong}";
        }
    }
}