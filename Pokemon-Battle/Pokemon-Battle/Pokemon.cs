namespace Pokemon_Battle;

abstract class Pokemon
{
    public string Name { get; }
    private Element PokemonType { get; init; }
    public Element Strength { get; init; }
    public Element Weakness { get; init; }
    public bool Fainted { get; set; }
    public Pokemon(string name, Element pokemonType)
    {
        this.Name = name;
        this.PokemonType = pokemonType;
        (Strength, Weakness) = PokemonTypes.GetStrenghtAndWeakness(pokemonType);
    }

    public abstract void BattleCry();
}