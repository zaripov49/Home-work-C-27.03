namespace Domain;

public class Laptop : Computer
{
    public double Weight { get; set; }
    public double Size { get; set; }

    public Laptop(int ram, int storage, string keyboard, double weight, double size) : base(ram, storage, keyboard)
    {
        Weight = weight;
        Size = size;
    }

    public void WeightCheck()
    {
        if (Weight > 2.5)
        {
            System.Console.WriteLine("Ноутбук тяжелый!");
        }
        else
        {
            System.Console.WriteLine("Ноутбук легкий!");
        }
    }

    public void SizeCheck()
    {
        if (Size > 30)
        {
            System.Console.WriteLine("Ноутбук большого размера");
        }
        else
        {
            System.Console.WriteLine("Ноутбук среднего размера");
        }
    }
}
