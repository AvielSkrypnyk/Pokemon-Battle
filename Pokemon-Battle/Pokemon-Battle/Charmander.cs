using Pokemon_Battle;

class Charmander : Pokemon
{
    public Charmander() : base(nameof(Charmander), Element.Fire)
    {
    }

    public override void BattleCry()
    {
        Console.WriteLine("Charmander!");
    }
}