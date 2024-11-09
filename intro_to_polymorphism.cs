using System;

namespace PolymorphismBasics
{
  class Animal
  {
    public virtual void MakeSound()
    {
      Console.WriteLine("Animal makes a sound.");
    }
  }

  class Dog : Animal
  {
    public override void MakeSound()
    {
      Console.WriteLine("Dog barks.");
    }
  }

  public class Program
  {
    static void Main(string[] args)
    {
      Animal myDog = new Dog();
      Animal myCat = new Cat();

      myDog.MakeSound();
      myCat.MakeSound();
    }
  }
}

