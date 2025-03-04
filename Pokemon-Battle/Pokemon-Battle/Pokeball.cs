﻿namespace Pokemon_Battle;

sealed class Pokeball(Pokemon pokemon)
{
    public readonly Pokemon pokemon = pokemon;
    private bool _isOpen;

    public void OpenPokeball()
    {
        if (pokemon == null)
        {
            Console.WriteLine("The Pokeball is empty!");
            return;
        }

        if (!_isOpen)
        {
            Console.WriteLine($"The Pokeball opens, and {pokemon.Name} comes out!");
            pokemon.BattleCry();
            _isOpen = true;
        }
        else
        {
            Console.WriteLine("The Pokeball is already open.");
        }
    }

    public void ClosePokeball()
    {
        if (pokemon == null)
        {
            Console.WriteLine("There is no Pokémon in the Pokeball.");
            return;
        }

        if (_isOpen)
        {
            Console.WriteLine($"{pokemon.Name} returns to the Pokeball.");
            _isOpen = false;
        }
        else
        {
            Console.WriteLine("The Pokeball is already closed.");
        }
    }
}
