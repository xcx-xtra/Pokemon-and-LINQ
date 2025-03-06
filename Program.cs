// Using directives - these import existing code from the .NET framework
using System;
using System.Collections.Generic;
using System.Linq;

// Create a new Pokemon class (this is a blueprint for an object)
class Pokemon
{
    // Declare the attributes of the Pokemon class (Properties with getters and setters)
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Level { get; set; }
} // end class

// This class contains the main method (the entry point of the program)
class PokemonLINQLab 
{
    static void Main() 
    {
        // Sample data: list of Pokemon (Collection of objects we will query)
        var pokemons = new List<Pokemon>
        {
            new Pokemon { Id = 1, Name = "Pikachu", Type = "Electric", Level = 15 },
            new Pokemon { Id = 2, Name = "Charmander", Type = "Fire", Level = 23 },
            new Pokemon { Id = 3, Name = "Squirtle", Type = "Water", Level = 5 },
            new Pokemon { Id = 4, Name = "Bulbasaur", Type = "Grass", Level = 34 },
            new Pokemon { Id = 5, Name = "Jigglypuff", Type = "Normal", Level = 12 },
            new Pokemon { Id = 6, Name = "Meowth", Type = "Normal", Level = 8 },
            new Pokemon { Id = 7, Name = "Psyduck", Type = "Water", Level = 18 },
            new Pokemon { Id = 8, Name = "Snorlax", Type = "Normal", Level = 30 },
            new Pokemon { Id = 9, Name = "Mewtwo", Type = "Psychic", Level = 50 },
            new Pokemon { Id = 10, Name = "Mew", Type = "Psychic", Level = 41 }
        };

        // LINQ Query to find the Pokemon ready to evolve (Level 16 or higher)
        IEnumerable<Pokemon> readyToEvolveQuery = from p in pokemons
                                                  where p.Level >= 16
                                                  orderby p.Level
                                                  select p;

        // Display the results
        Console.WriteLine("Pokemon ready to evolve:");

        // Loop through the result set and display each Pokemon
        foreach (var pokemon in readyToEvolveQuery)
        {
            Console.WriteLine($"Name: {pokemon.Name}, Type: {pokemon.Type}, Level: {pokemon.Level}");
        } // end for each loop
    } // end main method
}
