//1.The player start the game.
//2. The player gives a name to a charmander.
//3. The charmander does its battle cry for ten times.
//4. The player can give a new name to the same charmander.
//5. The charmander does its battle cry for ten times.
//6. Repeat 4 and 5 until the player quits the game.


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