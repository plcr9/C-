using System;

namespace LearnReferences
{
  class Program
  {
    static void Main(string[] args)
    {
      Encyclopedia enc1 = new Encyclopedia();
      Encyclopedia enc2 = enc1;
      enc1.CurrentPage = 31;
      enc1.Flip();
      Console.WriteLine(enc1.CurrentPage);
      Console.WriteLine(enc2.CurrentPage);

      Encyclopedia d1 = new Encyclopedia(50);
      Encyclopedia d2 = new Encyclopedia(50);
      Console.WriteLine(d1 == d2);

      Encyclopedia enc = new Encyclopedia(50);
      IFlippable f = enc;
      enc.Flip();
      f.Flip();
      Console.WriteLine(enc.Define());

      Encyclopedia enc3 = new Encyclopedia(19, "Codecademy Curriculum Team", "Codecademy Encyclopedia of Coding Knowledge");
      Book benc3 = enc3;
      Console.WriteLine(enc3.Author);
      Console.WriteLine(benc3.Author);
      Console.WriteLine(enc3.Define());

      IFlippable[] flippers = new IFlippable[] {new Encyclopedia(), new Novel()};
      foreach (IFlippable flipper in flippers)
      {
        flipper.Flip();
      }

      Book benc = new Encyclopedia();
      Book bk = new Book();
      Console.WriteLine(benc.Stringify());
      Console.WriteLine(bk.Stringify());

    }
  }
}

