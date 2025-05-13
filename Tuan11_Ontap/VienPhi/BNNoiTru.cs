using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VienPhi
{
    public class BNNoiTru: BenhNhan
    {
        public double PhiNgay{get;set;}
        public int SoNgayNamVien{get;set;}
        double PhuPhi=0;
        public override double VienPhi()
        {
            if (SoNgayNamVien<10)
                PhuPhi=50;
            else
                PhuPhi=100;
            return TienThuoc*SoNgayNamVien+PhiNgay*SoNgayNamVien+PhuPhi;
        }
        public BNNoiTru(int Ma, string HoTen, double TienThuoc, double PhiNgay, int SoNgayNamVien): base(Ma, HoTen, TienThuoc)
        {
            this.PhiNgay=PhiNgay;
            this.SoNgayNamVien=SoNgayNamVien;
        }
        public BNNoiTru()
        {
            
        }
        public override void Input()
        {
            base.Input();
        }
        public override string ToString()
        {
            return base.ToString()+$", Phi ngay {PhiNgay}, so ngay nam vien {SoNgayNamVien}, phu phi {PhuPhi}";
        }
    }
}