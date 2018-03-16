using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Session
{
    class Interface_Demo
    {
    }

    //Interface 
    //1. Interface members are public by default 
    //2.Interface cannot contains field 
    //3.Class can inherit Interface 
    //4. Interface can inherit Interface 
    //5. We can't create instance for interface 
    //6. Interface reference vaiable can point to derived class object

    interface ICustomer
        {
        void Print();
        
        }
    interface ICustomerTemp:ICustomer
    {
        void TemporaryCustomer();
        
    }
    interface ICustomerInherit: ICustomerTemp
    {
        void PrintTemp();
    }

    //class RegularCustomer : ICustomer
    //{
    //    public void Print()
    //    {
    //        Console.WriteLine("I'm interface 1");
    //    }
    
    //}

    //class RegularCustomer:ICustomer,ICustomerTemp
    //{
    //    public void Print()
    //    {
    //        Console.WriteLine("I'm interface 1");
    //    }

    //    public void TemporaryCustomer()
    //    {
    //        Console.WriteLine("I'm Interface 2");
    //    }

    //}

    class RegularCustomer:ICustomerInherit
    {
        public void Print()
        {
            Console.WriteLine("I'm interface Inherit 1 ");
        }

        public void PrintTemp()
        {
            Console.WriteLine("I'm interface Inherit 2 ");
        }
        public void TemporaryCustomer()
        {
            Console.WriteLine("I'm interface Inherit 3 ");
        }

    }

}
