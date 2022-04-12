using System;

public class Program
{
    static void Main(string[] args)
    {
        var animal = GetRandomAnimal();

        animal.Bark();
        animal.Eat();
    }

    private static readonly Random r = new Random();

    private static Animal GetRandomAnimal()
    {
        var val = r.Next() % 4;

        switch (val)
        {
            case 0:
                return new Dog();
            case 1:
                return new Cat();
            case 2:
                return new Elephant();
            default:
                return new Animal();
        }
    }
}
