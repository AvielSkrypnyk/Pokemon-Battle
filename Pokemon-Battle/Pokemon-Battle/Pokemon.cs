using Pokemon_Battle;

abstract class Pokemon
{
    public string Name { get; init;  }
    private string PokemonType { get; init; }
    public string Strength { get; init; }
    public string Weakness { get; init; }
    public bool Fainted { get; set; }
    public Pokemon(string name, string pokemonType)
    {
        this.Name = name;
        this.PokemonType = pokemonType;
        (Strength, Weakness) = PokemonTypes.GetStrenghtAndWeakness(pokemonType);
    }

    public abstract void BattleCry();
}