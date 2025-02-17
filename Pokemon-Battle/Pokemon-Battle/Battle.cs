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
