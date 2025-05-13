using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai2
{
    public class KySu:CanBo
    {
        public string NganhDaoTao{ get; set; }
        public string LoaiBang{ get; set; }
        public override void Nhap()
        {
            base.Nhap();
            System.Console.Write("Nhap nganh dao tao: ");
            NganhDaoTao=Console.ReadLine();
            System.Console.Write("Nhap loai bang: ");
            LoaiBang=Console.ReadLine();
        }
        public override void HienThi()
        {
            base.HienThi();
            System.Console.WriteLine($"Nganh dao tao: {NganhDaoTao}, loai bang: {LoaiBang}");
        }
    }
}