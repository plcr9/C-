using System;

namespace LearnInheritance
{
  class Sedan
  {
    public string LicensePlate
    { get; }

    public double speed
    { get; private set; }

    public int Wheels
    { get; }

    public Sedam(double speed)
    {
      Speed = speed;
      LicensePlate = Tools.GenerateLicensePlate();
      Wheels = 4;
    }

    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

    public void SpeedUp()
    {
      Speed += 5;
    }

    public void SlowDown()
    {
      Speed -= 5;
    }

  }
}

