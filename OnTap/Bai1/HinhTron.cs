using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai1
{
    public class HinhTron
    {
        public Diem Tam{ get; set; }
        public int Bankinh{ get; set; }
        public HinhTron()
        {
            Tam = new Diem();
            Bankinh=1;
        }
        public HinhTron(Diem Tam, int Bankinh)
        {
            Tam = Tam;
            Bankinh = Bankinh;
        }
        public void Nhap()
        {
            System.Console.Write("Nhap tam hinh tron: ");
            Tam.Nhap();
            Console.Write("Nhap ban kinh: ");
            Bankinh=int.Parse(System.Console.ReadLine());
        }
        public void In()
        {
            System.Console.WriteLine($"Hinh tron: tam={Tam}, ban kinh={Bankinh}");
        }
        public double ChuVi()
        {
            return 2*Math.PI*Bankinh;
        }
        public double DienTich()
        {
            return Math.PI * Math.Pow(Bankinh, 2);
        }
    }
}