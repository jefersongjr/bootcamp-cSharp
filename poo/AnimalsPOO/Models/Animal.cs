namespace AnimalsPOO.Models;

public abstract class Animal {
    protected string? Name {get; set;}

    public int Age {get; set;}

    public Animal(string name, int age) {
        Name = name;
        Age = age;
    }

    public Animal() {}

    public abstract string Comer(); // metodo abstrato é feito para ser sobrescrito 
    //classe abstrata não pode ser instanciada por um objeto

}