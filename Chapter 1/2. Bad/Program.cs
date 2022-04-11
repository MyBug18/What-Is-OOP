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

        var result = new Animal();

        switch (val)
        {
            case 0:
                result.Type = AnimalType.Dog;
                break;

            case 1:
                result.Type = AnimalType.Cat;
                break;
            case 2:
                result.Type = AnimalType.Elephant;
                break;
        }

        return result;
    }
}
