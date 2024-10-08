using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<string> citiesList = new
      List<string> { "Paris", "Dubai", "Darwin" };

      citiesList.Add("San Francisco");

      foreach (string city in citiesList)
      {
        Console.WriteLine($"Welcome to...{city}!");
      }
    }
  }
}
