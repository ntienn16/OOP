using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai2
{
    public class NhanVien:CanBo
    {
        public string CongViec{ get; set; }
        public override void Nhap()
        {
            base.Nhap();
            System.Console.Write("Nhap cong viec: ");
            CongViec=Console.ReadLine();
        }
        public override void HienThi()
        {
            base.HienThi();
            System.Console.WriteLine($"Cong viec: {CongViec}");
        }
    }
}