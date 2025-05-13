using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThiCK
{
    public class BSToanTG:BacSi
    {
        public double LuongKham{ get; set; }
        public double LuongXetNghiem{ get; set; }
        public override double TinhLuong()
        {
            return LuongKham+LuongXetNghiem+MucLuong;
        }
        public override void Nhap()
        {
            base.Nhap();
            System.Console.Write("Nhap luong kham: ");
            LuongKham=double.Parse(System.Console.ReadLine());
            System.Console.Write("Nhap luong xet nghiem: ");
            LuongXetNghiem=double.Parse(System.Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString()+$", luong kham: {LuongKham}, luong xet nghiem: {LuongXetNghiem}";
        }
    }
}