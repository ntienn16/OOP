using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThiCK
{
    public abstract class BacSi
    {
        public int Ma{ get; set; }
        public string HoTen{ get; set; }
        public double MucLuong{ get; set; }
        public abstract double TinhLuong();
        public BacSi()
        {

        }
        public BacSi(int Ma, string HoTen, double MucLuong)
        {
            this.Ma = Ma;
            this.HoTen = HoTen;
            this.MucLuong = MucLuong;
        }
        public virtual void Nhap()
        {
            System.Console.Write("Nhap ma: ");
            Ma=int.Parse(System.Console.ReadLine());
            System.Console.Write("Nhap ho ten: ");
            HoTen=Console.ReadLine();
            System.Console.Write("Nhap muc luong: ");
            MucLuong=double.Parse(System.Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Ho va ten {HoTen}, ma: {Ma}, muc luong: {MucLuong}, tong luong: {TinhLuong()}";
        }
    }
}