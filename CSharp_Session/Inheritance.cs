using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate bool Emp_Delegate(CSharp_Session.Employee employee);

namespace CSharp_Session
{
    class Inheritance
    {
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Expereince { get; set; }
        public  static void PromoteEmployee(List<Employee> employees, Emp_Delegate isEligible)
        {
            foreach(Employee emp in employees)
            {
                if(isEligible(emp))
                {
                    Console.WriteLine( $"Employee Name: { emp.FirstName}, { emp.LastName}" +" Promoted ");
                }
            }

        }
        //public Employee ()
        //{
        //    Console.WriteLine("Base class");
        //}
        //public Employee(string Message)
        //{
        //    Console.WriteLine($"Base parameterize constructor Saying...{Message}");
        //}
        //public void PrintFullName()
        //{
        //    Console.WriteLine($"Name = {FirstName} {LastName}"); 
        //}
        public virtual void PrintFullName()
        {
            Console.WriteLine($"Name = {FirstName} {LastName}");
        }
    }

    public class FullTimeEmployee : Employee
    {
        //public FullTimeEmployee():base("Hello")
        //{
        //    Console.WriteLine("Child class");
        //}
        

        public float YealySalary { get; set; }

        //public void PrintFullName()
        //{
        //    Console.WriteLine($"Name = {FirstName} {LastName} - FullTime");
        //}
        //public new void PrintFullName()
        //{
        //    Console.WriteLine($"Name = {FirstName} {LastName} - FullTime");
        //}
        public override void PrintFullName()
        {
            Console.WriteLine($"Name = {FirstName} {LastName} - FullTime");
        }
    }


    public class PartTimeEmployee : Employee
    {
    public float HourlyRate { get; set; }
        //public void PrintFullName()
        //{
        //    Console.WriteLine($"Name = {FirstName} {LastName} - PartTime");
        //}
        //public new void PrintFullName()
        //{
        //    Console.WriteLine($"Name = {FirstName} {LastName} - PartTime");
        //}
        public override void PrintFullName()
        {
            Console.WriteLine($"Name = {FirstName} {LastName} - PartTime");
        }
    }

    public class SubEmployee:FullTimeEmployee
    {
        
    }
}
