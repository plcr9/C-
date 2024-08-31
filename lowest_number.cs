using System;

namespace LowestNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      int numberOne = 12932;
      int numberTwo = -2828472;

      double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

      double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

      Console.WriteLine(Math.Min(numberTwoSqrt, numberOneSqrt));

    }
  }
}
