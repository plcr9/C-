using System;

namespace StringTheException
{
  class Program
  {
    static void Main(string[] args)
    {
      string dates = 
        "January 4th, 2024\n" +
        "March 25th, 2024\n" +
        "July 8th, 2024\n" +
        "December 11th, 2024";

      dates = dates.Replace("th", "");

      Console.WriteLine(dates);
    }
  }
}

