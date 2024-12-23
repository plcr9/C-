using System;
using System.Collections.Generic;
using System.Linq;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      List<string> heroesList = new List<string> { "Zoe", "Liam", "Taryn", "Dorian", "Everett", "Marlena" };

      var heroesWithSpecialChars = heroesList.Where(h => h.Contains('v') || h.Contains('y');

      foreach (var v in heroesWithSpecialChars)
      {
        Console.WriteLine(v);
      }
    }
  }
}
