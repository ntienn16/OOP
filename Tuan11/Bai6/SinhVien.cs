using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai6
{
    public class SinhVien: Nguoi
    {
        public string MaSinhVien{ get; set; }
        public double DTB{ get; set; }
        public new void Input()
        {
            base.Input();
            System.Console.Write("Nhap ma sinh vien: ");
            MaSinhVien=Console.ReadLine();
            System.Console.Write("Diem trung binh: ");
            DTB=double.Parse(System.Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString()+$", ma sinh vien: {MaSinhVien}, diem trung binh: {DTB}";
        }
    }
}