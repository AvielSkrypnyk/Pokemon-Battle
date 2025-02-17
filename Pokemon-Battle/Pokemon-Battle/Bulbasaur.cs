using Pokemon_Battle;

class Bulbasaur : Pokemon
{
    public Bulbasaur() : base(nameof(Bulbasaur), Element.Grass)
    {
    }

    public override void BattleCry()
    {
        Console.WriteLine("Bulbasaur!");
    }
}
