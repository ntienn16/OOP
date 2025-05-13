namespace Bai1_slide
{
    public class HinhTamGiac:Hinhhoc
    {
        public double canhA;
        public double canhB;
        public double canhC;
        public HinhTamGiac()
        {}
        public HinhTamGiac(double canhA, double canhB, double canhC)
        {
            this.canhA = canhA;
            this.canhB = canhB;
            this.canhC = canhC;
        }
        public override double ChuVi()
        {
            return canhA+canhB+canhC;
        }
        public override double DienTich()
        {
            double p=ChuVi()/2;
            return Math.Sqrt(p*(p-canhA)*(p-canhB)*(p-canhC));
        }
    }
}