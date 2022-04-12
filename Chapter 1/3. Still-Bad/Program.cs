using System;

public class Program
{
    static void Main(string[] args)
    {
        var animal = GetRandomAnimal();

        switch (animal)
        {
            case Dog dog:
                dog.Bark();
                break;
            case Cat cat:
                cat.Bark();
                break;
            case Elephant elephant:
                elephant.Bark();
                break;
            case ElseAnimal elseAnimal:
                elseAnimal.Bark();
                break;
        }

        switch (animal)
        {
            case Dog dog:
                dog.Eat();
                break;
            case Cat cat:
                cat.Eat();
                break;
            case Elephant elephant:
                elephant.Eat();
                break;
            case ElseAnimal elseAnimal:
                elseAnimal.Eat();
                break;
        }
    }

    private static readonly Random r = new Random();

    private static object GetRandomAnimal()
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
                return new ElseAnimal();
        }
    }
}
