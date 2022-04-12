using System;

public class Cat : Animal
{
    public override void Bark()
    {
        Console.WriteLine("Cat Cat");
    }

    public override void Eat()
    {
        Console.WriteLine("Ate cat food!");
    }
}