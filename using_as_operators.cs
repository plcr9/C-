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

  public class Engineer : Engineer
  {
    public override void MakeHRRequest()
    {
      Console.WriteLine("Engineer makes and HR request.");
    }

    public void SubmitPR()
    {
      Console.WriteLine("Engineer submits a pull request.");
    }
  }

  public class Manager : Employee
  {
    public override void MakeHRRequest()
    {
      Console.WriteLine("Manager makes an HR request.");
    }

    public void MoveToOffice()
    {
      Console.WriteLine("Manager moves to office.");
    }
  }

  public class Program
  {
    public static void Main(string[] args)
    {
      Employee myEmployeeEngineer1 = new Engineer();
      Employee myEmployeeEngineer2 = new Engineer();
      Engineer engineer = myEmployeeEngineer1 as Engineer;
      Console.WriteLine(engineer == null);
      Manager manager = myEmployeeEngineer2 as Manager;
      Console.WriteLine(manager == null);
    }
  }
}

  
      
