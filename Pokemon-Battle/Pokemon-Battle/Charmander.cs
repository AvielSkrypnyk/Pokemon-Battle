class Charmander : Pokemon
{
    public Charmander() : base("Charmander", "Fire")
    {
    }

    public override void battleCry()
    {
        Console.WriteLine("Charmander!");
    }
}