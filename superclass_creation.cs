using System;

namespace LearnInheritance
{
  class Vehicle
  {
    public string LicensePlate
    { get; }

    public double Speed
    { get; private set; }

    public int Wheels
    { get; }

    public void SpeedUp()
    {
      Speed += 5;
    }

    public void SlowDown()
    {
      Speed -= 5;
    }

    public void Honk()
    {
      Console.WriteLine("HONK!");
    }
  }
}
