using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai2
{
    public class CanBo
    {
        public string HoTen{get; set;}
        public int NamSinh{get; set;}
        public string GioiTinh{get; set;}
        public string DiaChi{get; set;}
        public CanBo()
        {

        }
        public CanBo(string hoTen, int namSinh, string gioiTinh, string diaChi)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
        }
        public virtual void Nhap()
        {
            System.Console.Write("Nhap ho ten: ");
            HoTen=Console.ReadLine();
            System.Console.Write("Nhap nam sinh: ");
            NamSinh=int.Parse(Console.ReadLine());
            System.Console.Write("Gioi tinh: ");
            GioiTinh=Console.ReadLine();
            System.Console.Write("Dia chi: ");
            DiaChi=Console.ReadLine();
        }
        public virtual void HienThi()
        {
            System.Console.WriteLine($"Ho ten: {HoTen}, sinh nam: {NamSinh}, gioi tinh: {GioiTinh}, dia chi: {DiaChi}");
        }
    }
}