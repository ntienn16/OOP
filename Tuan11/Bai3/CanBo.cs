using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai3
{
    public class CanBo
    {
        public string MaSo{ get; set; }
        public string HoTen{ get; set; }
        public double HeSoLuong{get; set; }
        public void Input()
        {
            System.Console.Write("Nhap ma so: ");
            MaSo=Console.ReadLine();
            System.Console.Write("Nhap ho ten: ");
            HoTen=Console.ReadLine();
            System.Console.Write("Nhap he so luong: ");
            HeSoLuong=double.Parse(Console.ReadLine());
        }
        public double Luong()
        {
            return HeSoLuong*2340000;
        }
        public void Output()
        {
            System.Console.WriteLine($"Can bo {HoTen}, ma so: {MaSo}, he so luong: {HeSoLuong}, luong: {Luong()}");
        }
    }
}