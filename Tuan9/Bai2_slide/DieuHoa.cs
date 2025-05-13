namespace Bai2_slide
{
    public class DieuHoa: iDevice
    {
        public bool isOn;
        public void TurnOn()
        {
            isOn=true;
        }
        public void TurnOff()
        {
            isOn=false;
        }
        public bool IsOn
        {
            get {return isOn;}
        }
        public override string ToString()
        {
            return $"Dieu hoa đa {(isOn ? "bat" : "tat")}.";
        }
    }
}