using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Session
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Gowtham","K");
            //Customer customer = new Customer();
            customer.PrintName();

            //Arthimetic arthimetic = new Arthimetic(2, 3);
            //Arthimetic arthimetic1 = new Arthimetic(2, 10);
            //Arthimetic arthimetic2 = new Arthimetic(2, 15);
            //Arthimetic arthimetic = new Arthimetic( 3);
            //int result = arthimetic.Add();
            //int result1 = arthimetic.Add();
            //int result2 = arthimetic.Add();
            //Console.WriteLine($"Addition = {result}");
            //Console.WriteLine($"Addition = {result1}");
            //Console.WriteLine($"Addition = {result2}");

            //---------------------------//

            // Inheritance
            //1.  Multiple inheritance is not possible 
            //2.  It supports multilevel
            //3. Base class intialized before Derived class 
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            //fullTimeEmployee.FirstName = "Gowtham";
            //fullTimeEmployee.LastName = "K";
            //fullTimeEmployee.YealySalary = 10000;
            //fullTimeEmployee.PrintFullName();

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            //partTimeEmployee.FirstName = "Gowtham";
            //partTimeEmployee.LastName = "K";
            //partTimeEmployee.HourlyRate = 100;
            //partTimeEmployee.PrintFullName();

            //SubEmployee subEmployee = new SubEmployee();
            //subEmployee.FirstName = "Gowtham";
            //subEmployee.LastName = "K";
            //subEmployee.PrintFullName();

            //----------------------------------//

            //----------------------------------//

            //Polymorphism 
            //Employee[] employees = new Employee[3]; 
            //employees[0] = new Employee();
            //employees[1]=new PartTimeEmployee(); //base class reference vaiable can point to a child class object
            //employees[2] = new FullTimeEmployee();
            //foreach(Employee e in employees)
            //{
            //    e.PrintFullName();
            //}


            //Interface 

            //RegularCustomer regularCustomer = new RegularCustomer();
            ////regularCustomer.Print();
            ////regularCustomer.TemporaryCustomer();
            ////ICustomerInherit customerInherit = new RegularCustomer();

            //regularCustomer.Print();
            //regularCustomer.PrintTemp();


            // Abstract Classess 

            NousFullTimeEmployee nousFullTimeEmployee = new NousFullTimeEmployee();
            nousFullTimeEmployee.FirstName = "Arun";
            nousFullTimeEmployee.LastName = "Raj";
            nousFullTimeEmployee.AnnualSalary = 100000;
            string  name= nousFullTimeEmployee.GetFullName();
             int salary = nousFullTimeEmployee.GetMonthlySalary();
            Console.WriteLine($"Full Time Employee.....");
            Console.WriteLine($"Name ={name}");
            Console.WriteLine( $"Salary={salary}");
            Console.WriteLine("--------------------------");
            NousPartTimeEmployee nousPartTime = new NousPartTimeEmployee();
            nousPartTime.FirstName = "Kapil";
            nousPartTime.LastName = "Sharma";
            nousPartTime.HourlyPay = 50;
            nousPartTime.TotalHourWorked = 40;

            string name1 = nousPartTime.GetFullName();
            int salary1 = nousPartTime.GetMonthlySalary();

            Console.WriteLine($"Part Time Employee.....");
            Console.WriteLine($"Name ={name1}");
            Console.WriteLine($"Salary={salary1}");
            Console.WriteLine("--------------------------");






            Console.ReadKey();
        }
    }
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Parameteless Contructor 
        /// </summary>
        //public Customer()
        //{
        //    this.FirstName = "Gowtham";
        //    this.LastName = "K";
        //}

        //public Customer() : this("Gowtham", "K")
        //{

        //}
        /// <summary>
        /// Parametrized Constructor - It Will not have return Type 
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        public Customer(string firstName, string lastName) // intialize the class field 
        {
            this.FirstName = firstName;
            this.LastName = lastName;

        }
        /// <summary>
        /// 
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine($"Full Name = {FirstName},  {LastName}");
        }


        /// <summary>
        /// Destructor - Clean up the resources - doesn't have paramater 
        /// </summary>
        ~Customer()// clean up the resources 
        {

        }

    }
}
