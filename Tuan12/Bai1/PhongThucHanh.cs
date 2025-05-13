using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai1
{
    public class PhongThucHanh: PhongHoc
    {
        public int SoLuongMayTinh { get; set; }
        public PhongThucHanh() : base() { }
        public PhongThucHanh(string maPhong, string dayNha, double dienTich, int soBongDen, int soLuongMayTinh)
            : base(maPhong, dayNha, dienTich, soBongDen)
        {
            SoLuongMayTinh = soLuongMayTinh;
        }
        public override string DanhGia()
        {
            double trungBinh = DienTich / SoLuongMayTinh;

            if (trungBinh >= 1.5)
            {
                return "Dat chuan";
            }
            return "Khong dat chuan";
        }
        public override void Nhap()
        {
            base.Nhap(); 

            Console.Write("Nhap so luong may tinh: ");
            SoLuongMayTinh = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString() + $", So luong may tinh: {SoLuongMayTinh}, Danh gia: {DanhGia()}";
        }
    }
}