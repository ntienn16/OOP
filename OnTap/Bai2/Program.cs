namespace Bai2;

class Program
{
    static void Main(string[] args)
    {
        QLCB qLCB= new QLCB();
        while (true)
        {
            System.Console.WriteLine("\nChon chuc nang: ");
            System.Console.WriteLine("1.Them can bo moi");
            System.Console.WriteLine("2. Tim kiem ten can bo");
            System.Console.WriteLine("3. Hien thi danh sach can bo");
            System.Console.WriteLine("4. Hien thi danh sach ky su");
            System.Console.WriteLine("0. Thoat");
            int chucnang=int.Parse(System.Console.ReadLine());
            switch (chucnang)
            {
                case 1:
                    qLCB.Nhap();
                    break;
                case 2:
                    System.Console.Write("Nhap ten can tim: ");
                    string timKiem=Console.ReadLine();
                    qLCB.TimKiem(timKiem);
                    break;
                case 3:
                    qLCB.HienThiCanBo();
                    break;
                case 4:
                    qLCB.HienThiKySu();
                    break;
                case 0:
                    return;
                default:
                    System.Console.WriteLine("Khong hop le");
                    break;
            }
        }
    }
}
