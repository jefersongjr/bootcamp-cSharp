namespace AnimalsPOO.Models;

public class Owl : Animal,  Oviparous, Flyer
{
    public int EggAmount {get; set;}

    public Owl(string name, int age, int eggAmount) : base(name, age) 
    {
        EggAmount = eggAmount;
    }

    public Owl()
    {}

    public override string Comer() {
        return "Comendo Frutas";
    }

    public void LayEggs() {
        Console.WriteLine($"{Name} colocou {EggAmount} ovos");
    }

    public void Fly()
    {
        Console.WriteLine($"{Name} voou");
    }
}