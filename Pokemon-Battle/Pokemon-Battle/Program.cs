//1.The player start the game.
//2. The player gives a name to a charmander.
//3. The charmander does its battle cry for ten times.
//4. The player can give a new name to the same charmander.
//5. The charmander does its battle cry for ten times.
//6. Repeat 4 and 5 until the player quits the game.

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


class Trainer
{
    public string name { get; set; }

    // has 6 pokeballs
    public List<Pokeball> pokeballs { get; set; }

}

class Pokeball
{
    public string content { get; set; }

    public void throwPokeball()
    {
        
    }
}