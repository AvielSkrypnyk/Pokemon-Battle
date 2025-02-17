namespace Pokemon_Battle
{
    internal class PokemonTypes
    {
        public static (Element strength, Element weakness) GetStrenghtAndWeakness(Element element)
        {
            return element switch
            {
                Element.Fire => (Element.Fire, Element.Water),
                Element.Water => (Element.Water, Element.Grass),
                Element.Grass => (Element.Grass, Element.Fire),
                _ => throw new ArgumentException("Invalid element"),
            };
        }
    }
}
