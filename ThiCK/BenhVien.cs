using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThiCK
{
    public class BenhVien
    {
        private List<BacSi> DSBacSi=new List<BacSi>();
        public void NhapBS()
        {
            System.Console.WriteLine("Them bac si vao danh sach");
            System.Console.Write("1. Bac si toan thoi gian/ 2. Bac si ban thoi gian: ");
            int choice=int.Parse(System.Console.ReadLine());
            BacSi bacSi=null;
            switch(choice)
            {
                case 1:
                    bacSi=new BSToanTG();
                    break;
                case 2:
                    bacSi=new BSBanTG();
                    break;
                default:
                    System.Console.WriteLine("Khong hop le");
                    return;
            }
            bacSi.Nhap();
            DSBacSi.Add(bacSi);
        }
        public void HienThi()
        {
            System.Console.WriteLine("Danh sach bac si:");
            foreach(var bacSi in DSBacSi)
            {
                System.Console.WriteLine(bacSi.ToString());
            }
        }
        public void TimKiem(int Ma)
        {
        var ketQua = DSBacSi.FirstOrDefault(bs => bs.Ma == Ma);
            if (ketQua != null)
            {
                System.Console.WriteLine(ketQua.ToString());
            }
            else
            {
                System.Console.WriteLine("Khong tim thay");
            }
        }
        public double TinhLuongBS()
        {
            return DSBacSi.OfType<BSToanTG>().Sum(bs => bs.TinhLuong());
        }
    }
}