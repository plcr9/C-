using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      string beginning = "Once upon a time";
      string middle = "the kid climbed a tree";
      string end = "Everyone lived happily ever after";

      string story = beginning + ", " + middle + ". " + end ".";

      Console.WriteLine(story);
    }
  }
}
