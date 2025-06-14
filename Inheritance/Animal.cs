namespace Inheritance;

public class Animal
{
    public Animal()
    {

    }
    
    public int Legs { get; set; }
    public int Eyes { get; set; }
    public bool Heterotrophic { get; set; }
    public bool Multicellular { get; set; }
}

public class Bird : Animal
{
    public Bird()
    {
        Feathers = true;
        LayEggs = true;
        Beak = true;
        Bipedal = true;
    }
    public bool Feathers { get; set; }
    public bool LayEggs { get; set; }
    public bool Beak { get; set; }
    public bool Bipedal { get; set; }
}

public class Reptile : Animal
{
    public Reptile()
    {
        ColdBlooded = true;
        Scales = true;
        InternalFertilization = true;
        ThreeOrMoreHeartChambers = true;
    }
    public bool ColdBlooded { get; set; }
    public bool Scales { get; set; }
    public bool InternalFertilization { get; set; }
    public bool ThreeOrMoreHeartChambers { get; set; }
    
}