using System;

namespace PolymorphismBasics
{
  abstract class Employee
  {
    public abstract void MakeHRRequest();

    public void ClockIn()
    {
      Console.WriteLine("Employee clocks in.");
    }
  }

  class Engineer : Employee
  {
    public override void MakeHRRequest()
    {
      Console.WriteLine("Engineer makes an HR Request.");
    }

    public void Promotion()
    {
      Console.WriteLine("Engineer gets a promotion.");
    }

    public void SubmitPR()
    {
      Console.WriteLine("Engineer submits a pull request.");
    }
  }
}
