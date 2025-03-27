namespace Infra;

public class Car : Transport
{
    public int Mileage { get; set; }
    
    public Car(int countTires, string color, int kmH, int mileage) : base(countTires, color, kmH)
    {
        Mileage = mileage;
    }
}
