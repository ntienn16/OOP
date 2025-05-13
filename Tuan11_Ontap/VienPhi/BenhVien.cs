using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VienPhi;

namespace VienPhi
{
    public class BenhVien
    {
        public List<BenhNhan> DSBenhNhan{get; set;}
        public BenhVien()
        {
            DSBenhNhan = new List<BenhNhan>();
        }
        public void ThemBenhNhan(BenhNhan bn)
        {
            DSBenhNhan.Add(bn);
        }
        public void Output()
        {
            foreach(var bn in DSBenhNhan)
            {
                System.Console.WriteLine(bn);
            }
        }
        public void TongVienPhi()
        {
            double tong=0;
            foreach(var bn in DSBenhNhan)
            {
                tong=tong+bn.VienPhi();
            }
            System.Console.WriteLine($"Tong tien vien phi: {tong}");
        }
        public void TongVienPhiNoiTru()
        {
            double tong=0;
            foreach(var bn in DSBenhNhan)
            {
                if(bn is BNNoiTru)
                    tong=tong+bn.VienPhi();
            }
            System.Console.WriteLine($"Tong tien vien phi noi tru: {tong}");
        }
        //Sắp xếp
        public void SapXep()
        {
            DSBenhNhan.OrderBy(b=>b.HoTen).ThenBy(b=>b.Ma).ToList();
        }
        //Tìm
        public BenhNhan TimTheoMa(int ma)
        {
            foreach (var bn in DSBenhNhan)
            {
                if(bn.Ma==ma) return bn;
            } return null;
        }
    }
}