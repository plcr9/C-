using System;

namespace DefineParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(3);
      VisitPlanets(4);
      VisitPlanets(5);
    }

    static void VisitPlanets(int numberOfPlanets)

    {
      Console.WriteLine($"You visited {numberofPlanets} new planets...");
    }
  }
}
