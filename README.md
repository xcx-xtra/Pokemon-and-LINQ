Pokemon LINQ Lab

Overview

This project demonstrates how to use LINQ (Language-Integrated Query) in C# to filter and sort a collection of Pokemon objects. The program identifies Pokemon that are ready to evolve based on their level.

Features

Defines a Pokemon class with attributes: Id, Name, Type, and Level.

Initializes a list of Pokemon with predefined data.

Uses a LINQ query to filter Pokemon with Level >= 16.

Sorts the filtered Pokemon in ascending order by level.

Displays the filtered Pokemon in the console.

Technologies Used

C#

.NET Framework

LINQ

How to Run

Ensure you have a C# compiler installed (e.g., .NET SDK).

Copy the PokemonLINQLab class into a new C# file (e.g., Program.cs).

Compile and run the program using:

dotnet run

The console will display a list of Pokemon that are ready to evolve.

Example Output

Pokemon ready to evolve:
Name: Pikachu, Type: Electric, Level: 15
Name: Psyduck, Type: Water, Level: 18
Name: Charmander, Type: Fire, Level: 23
Name: Snorlax, Type: Normal, Level: 30
Name: Bulbasaur, Type: Grass, Level: 34
Name: Mew, Type: Psychic, Level: 41
Name: Mewtwo, Type: Psychic, Level: 50

Possible Enhancements

Add more Pokemon with different levels and types.

Implement additional LINQ queries to filter by type or find the highest-level Pokemon.

Create a function to determine the exact evolution level of each Pokemon.

Extend the program to allow user input for custom queries.

Author

Webster Boeing
