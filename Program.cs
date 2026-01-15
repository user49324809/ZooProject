using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Animal> zoo = new List<Animal>
        {
            new Dog("Бобик", 3),
            new Cat("Мурка", 2),
            new Cow("Буренка", 5)
        };

        foreach (Animal animal in zoo)
        {
            Console.WriteLine($"Животное: {animal.Name}, возраст: {animal.Age}");
            animal.MakeSound();
            animal.Eat();
            Console.WriteLine();
        }
    }
}
