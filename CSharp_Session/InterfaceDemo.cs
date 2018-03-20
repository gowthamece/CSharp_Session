using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Session
{
    class InterfaceDemo
    {
    }
    public interface IEmployeeTranscation
    {
         int ID { get; set; }
         string Name { get; set; }
         void PrintName();
         
    }

  
}
