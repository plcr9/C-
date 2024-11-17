using System;

namespace PolymorphismBasics
{
  public class Employee
  {
    public virtual void MakeHRRequest()
    {
      Console.WriteLine("Employee makes an HR request.");
    }
  }

  public class Engineer : Employee
  {
    public override void MakeHRRequest()
    {
      Console.WriteLine("Engineer makes an HR request.");
    }
  }

  public class Manager : Employee
  {
    public override void MakeHRRequest()
    {
      Console.WriteLine("Manager makes an HR request.");
    }
  }

  public class Program
  {
    public static void Main(string[] args)
    {
      Manager myManager = new Manager();
      Employee myEmployeeManager = myManager;
      myEmployeeManager.MakeHRRequest();
    }
  }
}
