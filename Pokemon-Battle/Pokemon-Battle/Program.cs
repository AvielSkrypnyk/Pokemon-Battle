class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Pokémon Battle Simulator!");

        Console.Write("Enter the name of Trainer 1: ");
        var trainer1Name = Console.ReadLine() ?? "Trainer 1";
        var trainer1 = new Trainer(trainer1Name);

        Console.Write("Enter the name of Trainer 2: ");
        var trainer2Name = Console.ReadLine() ?? "Trainer 2";
        var trainer2 = new Trainer(trainer2Name);

        var arena = new Arena();
        arena.StartBattle(trainer1, trainer2);

        Console.WriteLine("\nAll Pokeballs have been used! The battle is over.");
        Console.WriteLine("Would you like to restart the game? (yes/no)");

        var restartChoice = Console.ReadLine()?.ToLower() ?? "no";
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