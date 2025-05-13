using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai3
{
    public abstract class NguoiLaoDong
    {
        public string Ma{ get; set; }
        public string HoTen{ get; set; }
        public int NamSinh{ get; set; }
        public string QueQuan{ get; set; }
        public abstract double TinhLuong();
        public virtual void Nhap()
        {
            System.Console.Write("Nhap ma: ");
            Ma=Console.ReadLine();
            System.Console.Write("Nhap ho ten: ");
            HoTen=Console.ReadLine();
            System.Console.Write("Nhap nam sinh: ");
            NamSinh=int.Parse(Console.ReadLine());
            System.Console.Write("Nhap que quan: ");
            QueQuan=Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Ho ten: {HoTen}, ma: {Ma}, nam sinh: {NamSinh}, que quan:{QueQuan}";
        }
    }
}