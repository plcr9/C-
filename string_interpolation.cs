using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      string beginning = "Once upon a time,";
      string middle = "The kid climbed a tree";
      string end = "Everyone lived happily ever after.";

      string story = ${beginning} it was a beautiful day. {middle} and the birds flew through the sky. {end}";

      Console.WriteLine(story);
    }
  }
}
