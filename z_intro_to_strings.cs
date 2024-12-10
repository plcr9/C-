using System;

namespace StringTheException
{
  class Program
  {
    static voic Main(string[] args)
    {
      string dog = "chihuahua";
      string tinyDog = dog;
      dog = "dalmation";
      Console.WriteLine(dog);
      Console.WriteLine(tinyDog);

      string s1 = "Hello";
      string s2 = s1;
      s1 += "World";
      System.Console.WriteLine(s1);
      System.Console.WriteLine(s2);
    }
  }
}
