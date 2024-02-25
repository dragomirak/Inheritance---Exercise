using System;
using System.Collections.Generic;

namespace Animals;

public class StartUp
{
    public static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        string input;
        while ((input = Console.ReadLine()) != "Beast!")
        {
            string[] tokens = Console.ReadLine().Split(" ");
            if (input == "Frog")
            {
                try
                {
                    Frog frog = new(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    animals.Add(frog);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (input == "Dog")
            {
                try
                {
                    Dog dog = new(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    animals.Add(dog);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (input == "Cat")
            {
                try
                {
                    Cat cat = new(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    animals.Add(cat);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (input == "Kitten")
            {
                try
                {
                    Kitten kitten = new(tokens[0], int.Parse(tokens[1]));
                    animals.Add(kitten);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (input == "Tomcat")
            {
                try
                {
                    Tomcat tomcat = new(tokens[0], int.Parse(tokens[1]));
                    animals.Add(tomcat);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.GetType().Name);
            Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
            animal.ProduceSound();
        }
    }
}
