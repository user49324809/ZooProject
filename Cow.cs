using System;

class Cow : Animal
{
    public Cow(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} мычит: Му-у!");
    }
}