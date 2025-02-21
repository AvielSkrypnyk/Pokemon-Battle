namespace Pokemon_Battle;
internal class Bulbasaur() : Pokemon(nameof(Bulbasaur), Element.Grass)
{
    public override void BattleCry()
    {
        Console.WriteLine("Bulbasaur!");
    }
}
