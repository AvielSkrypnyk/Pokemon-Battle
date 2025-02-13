using Pokemon_Battle;

abstract class Pokemon
{
    private string name { get; set; }
    private string pokemonType { get; set; }
    public string strength { get; set; }
    public string weakness { get; set; }

    public Pokemon(string name, string pokemonType)
    {
        this.name = name;
        this.pokemonType = pokemonType;
        (strength, weakness) = PokemonTypes.GetStrenghtAndWeakness(pokemonType);
    }

    public string getName() { return name; }

    public abstract void battleCry();
}