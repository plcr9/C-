using System;

namespace PolymorphismBasics
{
  public abstract class Employee
  {
    public abstract void MakeHRRequest();

    public void Promotion()
    {
      Console.WriteLine("Employee gets a promotion.");
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
      Manager manager = new Manager();
      manager.MakeHRRequest();
      manager.Promotion();
    }
  }
}

  
