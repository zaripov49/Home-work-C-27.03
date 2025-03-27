namespace Domain;

public class SmartPhone : Computer
{
    public int NumberOfSelfies { get; set; }
    public string? Model { get; set; }

    public SmartPhone(int ram, int storage, string keyboard, int numberOfSelfies, string model) : base(ram, storage, keyboard)
    {
        NumberOfSelfies = numberOfSelfies;
        Model = model;
    }

    public void TakeSelfies(int selfies)
    {
        NumberOfSelfies += selfies;
        System.Console.WriteLine("Еще сделано " + selfies + " фото всего " + NumberOfSelfies + " фото");
    }
    
    public string? ModelInfo()
    {
        return Model;
    }
}
