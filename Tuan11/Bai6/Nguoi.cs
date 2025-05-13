using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai6
{
    public class Nguoi
    {
        public string HoTen{get; set;}
        public bool GioiTinh{get; set;}
        public string NgaySinh{get; set;}
        public void Input()
        {
            System.Console.Write("Nhap ho ten: ");
            HoTen=Console.ReadLine();
            System.Console.Write("Nhap gioi tinh (nu: true, nam: false): ");
            GioiTinh=bool.Parse(Console.ReadLine());
            System.Console.Write("Nhap ngay sinh dd/mm/yyyy: ");
            NgaySinh=Console.ReadLine();
        }
        public override string ToString()
        {
            return $"{HoTen}, {(GioiTinh ? "Nu" : "Nam")}, {NgaySinh}";
        }
    }
}