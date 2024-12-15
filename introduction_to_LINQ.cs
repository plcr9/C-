using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      List<string> heroes = new
      List<string> { "Astra", "Zephyr", "Nyx", "Orion", "Nova", "Thorne" };

      List<string> longLoudHeroes = new List<string>();
      
      foreach (string hero in heroes)
      {
        if (hero.Length > 5)
        {
          string formatted = hero.ToUpper();
          longLoudHeroes.Add(formatted);
        }
      }

      var longLoudHeroes2 = from h in heroes
        where h.length > 5
        select h.ToUpper();

      Console.WriteLine("Your long loud heroes are...");

      foreach (string hero in longLoudHeroes2)
      {
        Console.WriteLine(hero);
      }
    }
  }
}

