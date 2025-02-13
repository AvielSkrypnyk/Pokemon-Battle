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
                case "Water":
                    return ("Water", "Grass");
                case "Grass":
                    return ("Grass", "Fire");
                default:
                    Console.WriteLine("Invalid pokemon type");
                    return ("Unknown", "Unknown");
            }
        }
    }
}
