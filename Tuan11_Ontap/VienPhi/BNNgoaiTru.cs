using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VienPhi
{
    public class BNNgoaiTru:BenhNhan
    {
        public double PhiKham{get; set; }
        public double PhiXetNghiem{get; set; }
        public override double VienPhi()
        {
            return PhiKham+PhiXetNghiem+TienThuoc;
        }
        public BNNgoaiTru(int Ma, string HoTen, double TienThuoc, double PhiKham, double PhiXetNghiem): base(Ma, HoTen, TienThuoc)
        {
            this.PhiKham=PhiKham;
            this.PhiXetNghiem=PhiXetNghiem;   
        }
        public BNNgoaiTru()
        {

        }
        public override void Input()
        {
            base.Input();
        }
        public override string ToString()
        {
            return base.ToString()+$", Phi kham: {PhiKham}, Phi xet nghiem {PhiXetNghiem}";
        }
    }
}