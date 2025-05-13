using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai2
{
    public class QLCB
    {
        private List<CanBo> dsCanBo=new List<CanBo>();
        public void Nhap()
        {
            System.Console.WriteLine("Nhap loai can bo:");
            System.Console.Write("1. Cong nhan/ 2.Ky su/ 3.Nhan vien: ");
            int luachon=int.Parse(System.Console.ReadLine());
            CanBo canBo=null;
            switch (luachon)
            {
                case 1:
                    canBo=new CongNhan();
                    break;
                case 2:
                    canBo=new KySu();
                    break;
                case 3:
                    canBo=new NhanVien();
                    break;
                default:
                    System.Console.WriteLine("Khong hop le");
                    return;
            }
            canBo.Nhap();
            dsCanBo.Add(canBo);
        }
        public void TimKiem(string hoTen)
        {
           foreach (var canBo in dsCanBo)
           {
            var ketQua = dsCanBo.Where(cb => cb.HoTen.Contains(hoTen)).ToList();
            if (ketQua.Count > 0)
            {
                foreach (var cb in ketQua)
                {
                    cb.HienThi();
                }
            }
            else
            {
                System.Console.WriteLine("Khong tim thay can bo");
            }
           } 
        }
        public void HienThiCanBo()
        {
            foreach (var canBo in dsCanBo)
            {
                canBo.HienThi();
                System.Console.WriteLine("");
            }
        }
        public void HienThiKySu()
        {
            foreach(var canBo in dsCanBo.OfType<KySu>())
            {
                canBo.HienThi();
                System.Console.WriteLine("");
            }
        }
    }
}