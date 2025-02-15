class Charmander : Pokemon
{
    public Charmander() : base("Charmander", "Fire")
    {
    }

    public override void BattleCry()
    {
        Console.WriteLine("Charmander!");
    }
}