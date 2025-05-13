namespace Bai1_slide
{
    public class HinhVuong:Hinhhoc
    {
        double canhHV;
        public HinhVuong()
        {}
        public HinhVuong(double canhHV)
        {
            this.canhHV = canhHV;
        }
        public override double ChuVi()
        {
            return 4*canhHV;
        }
        public override double DienTich()
        {
            return canhHV*canhHV;
        }
    }
}