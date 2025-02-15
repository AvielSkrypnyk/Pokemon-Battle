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


class Battle(Trainer trainer1, Trainer trainer2)
{
    private readonly Trainer _trainer1 = trainer1;
    private readonly Trainer _trainer2 = trainer2;

    private int? previousResult = null;

    public void Start()
    {
        Console.WriteLine("\n========== The Battle Begins! ==========\n");

        while (_trainer1.HasAvailablePokemon() && _trainer2.HasAvailablePokemon())
        {
            var trainer1Pokemon = _trainer1.GetRandomPokeballl().pokemon;
            var trainer2Pokemon = _trainer2.GetRandomPokeballl().pokemon;

            Arena.IncrementRound();

            int result = Fight(trainer1Pokemon, trainer2Pokemon);

            if (result == 1)
            {
                trainer2Pokemon.Fainted = true;
                Console.WriteLine($"{trainer1Pokemon.Name} wins against {trainer2Pokemon.Name}!");
            }
            else if (result == 2)
            {
                trainer1Pokemon.Fainted = true;
                Console.WriteLine($"{trainer2Pokemon.Name} wins against {trainer1Pokemon.Name}!");
            }
            else
            {
                Console.WriteLine($"{trainer1Pokemon.Name} and {trainer2Pokemon.Name} draw!");
                switch(previousResult)
                {
                    case 1:
                        trainer2Pokemon.Fainted = true;
                        break;
                    case 2:
                        trainer1Pokemon.Fainted = true;
                        break;
                    default:
                        trainer1Pokemon.Fainted = true;
                        trainer2Pokemon.Fainted = true;
                        break;
                }
            }
            previousResult = result;
        }
        var trainer1HasAvailable = _trainer1.HasAvailablePokemon();
        var trainer2HasAvailable = _trainer2.HasAvailablePokemon();
        if(trainer1HasAvailable && trainer2HasAvailable)
        {
            Console.WriteLine("The battle ends in a draw!");
        }
        else if (trainer1HasAvailable)
        {
            Console.WriteLine($"{_trainer1.Name} wins the battle!");
        }
        else
        {
            Console.WriteLine($"{_trainer2.Name} wins the battle!");
        }
    }


    private int Fight(Pokemon pokemon1, Pokemon pokemon2)
    {
        if (pokemon1.Strength == pokemon2.Weakness)
        {
            return 1; // Trainer 1's Pokemon wins
        }
        else if (pokemon2.Strength == pokemon1.Weakness)
        {
            return 2; // Trainer 2's Pokemon wins
        }
        else
        {
            return 0; // Draw
        }
    }
}

class Arena
{
    private static int _totalRounds = 0;
    private static int _totalBattles = 0;

    public void StartBattle(Trainer trainer1, Trainer trainer2)
    {
        new Battle(trainer1, trainer2).Start();
        _totalBattles++;
        DisplayScore();
    }

    public static void IncrementRound()
    {
        _totalRounds++;
    }

    public static void DisplayScore()
    {
        Console.WriteLine($"Total Battles: {_totalBattles}, Total Rounds: {_totalRounds}");
    }
}