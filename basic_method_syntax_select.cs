using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      string[] heroes = { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };

      var heroesWithR = heroes.Where(h => h.Contains("r"));
      var lowerHeroesWithR = heroesWithR.Select(h => h.ToLower());

      var sameResult = heroes
        .Select(h => h.ToLower())
        .Where(h => h.Contains("r"));

      foreach (var hero in sameResult)
      {
        Console.WriteLine(hero);
      }
    }
  }
}

