using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Encyclopedia enc = new Encyclopedia();
      IFlippable fEnc = enc;
      Book bEnc = enc;
      fEnc.CurrentPage = 42;
      bEnc.Stringify();
      Console.WriteLine(fEnc == bEnc);
    }
  }
}
    
