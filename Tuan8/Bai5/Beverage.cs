namespace Bai5
{
    public class Beverage : Product
    {
        public double Milliliters { get; set; }

        public Beverage(string name, decimal price, double milliliters)
            : base(name, price)
        {
            Milliliters = milliliters;
        }
    }
    public class ColdBeverage : Beverage
    {
        public ColdBeverage(string name, decimal price, double milliliters)
            : base(name, price, milliliters)
        {
        
        }
    }
    public class HotBeverage : Beverage
    {
        public HotBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        
        }
    }
    public class Coffee : HotBeverage
{
    public const double CoffeeMilliliters = 50;
    public const decimal CoffeePrice = 3.50m;
    public double Caffeine { get; set; }

    public Coffee(string name, double caffeine) : base(name, CoffeePrice, CoffeeMilliliters)
    {
        Caffeine = caffeine;
    }
}

public class Tea : HotBeverage
{
    public Tea(string name, decimal price, double milliliters) : base(name, price, milliliters)
    {
    
    }
}

}