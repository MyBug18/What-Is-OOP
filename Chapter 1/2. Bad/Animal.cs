using System;

public enum AnimalType
{
    Dog,
    Cat,
    Elephant,
    Else,
}
public class Animal
{
    public AnimalType Type;

    public void Bark()
    {
        switch (Type)
        {
            case AnimalType.Dog:
                Console.WriteLine("Dog Dog");
                break;
            case AnimalType.Cat:
                Console.WriteLine("Cat Cat");
                break;
            case AnimalType.Elephant:
                Console.WriteLine("Ele Ele");
                break;
            case AnimalType.Else:
                Console.WriteLine("Animal Animal");
                break;
        }
    }

    public void Eat()
    {
        switch (Type)
        {
            case AnimalType.Dog:
                Console.WriteLine("Ate dog food!");
                break;
            case AnimalType.Cat:
                Console.WriteLine("Ate cat food!");
                break;
            case AnimalType.Elephant:
                Console.WriteLine("Ate grass!");
                break;
            case AnimalType.Else:
                Console.WriteLine("Ate animal food!");
                break;
        }
    }
}
