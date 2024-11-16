using System;

namespace PolymrphismBasics
{
  public class Employee
  {
    public void MakeHRRequest()
    {
      Condole.WriteLine("Employee makes an HR request.");
    }
  }

  public class Manager : Employee
  {
    public void MakeHRRequest()
    {
      Console.WriteLine("Manager makes an HR request.");
    }
  }

  public class Engineer : Employee
  {

  }

  public class Program
  {
    public static void Main(string[] args)
    {
      Manager manager1 = new Manager();
      manager1.MakeHRRequest();

    }
  }
}

      
