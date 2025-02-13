using Pokemon_Battle;

class Pokemon
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

    public string getName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void battleCry()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(name);
        }
    }
}