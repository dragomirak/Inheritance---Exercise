namespace PlayersAndMonsters;

public class Hero
{
    public Hero(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public string Name { get; set; }
    public int Level { get; set; }
    public override string ToString()
    {
        return $"Type: {GetType().Name} Username: {Name} Level: {Level}";
    }

}
