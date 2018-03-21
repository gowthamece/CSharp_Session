using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void Hello_function_Deleagte(string Message);



namespace CSharp_Session
{
   

    class Program
    {
        public const Decimal CTM = 10.32M; // Complile time const
        public  readonly Decimal PI ; // Runt time const

        int? i=null;    
        public Program()
        {
            PI = 3.14M;
            int j = i ?? 0;
        }
        public static void Hello(string message)
        {
           
            
            Console.WriteLine(message);

        }
        static void Main(string[] args)
        {
            Customer customer = new Customer("Gowtham","K");
            //Customer customer = new Customer();
           // customer.PrintName();

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

            //NousFullTimeEmployee nousFullTimeEmployee = new NousFullTimeEmployee();
            //nousFullTimeEmployee.FirstName = "Arun";
            //nousFullTimeEmployee.LastName = "Raj";
            //nousFullTimeEmployee.AnnualSalary = 100000;
            //string  name= nousFullTimeEmployee.GetFullName();
            // int salary = nousFullTimeEmployee.GetMonthlySalary();
            //Console.WriteLine($"Full Time Employee.....");
            //Console.WriteLine($"Name ={name}");
            //Console.WriteLine( $"Salary={salary}");
            //Console.WriteLine("--------------------------");
            //NousPartTimeEmployee nousPartTime = new NousPartTimeEmployee();
            //nousPartTime.FirstName = "Kapil";
            //nousPartTime.LastName = "Sharma";
            //nousPartTime.HourlyPay = 50;
            //nousPartTime.TotalHourWorked = 40;

            //string name1 = nousPartTime.GetFullName();
            //int salary1 = nousPartTime.GetMonthlySalary();

            //Console.WriteLine($"Part Time Employee.....");
            //Console.WriteLine($"Name ={name1}");
            //Console.WriteLine($"Salary={salary1}");
            //Console.WriteLine("--------------------------");


            //Access Modifiers

            ///  Access_Modifiers modifiers = new Access_Modifiers(); 


            //Deleagte 
            //Delegate_Demo delegate_Demo = new Delegate_Demo();

            //Hello_function_Deleagte
            //     hello_Function_Deleagte = new Hello_function_Deleagte(Hello);

            //hello_Function_Deleagte("Hello");


            //List<Employee> employees = new List<Employee>();
            //employees.Add(new Employee { FirstName = "Arun", LastName = "Kumar", Expereince = 5 });
            //employees.Add(new Employee { FirstName = "Arun", LastName = "Raj", Expereince = 2 });

            //Emp_Delegate emp_Delegate = new Emp_Delegate(Emp_Promote);
            //    Employee.PromoteEmployee(employees,emp_Delegate);


            //Generic  - ------------------------------

            //  GenericDemo<string> genericDemo = new GenericDemo<string>();
            // // bool result = genericDemo.IsEqual(1, 2);
            ////  bool result = genericDemo.IsEqual(1, "a");
            //  bool result = genericDemo.IsEqual("a", "a","b");
            //  Console.WriteLine($"Result:{result}");

            ///--------------------------------------------//// 

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("str");
            //arrayList.Add(1);
            //foreach (var array in arrayList)
            //{
            //    Console.WriteLine($"{array}");
            //}

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, 2);
            //hashtable.Add("str", "Name");

            //foreach (DictionaryEntry hash in hashtable)
            //{
            //    Console.WriteLine($"{hash.Key} -  {hash.Value}");
            //}

            //SortedList sortedList = new SortedList();

            //// sortedList.Add("1", "2");
            //sortedList.Add("SortedList_Key", "SortedList");
            //sortedList.Add("A_Key", "A_Value");

            //foreach (DictionaryEntry sort in sortedList)
            //{
            //    Console.WriteLine($"{sort.Key} -  {sort.Value}");
            //}
            // Console.WriteLine("-----------------------------");
            // Console.WriteLine("Stack");

            //Stack stack = new Stack();
            //stack.Push("a");
            //stack.Push(2);
            //stack.Push(3);
            //foreach (var stk in stack)
            //{
            //    Console.WriteLine($"{stk}");
            //}

            // Console.WriteLine("Queue");
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //foreach (var que in queue)
            //{
            //    Console.WriteLine($"{que}");
            //}

            // Console.WriteLine("-----------------------");
            // Console.WriteLine("Generic Collection");
            // ///Generic Collection 
            // ///
            // Console.WriteLine("---------------List--------------------");
            //List<int> lst = new List<int>();
            //lst.Add(100);
            //lst.Add(200);
            //lst.Add(300);
            //lst.Add(400);
            //foreach (int i in lst)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("---------------Dictonary--------------------");
            //Dictionary<int, string> dictonary = new Dictionary<int, string>();
            //dictonary.Add(1, "Arun");
            //dictonary.Add(2, "Pradeep");
            //dictonary.Add(3, "JP");
            //dictonary.Add(4, "Navaneethan");
            //foreach (KeyValuePair<int, string> kvp in dictonary)
            //{
            //    Console.WriteLine(kvp.Key + " " + kvp.Value);

            //}

            //Console.WriteLine("----------------SortedList---------------- ");

            //SortedList<int, string> sortedListGeneric = new SortedList<int, string>();

            //sortedListGeneric.Add(2, "Orange");
            //sortedListGeneric.Add(1, "Apple");
            //foreach (KeyValuePair<int, string> kvp in sortedListGeneric)
            //{
            //    Console.WriteLine(kvp.Key + " " + kvp.Value);

            //}

            // Console.WriteLine("----------------Stack---------------- ");
            //Stack<int> stackGeneric = new Stack<int>();

            //stackGeneric.Push(3); stackGeneric.Push(2); stackGeneric.Push(1);

            //foreach (int _stack in stackGeneric)
            //{
            //    Console.WriteLine(_stack);

            //}

            // Console.WriteLine("----------------Queue---------------- ");

            Queue<string> queueGeneric = new Queue<string>();

            queueGeneric.Enqueue("Arun");
            queueGeneric.Enqueue("JP");
            queueGeneric.Enqueue("Navaneethan");

            foreach (string _queueGeneric in queueGeneric)
            {
                Console.WriteLine(_queueGeneric);

            }
            Console.ReadKey();
        }

        public static bool Emp_Promote(Employee emp)
        {
            if(emp.Expereince>=5)
            {
                return true;
            }
            else
            {
                return false;
            }
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
