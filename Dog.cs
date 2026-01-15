using System;

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} лает: Гав-гав!");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} ест косточку.");
    }
}