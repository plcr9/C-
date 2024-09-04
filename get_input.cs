using System;

namespace GettingInput
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("How old are you?");
      string input = Console.Readline();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}
