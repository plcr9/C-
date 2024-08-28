using System;

namespace PlanetCalculations
{
  class Program
  {
    static void Main(string[] args)
    {
      int userAge = 30;

      double jupiterYears = 11.86;

      double jupiterAge = userAge/jupiterYears;

      double journeyToJupiter = 6.142466;

      double newEarthAge = userAge + journeyToJupiter;

      double newJupiterAge = newEarthAge/jupiterYears;

      Console.WriteLine(jupiterAge);
      Console.WriteLine(newEarthAge);
      Console.WriteLine(newJupiterAge);
    }
  }
}
