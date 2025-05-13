using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai2
{
    public class CongNhan:CanBo
    {
        public int Bac{ get; set; }
        public override void Nhap()
        {
            base.Nhap();
            System.Console.Write("Nhap bac: ");
            Bac=int.Parse(System.Console.ReadLine());
        }
        public override void HienThi()
        {
            base.HienThi();
            System.Console.WriteLine($"Bac: {Bac}");
        }
    }
}