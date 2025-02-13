class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Pokémon Battle Simulator!");

        Console.Write("Enter the name of Trainer 1: ");
        string trainer1Name = Console.ReadLine() ?? "Trainer 1";
        Trainer trainer1 = new Trainer(trainer1Name);

        Console.Write("Enter the name of Trainer 2: ");
        string trainer2Name = Console.ReadLine() ?? "Trainer 2";
        Trainer trainer2 = new Trainer(trainer2Name);

        int turn = 0;
        while (turn < 6)
        {
            // Step 4 & 5:
            Console.WriteLine($"\n{trainer1.Name} throws a Pokeball!");
            trainer1.ThrowPokeball(turn);

            // Step 6 & 7:
            Console.WriteLine($"\n{trainer2.Name} throws a Pokeball!");
            trainer2.ThrowPokeball(turn);

            // Step 8:
            Console.WriteLine($"\n{trainer1.Name} returns the Pokémon to its Pokeball.");
            trainer1.ReturnPokemon(turn);

            // Step 9:
            Console.WriteLine($"\n{trainer2.Name} returns the Pokémon to its Pokeball.");
            trainer2.ReturnPokemon(turn);

            turn++;
        }

        Console.WriteLine("\nAll Pokeballs have been used! The battle is over.");
        Console.WriteLine("Would you like to restart the game? (yes/no)");

        string restartChoice = Console.ReadLine()?.ToLower() ?? "no";
        if (restartChoice == "yes")
        {
            Console.Clear();
            Main(); // Restart the game
        }
        else
        {
            Console.WriteLine("Thanks for playing!");
        }
    }
}