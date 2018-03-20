using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Session
{
   public class GenericDemo
    {
        public bool IsEqual(int Value1, int Value2)
        {
            bool result = (Value1 == Value2);
            return result;
        }

        public bool IsEqual(object Value1, object Value2)
        {
            bool result = (Value1 == Value2);
            return result;
        }

        public bool IsEqual<T>(T Value1, T Value2)
        {
            bool result = (Value1.Equals(Value2));
            return result;
        }
    }
}
