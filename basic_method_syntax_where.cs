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

      var heroesWithI = heroes.Where(h => h.Contains("i"));

      foreach (var hero in heroeswithI)
      {
        Console.WriteLine(hero);
      }
    }
  }
}

