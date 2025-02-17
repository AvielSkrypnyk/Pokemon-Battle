using Pokemon_Battle;

class Squirtle : Pokemon
{
    public Squirtle() : base(nameof(Squirtle), Element.Water)
    {
    }

    public override void BattleCry()
    {
        Console.WriteLine("Squirtle!");
    }
}
