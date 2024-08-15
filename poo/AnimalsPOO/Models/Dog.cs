namespace AnimalsPOO.Models;

public class Dog : Animal
{

    public Dog(string Name, int Age) : base(Name, Age)
    {}
    public Dog()
    {}

    public override string Comer() {
        return $"{Name} Comeu a Ração";
    }
}