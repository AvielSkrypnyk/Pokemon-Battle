class Trainer
{
    public string Name { get; set; }
    public List<Pokeball> Belt { get; set; }

    public Trainer(string name)
    {
        Name = name;
        Belt = new List<Pokeball>();

        for (int i = 0; i < 6; i++)
        {
            Belt.Add(new Pokeball((i % 3) switch
            {
                0 => new Charmander(),
                1 => new Squirtle(),
                2 => new Bulbasaur(),
                _ => throw new InvalidOperationException("Invalid Pokemon selection.")
            }));
        }
    }

    public void AddPokeball(Pokeball pokeball)
    {
        if (Belt.Count >= 6)
        {
            throw new InvalidOperationException("A trainer can only have six Pokeballs.");
        }
        Belt.Add(pokeball);
    }

    public void ThrowPokeball(int index)
    {
        if (index < 0 || index >= Belt.Count)
        {
            Console.WriteLine("Invalid Pokeball selection.");
            return;
        }

        Belt[index].ThrowPokeball();
    }

    public void ReturnPokemon(int index)
    {
        if (index < 0 || index >= Belt.Count)
        {
            Console.WriteLine("Invalid Pokeball selection.");
            return;
        }

        Belt[index].ReturnPokemon();
    }
}
