using System;

namespace LearnInterfaces
{
  class Sedan : IAutomobile
  {
    public string LicensePlate
    { get; }

    public double speed
    { get; }

    public int Wheels
    { get; }

    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

  }
}
