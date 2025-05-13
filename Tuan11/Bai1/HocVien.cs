using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai11
{
    public class HocVien
    {
        public string MaSo{ get; set; }
        public string HoTen{ get; set; }
        public int Tuoi{get; set; }
        public void Input()
        {
            Console.Write("Nhap ma so: ");
            MaSo=Console.ReadLine();
            System.Console.Write("Nhap ho ten: ");
            HoTen=Console.ReadLine();
            System.Console.Write("Nhap tuoi: ");
            Tuoi=int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"Hoc vien: {HoTen}, ma so hoc vien: {MaSo}, tuoi: {Tuoi}");
        }
    }
}