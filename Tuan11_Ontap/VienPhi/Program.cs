namespace VienPhi;

class Program
{
    static void Main(string[] args)
    {
        BenhNhan benhNhan= new BenhNhan(1,"BN A",15);
        //System.Console.WriteLine(benhNhan);
        BNNgoaiTru bNNgoaiTru= new BNNgoaiTru(2,"BN B", 10,20,30);
        //System.Console.WriteLine(bNNgoaiTru);
        BNNoiTru bNNoiTru= new BNNoiTru(3,"BN C", 10, 10,5);
        //System.Console.WriteLine(bNNoiTru);
        BenhVien benhVien= new BenhVien();
        benhVien.ThemBenhNhan(benhNhan);
        benhVien.ThemBenhNhan(bNNgoaiTru);
        benhVien.ThemBenhNhan(bNNoiTru);
        benhVien.ThemBenhNhan(new BNNoiTru(4,"BN D", 10, 15,10));
        benhVien.Output();
        benhVien.TongVienPhi();
        benhVien.TongVienPhiNoiTru();
    }
}
