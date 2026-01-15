using System;

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} мяукает: Мяу!");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} ест рыбу.");
    }
}