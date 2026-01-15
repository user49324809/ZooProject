using System;

abstract class Animal
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0) age = value;
        }
    }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound();

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} ест еду.");
    }
}