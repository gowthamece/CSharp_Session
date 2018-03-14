using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Static Memebers - Doesn't change - invoke using name of the class 
//Instance Members  
namespace CSharp_Session
{
    class Static_Instance
    {
       
    }

    class Arthimetic
    {
        static int Num1 = 10;
        //int Num1;
        int Num2;

        //public Arthimetic(int num1, int num2)
        //{
        //    this.Num1 = num1;
        //    this.Num2 = num2;
        //}
        public Arthimetic(int num2)
        {
            this.Num2 = num2;
        }
        public int Add()
        {
           return Arthimetic.Num1 + this.Num2;
            
        }

        //Static Constructor - 1.1 Access Modifer is not allowed for static constructor 
           // Intialize static fileds
           //Before instance constructor 

        static Arthimetic()
        {
            Arthimetic.Num1 = 10;
        }
    }



    

}
