class Squirtle : Pokemon
{
    public Squirtle() : base("Squirtle", "Water")
    {
    }

    public override void battleCry()
    {
        Console.WriteLine("Squirtle!");
    }
}
