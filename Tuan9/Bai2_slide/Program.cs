namespace Bai2_slide;

class Program
{
    static void Main(string[] args)
    {
        Quat quat= new Quat();
        quat.TurnOff();
        System.Console.WriteLine(quat.ToString());

        DieuHoa dieuHoa= new DieuHoa();
        dieuHoa.TurnOn();
        System.Console.WriteLine(dieuHoa.ToString());

        TV tv= new TV();
        tv.TurnOff();
        System.Console.WriteLine(tv.ToString());
    }
}
