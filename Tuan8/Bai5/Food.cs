namespace Bai5
{
    public class Food : Product
    {
        public double Grams { get; set; }
        public Food(string name, decimal price, double grams) : base(name, price)
        {
            Grams = grams;
        }
    }
    /// /////
    public class MainDish : Food
    {
        public MainDish(string name, decimal price, double grams) : base(name, price, grams)
        {

        }
    }
    public class Starter : Food
    {
        public Starter(string name, decimal price, double grams) : base(name, price, grams)
        {

        }
    }

    public class Dessert : Food
    {
        public double Calories { get; set; }
        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            Calories = calories;
        }
    }
    /// //////////////////
    public class Cake : Dessert
    {
        public const double CakeGrams = 250;
        public const double CakeCalories = 1000;
        public const decimal CakePrice = 5m;
        public Cake(string name) : base(name, CakePrice, CakeGrams, CakeCalories)
        {

        }
    }
    public class Fish : MainDish
    {
        public const double FishGrams = 22;
        public Fish(string name, decimal price) : base(name, price, FishGrams)
        {
        
        }
    }
    public class Soup : Starter
    {
        public Soup(string name, decimal price, double grams): base(name, price, grams)
        {
        
        }
    }
}