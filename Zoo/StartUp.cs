using System;
using System.Collections.Generic;

namespace Zoo;

public class StartUp
{
    public static void Main(string[] args)
    {
        List<Mammal> mammals = new List<Mammal>();
        mammals.Add(new Bear("Masha"));
        mammals.Add(new Gorilla("Pesho"));

        foreach (Mammal mammal in mammals)
        {
            Console.WriteLine($"Type: {mammal.GetType().Name}, Name: {mammal.Name}");
        }

        List<Reptile> reptiles = new List<Reptile>();
        reptiles.Add(new Lizard("Ivan"));
        reptiles.Add(new Snake("Zoya"));

        foreach (Reptile reptile in reptiles)
        {
            Console.WriteLine($"Type: {reptile.GetType().Name}, Name {reptile.Name}");
        }

    }
}