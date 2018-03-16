using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Session
{
    class AbstractClass_Demo
    {
    }
   abstract class NousEmployee
        {
        public int EmployeeID { get; set; }
        public  string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + ", " + LastName;
        }
        //public virtual int GetMonthlySalary()
        //{
        //    throw new NotImplementedException();
        //}
        public abstract int GetMonthlySalary();
       
    }

    class NousFullTimeEmployee:NousEmployee
    {
        public int AnnualSalary { get; set; }
        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }

    }

    class NousPartTimeEmployee : NousEmployee
    {
        public int HourlyPay { get; set; }
        public int TotalHourWorked { get; set; }

        public override int GetMonthlySalary()
        {
            return this.HourlyPay * this.TotalHourWorked;
        }

    }
}
