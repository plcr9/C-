using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      bool boolValue1 = false;
      bool boolValue2 = boolvalue1;

      boolValue2 = true;

      Console.WriteLine(boolValue1);
      Console.WriteLine(boolValue2);
    }
  }
}
