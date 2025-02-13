class Bulbasaur : Pokemon
{
    public Bulbasaur() : base("Bulbasaur", "Grass")
    {
    }

    public override void battleCry()
    {
        Console.WriteLine("Bulbasaur!");
    }
}
