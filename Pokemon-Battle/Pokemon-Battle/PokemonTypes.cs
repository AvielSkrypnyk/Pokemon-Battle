namespace Pokemon_Battle
{
    internal class PokemonTypes
    {
        public static (string strength, string weakness) GetStrenghtAndWeakness(string pokemonType)
        {
            switch (pokemonType)
            {
                case "Fire":
                    return ("Fire", "Water");
                default:
                    Console.WriteLine("Invalid pokemon type");
                    return ("Unknown", "Unknown");
            }
        }
    }
}
