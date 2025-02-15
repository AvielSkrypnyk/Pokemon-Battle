class Bulbasaur : Pokemon
{
    public Bulbasaur() : base(nameof(Bulbasaur), "Grass")
    {
    }

    public override void BattleCry()
    {
        Console.WriteLine("Bulbasaur!");
    }
}
