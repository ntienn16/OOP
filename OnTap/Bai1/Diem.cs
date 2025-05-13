using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai1
{
    public class Diem
    {
        public double HoanhDo{get; set;}
        public double TungDo{get; set;}
        public Diem()
        {}
        public Diem(double hoanhDo, double tungDo)
        {
            HoanhDo = hoanhDo;
            TungDo = tungDo;
        }
        public void Nhap()
        {
            System.Console.Write("Nhap hoanh do: ");
            HoanhDo=double.Parse(System.Console.ReadLine());
            System.Console.Write("Nhap tung do: ");
            TungDo=double.Parse(System.Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Diem ({HoanhDo},{TungDo})";
        }
        public double KhoangCach(Diem diemKhac)
        {
             return Math.Sqrt(Math.Pow(HoanhDo - diemKhac.HoanhDo, 2) + Math.Pow(TungDo - diemKhac.TungDo, 2));
        }
    }
}