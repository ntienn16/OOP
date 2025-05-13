using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VienPhi
{
    public class BenhNhan: IBenhNhan
    {
        public int Ma{get;set;}
        public string HoTen{get;set;}
        public double TienThuoc{get;set;}
        public BenhNhan()
        {}
        public BenhNhan(int Ma, string HoTen, double TienThuoc)
        {
            this.Ma = Ma;
            this.HoTen = HoTen;
            this.TienThuoc=TienThuoc;
        }
        public virtual void Input()
        {
            System.Console.Write("Nhap Ma BN: ");
            Ma=int.Parse(System.Console.ReadLine());
            System.Console.Write("Nhap ho ten BN: ");
            HoTen=Console.ReadLine();
            System.Console.Write("Nhap tien thuoc: ");
            TienThuoc=double.Parse(Console.ReadLine());
        }
        public virtual double VienPhi()
        {
            return TienThuoc;
        }
        public override string ToString()
        {
            return $"Benh nhan {HoTen}, Ma BN: {Ma}, tien thuoc: {TienThuoc}, vien phi: {VienPhi()}";
        }
    }
}