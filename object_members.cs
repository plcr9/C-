using System;

namespace TheObjectClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Book b = new Book();
      Novel n = new Novel(38);
      Random r = new Random();
      int i = 9;

      Object[] objects = { b, n, r, i };

      foreach (Object obj in objects)
      {
        Console.WriteLine(obj.GetType());
      }
    }
  }
}
