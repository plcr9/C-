using System;

namespace StringTheException
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter some input please: ");
      string input = Console.ReadLine();

      if (String.IsNullOrEmpty(input))
      {
        Console.WriteLine("You didn't enter anything!");
      }
      else
      {
        Console.WriteLine("Thank you for your submission!");
      }
    }
  }
}
