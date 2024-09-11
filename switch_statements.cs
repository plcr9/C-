using System;

namespace SwitchStatement
{
  class Program
  {
    static void Main(string[] args)
    {
      double ph = 14;

      switch(ph) {
        case <= 3:
          Console.WriteLine("Very Acidic");
          break;
        case < 7:
          Console.WriteLine("Acidic");
          break;
        case >= 11:
          Console.WriteLine("Very Basic");
          break;
        default:
          Console.WriteLine("Neutral");
          break;
      }
    }
  }
}
