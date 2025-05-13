using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai3
{
    public class DaiHoc
    {
       private List<NguoiLaoDong> DSNguoiLD;
       public DaiHoc()
       {
        DSNguoiLD=new List<NguoiLaoDong>();
       } 
       public void Them(NguoiLaoDong nguoiLaoDong)
       {
        DSNguoiLD.Add(nguoiLaoDong);
       }
       public void HienThi()
       {
        foreach(var nld in DSNguoiLD)
        {
            System.Console.WriteLine(nld.ToString());
        }
       }
       public void TimKiem(string ma)
       {
        var ketQua = DSNguoiLD.FirstOrDefault(nld => nld.Ma == ma);
        if (ketQua != null)
        {
            System.Console.WriteLine(ketQua.ToString());
        }
        else
        {
            System.Console.WriteLine("Khong tim thay");
        }
       }
       public double TongLuongGiangVien()
       {
        return DSNguoiLD.OfType<GiangVien>().Sum(gv=>gv.TinhLuong());
       }
       public void InNhanVienLuong10m()
       {
        foreach (var nld in DSNguoiLD.Where(nld => nld.TinhLuong() > 10000000))
        {
        
            System.Console.WriteLine(nld.ToString());
        }
       }
       public void SapXep()
       {
        DSNguoiLD=DSNguoiLD.OrderByDescending(nld => nld.HoTen).ThenByDescending(nld=>nld.Ma).ToList();
        System.Console.WriteLine("Danh sach sau khi sap xep:");
        HienThi();
       }
       public void ThongKe()
       {
        int soGiangVien=DSNguoiLD.OfType<GiangVien>().Count();
        int soNhanVien=DSNguoiLD.OfType<NhanVien>().Count();
        System.Console.WriteLine($"So giang vien: {soGiangVien}, so nhan vien: {soNhanVien}");
       }
    }
}