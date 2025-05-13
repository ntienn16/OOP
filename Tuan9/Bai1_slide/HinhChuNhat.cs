namespace Bai1_slide
{
    public class HinhChuNhat: Hinhhoc
    {
        public double chieuDai;
        public double chieuRong;
        public HinhChuNhat()
        {}
        public HinhChuNhat(double chieuDai, double chieuRong):base()
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }
        public override double ChuVi()
        {
            return (chieuDai+chieuRong)*2;
        }
        public override double DienTich()
        {
            return chieuDai*chieuRong;
        }
    }
}