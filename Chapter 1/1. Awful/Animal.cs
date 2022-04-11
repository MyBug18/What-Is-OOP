using System;

public class Animal
{
    public bool IsDog;

    public bool IsCat;

    public bool IsElephant;

    public void Bark()
    {
        if (IsDog)
        {
            Console.WriteLine("Dog Dog");

            return;
        }

        if (IsCat)
        {
            Console.WriteLine("Cat Cat");

            return;
        }

        if (IsElephant)
        {

            Console.WriteLine("Ele Ele");

            return;
        }

        Console.WriteLine("Animal Animal");
    }

    public void Eat()
    {
        if (IsDog)
        {
            Console.WriteLine("Ate dog food!");

            return;
        }

        if (IsCat)
        {
            Console.WriteLine("Ate cat food!");

            return;
        }

        if (IsElephant)
        {
            Console.WriteLine("Ate grass!");

            return;
        }

        Console.WriteLine("Ate animal food!");
    }
}
