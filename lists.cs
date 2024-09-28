using System;
using System.Collection.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<string> citiesList = new
      List<string> { "Delhi", "Los Angeles", "Canberra" };

      citiesList.Add("Naples");

      citiesList.Remove("Delhi");

      citiesList.AddRange(new string[] {"Cairo", "Pretoria"});

      bool hasNewDelhi = citiesList.Contains("New Delhi");

      foreach (string city in citiesList)
      {
        Console.WriteLine(city);
      }
    }
  }
}
