using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai1
{
    class DaiHoc
    {
        public List<PhongHoc> DSPhongHoc { get; set; }
        public DaiHoc()
        {
            DSPhongHoc = new List<PhongHoc>();
        }
        public void ThemPhongHoc(PhongHoc phong)
        {
            DSPhongHoc.Add(phong);
        }
        public void HienThiTatCaPhongHoc()
        {
            foreach (var phong in DSPhongHoc)
            {
                Console.WriteLine(phong.ToString());
            }
        }
        public PhongHoc TimPhongHoc(string maPhong)
        {
            return DSPhongHoc.FirstOrDefault(phong => phong.MaPhong == maPhong);
        }
        public int TinhTongSoPhongHoc()
        {
            return DSPhongHoc.Count;
        }
        public double TinhTongDienTichPhongThucHanh()
        {
            return DSPhongHoc.OfType<PhongThucHanh>().Sum(phong => phong.DienTich);
        }
        public void InDanhSachPhongHocDatChuan()
        {
            var danhSachDatChuan = DSPhongHoc.Where(phong => phong.DanhGia() == "Dat chuan");
            foreach (var phong in danhSachDatChuan)
            {
                Console.WriteLine(phong.ToString());
            }
        }
        public void InDanhSachPhongThucHanhSoMayTren40()
        {
            var danhSach = DSPhongHoc.OfType<PhongThucHanh>().Where(phong => phong.SoLuongMayTinh > 40);
            foreach (var phong in danhSach)
            {
                Console.WriteLine(phong.ToString());
            }
        }
        public void SapXepDanhSachPhongHoc()
        {
            DSPhongHoc = DSPhongHoc.OrderBy(phong => phong.DienTich)
                                .ThenByDescending(phong => phong.SoBongDen)
                                .ToList();
        }
    }
}