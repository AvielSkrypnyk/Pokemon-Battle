class Squirtle : Pokemon
{
    public Squirtle() : base("Squirtle", "Water")
    {
    }

    public override void BattleCry()
    {
        Console.WriteLine("Squirtle!");
    }
}
