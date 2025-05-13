namespace Bai2_slide
{
    public class Quat: iDevice
    {
        public bool isOn;
        public void TurnOn()
        {
            isOn = true;
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
            return $"Quat đang {(isOn ? "bat" : "tat")}.";
        }
    }
}