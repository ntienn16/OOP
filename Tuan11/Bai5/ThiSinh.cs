using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai5
{
    public class ThiSinh
    {
        public int SoBaoDanh{get; set;}
        public string TenThiSinh{get; set;}
        public double DiemM1{get; set;}
        public double DiemM2{get; set;}
        public double DiemM3{get; set;}
        public void Input()
        {
            System.Console.Write("Nhap SBD: ");
            SoBaoDanh=int.Parse(System.Console.ReadLine());
            System.Console.Write("Nhap ten thi sinh: ");
            TenThiSinh=Console.ReadLine();
            System.Console.Write("Nhap diem mon 1: ");
            DiemM1=double.Parse(System.Console.ReadLine());
            System.Console.Write("Nhap diem mon 2: ");
            DiemM2=double.Parse(System.Console.ReadLine());
            System.Console.Write("Nhap diem mon 3: ");
            DiemM3=double.Parse(System.Console.ReadLine());
        }
        public double TongDiem()
        {
            return DiemM1+DiemM2+DiemM3;
        }
        public override string ToString()
        {
            return $"Thi sinh {TenThiSinh}, SBD: {SoBaoDanh}, diem mon 1: {DiemM1}, diem mon 2: {DiemM2}, diem mon 3: {DiemM3}, tong diem: {TongDiem()}";
        }
    }
}