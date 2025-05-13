namespace Bai1_slide
{
    public class HinhTron: Hinhhoc
    {
        public double banKinh;
        public HinhTron()
        {}
        public HinhTron(double banKinh)
        {
            this.banKinh = banKinh;
        }
        public override double ChuVi()
        {
            return Math.PI*banKinh*2;
        }
        public override double DienTich()
        {
            return Math.PI*banKinh*banKinh;
        }
    }
}