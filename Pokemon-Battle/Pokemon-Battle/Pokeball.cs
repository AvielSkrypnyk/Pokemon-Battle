class Pokeball
{
    private Pokemon? pokemon; // Can be null (empty Pokeball)
    private bool isOpen;

    public Pokeball(Pokemon pokemon)
    {
        this.pokemon = pokemon;
        this.isOpen = false;
    }

    public void ThrowPokeball()
    {
        if (pokemon == null)
        {
            Console.WriteLine("The Pokeball is empty!");
            return;
        }

        if (!isOpen)
        {
            Console.WriteLine($"The Pokeball opens, and {pokemon.getName()} comes out!");
            pokemon.battleCry();
            isOpen = true;
        }
        else
        {
            Console.WriteLine("The Pokeball is already open.");
        }
    }

    public void ReturnPokemon()
    {
        if (pokemon == null)
        {
            Console.WriteLine("There is no Pokémon in the Pokeball.");
            return;
        }

        if (isOpen)
        {
            Console.WriteLine($"{pokemon.getName()} returns to the Pokeball.");
            isOpen = false;
        }
        else
        {
            Console.WriteLine("The Pokeball is already closed.");
        }
    }
}
