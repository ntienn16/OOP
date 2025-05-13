namespace Bai3;
class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Nhap so luong can bo: ");
        int n=int.Parse(Console.ReadLine());
        List<CanBo> dsCanBo=new List<CanBo>();
        for(int i=0; i<n;i++)
        {
            CanBo canBo=new CanBo();
            System.Console.WriteLine($"Nhap thong tin can bo {i+1}");
            canBo.Input();
            dsCanBo.Add(canBo);
        }
        CanBo canBoLuongMax=dsCanBo[0];
        CanBo canBoLuongMin=dsCanBo[0];
        foreach(CanBo cb in dsCanBo)
        {
            if(cb.Luong()>canBoLuongMax.Luong())
            {
                canBoLuongMax=cb;
            }
            if(cb.Luong()<canBoLuongMin.Luong())
            {
                canBoLuongMin=cb;
            }
        }
        System.Console.Write("Can bo luong cao nhat: ");
        canBoLuongMax.Output();
        System.Console.Write("Can bo luong thap nhat: ");
        canBoLuongMin.Output();
    }
}