//1.The player start the game.
//2. The player gives a name to a charmander.
//3. The charmander does its battle cry for ten times.
//4. The player can give a new name to the same charmander.
//5. The charmander does its battle cry for ten times.
//6. Repeat 4 and 5 until the player quits the game.


using Pokemon_Battle;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your pokemon name:");
        string name = Console.ReadLine() ?? throw new NullReferenceException();

        Pokemon charmender = new Pokemon(name, "Fire");

        bool playing = true;
        while (playing)
        {
            charmender.battleCry();

            Console.WriteLine("Do you want to rename Pokemon? (yes/no)");
            string answer = Console.ReadLine() ?? throw new NullReferenceException();

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("Enter new name for you pokemon: ");
                string newName = Console.ReadLine() ?? throw new NullReferenceException();
                charmender.SetName(newName);
            }
            else if (answer.ToLower() == "no")
            {
                playing = false;
            }

        }
        Console.WriteLine("END OF THE GAME");
    }
}

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