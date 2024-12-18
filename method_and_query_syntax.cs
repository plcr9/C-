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

      var queryResult = from x in heroes
                        where x.Contains("a")
                        select $"{x} contains an 'a'";

      var methodResult = heroes
        .Where(x => x.Contains("a"))
        .Select(x => $"{x} contains an 'a'");

      Console.WriteLine("queryResult:");
      foreach (string s in queryResult)
      {
        Console.WriteLine(s);
      }

      Console.WriteLine("\methodResult:");
      foreach (string s in methodResult)
      {
        Console.WriteLine(s);
      }
    }
  }
}
      

      

      
