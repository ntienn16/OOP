namespace ThiCK;

class Program
{
    static void Main(string[] args)
    {
        BenhVien benhVien1=new BenhVien();
        while (true)
        {
            System.Console.WriteLine("\nChon chuc nang:");
            System.Console.WriteLine("1. Them bac si");
            System.Console.WriteLine("2. Hien thi thong tin tat ca bac si");
            System.Console.WriteLine("3. Tim kiem bac si theo ma");
            System.Console.WriteLine("4. Tinh tong luong bac si toan thoi gian");
            System.Console.WriteLine("0. Thoat");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    benhVien1.NhapBS();
                    break;
                case 2:
                    benhVien1.HienThi();
                    break;
                case 3:
                    System.Console.Write("Nhap ma can tim kiem: ");
                    int maTK=int.Parse(Console.ReadLine());
                    benhVien1.TimKiem(maTK);
                    break;
                case 4:
                    benhVien1.TinhLuongBS();
                    System.Console.WriteLine("Tong luong bac si toan thoi gian: "+benhVien1.TinhLuongBS());
                    break;
                case 0:
                    System.Console.WriteLine("Thoat chuong trinh");
                    return;
                default:
                    System.Console.WriteLine("Khong hop le");
                    break;
            }
        }
    }
}
