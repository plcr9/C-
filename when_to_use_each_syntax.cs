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

      var result = heroes.select(h => $"Introducing...{h}!");

      var result2 = from h in heroes
        where h.Contains("i")
        select h.IndexOf("i")

      Console.WriteLine("'result': ");
      foreach (var v in result)
      {
        Console.WriteLine(v);
      }

      Console.WriteLine("\n'result2': ");
      foreach (var v in result2)
      {
        Console.WriteLine(v);
      }
    }
  }
}

      
