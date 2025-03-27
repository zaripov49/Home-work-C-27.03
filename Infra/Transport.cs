namespace Infra;

public class Transport
{
    public int CountTires { get; set; }
    public string? Color { get; set; }
    public int KmH { get; set; }

    public Transport(int countTires, string color, int kmH)
    {
        CountTires = countTires;
        Color = color;
        KmH = kmH;
    }
}
