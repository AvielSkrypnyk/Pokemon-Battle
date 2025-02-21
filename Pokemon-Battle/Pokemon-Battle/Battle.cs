namespace Pokemon_Battle;

internal partial class Battle(Trainer trainer1, Trainer trainer2)
{
    private WinTrainer? _previousResult;

    public void Start()
    {
        Console.WriteLine("\n========== The Battle Begins! ==========\n");

        while (trainer1.HasAvailablePokemon() && trainer2.HasAvailablePokemon())
        {
            var trainer1Pokeball = trainer1.GetRandomPokeballl();
            var trainer2Pokeball = trainer2.GetRandomPokeballl();

            trainer1Pokeball.OpenPokeball();
            trainer2Pokeball.OpenPokeball();

            var trainer1Pokemon = trainer1Pokeball.pokemon;
            var trainer2Pokemon = trainer2Pokeball.pokemon;
s
            Arena.IncrementRound();

            WinTrainer result = Fight(trainer1Pokemon, trainer2Pokemon);

            if (result == WinTrainer.WinTrainer1)
            {
                trainer2Pokemon.Fainted = true;
                Console.WriteLine($"{trainer1Pokemon.Name} wins against {trainer2Pokemon.Name}!");
            }
            else if (result == WinTrainer.WinTrainer2)
            {
                trainer1Pokemon.Fainted = true;
                Console.WriteLine($"{trainer2Pokemon.Name} wins against {trainer1Pokemon.Name}!");
            }
            else
            {
                Console.WriteLine($"{trainer1Pokemon.Name} and {trainer2Pokemon.Name} draw!");
                switch (_previousResult)
                {
                    case WinTrainer.WinTrainer1: // trainer 1 win
                        trainer2Pokemon.Fainted = true;
                        break;
                    case WinTrainer.WinTrainer2: // trainer 2 win
                        trainer1Pokemon.Fainted = true;
                        break;
                    default:
                        trainer1Pokemon.Fainted = true;
                        trainer2Pokemon.Fainted = true;
                        break;
                }
            }

            trainer1Pokeball.ClosePokeball();
            trainer2Pokeball.ClosePokeball();

            _previousResult = result;
        }

        var trainer1HasAvailable = trainer1.HasAvailablePokemon();
        var trainer2HasAvailable = trainer2.HasAvailablePokemon();
        switch (trainer1HasAvailable)
        {
            case true when trainer2HasAvailable:
                Console.WriteLine("The battle ends in a draw!");
                break;
            case true:
                Console.WriteLine($"{trainer1.Name} wins the battle!");
                break;
            default:
                Console.WriteLine($"{trainer2.Name} wins the battle!");
                break;
        }
    }

    private static WinTrainer Fight(Pokemon pokemon1, Pokemon pokemon2)
    {
        if (pokemon1.Strength == pokemon2.Weakness)
        {
            return WinTrainer.WinTrainer1; // Trainer 1's Pokémon wins
        }
        return pokemon2.Strength == pokemon1.Weakness ? WinTrainer.WinTrainer2 : // Trainer 2's Pokémon wins
            WinTrainer.Draw; // Draw
    }
}