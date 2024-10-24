using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest amazon = new Forest("Amazon");
      Console.WriteLine(amazon.trees);

      amazon.Grow();
      Console.WriteLine(amazon.trees);
    }
  }
}
