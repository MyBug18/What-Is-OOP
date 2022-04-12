using System;

public class Elephant : Animal
{
    public override void Bark()
    {
        Console.WriteLine("Ele Ele");
    }

    public override void Eat()
    {
        Console.WriteLine("Ate grass!");
    }
}