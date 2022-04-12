using System;

public class Dog : Animal
{
    public override void Bark()
    {
        Console.WriteLine("Dog Dog");
    }

    public override void Eat()
    {
        Console.WriteLine("Ate dog food!");
    }
}