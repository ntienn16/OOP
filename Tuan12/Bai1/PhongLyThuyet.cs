using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai1;

namespace Bai1
{
    class PhongLyThuyet : PhongHoc
    {
        public int MayChieu { get; set; }

        public PhongLyThuyet() : base() { }

        public PhongLyThuyet(string maPhong, string dayNha, double dienTich, int soBongDen, int mayChieu)
            : base(maPhong, dayNha, dienTich, soBongDen)
        {
            MayChieu = mayChieu;
        }

        public override string DanhGia()
        {
            double trungBinh = DienTich / SoBongDen;

            if (trungBinh <= 10 && MayChieu > 0)
            {
                return "Dat chuan";
            }
            return "Khong dat chuan";
        }

        public override void Nhap()
        {
            base.Nhap(); 

            Console.Write("Nhap so luong may chieu: ");
            MayChieu = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + $", May chieu: {MayChieu}, Danh gia: {DanhGia()}";
        }
    }
}