namespace Domain;

public class Computer
{
    public int Ram { get; set; }
    public int Storage { get; set; }
    public string? Keyboard { get; set; }

    public Computer(int ram, int storage, string keyboard)
    {
        Ram = ram;
        Storage = storage;
        Keyboard = keyboard;
    }

    public void AddRam(int newRam)
    {
        Ram += newRam;
        System.Console.WriteLine("Ram увеличена: " + Ram);
    }

    public void AddStorage(int newStorage)
    {
        Storage += newStorage;
        System.Console.WriteLine("Память увеличена: " + Storage);
    }
}
