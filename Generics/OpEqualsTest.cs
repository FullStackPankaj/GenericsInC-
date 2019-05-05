using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
   public class OpEqualsTest
    {
        public static void OpEqualsTestMethod<T>(T s, T t) where T : class
        {
            if(s == t)
            {
                Console.Write("true");
            }else
            {
                // goes here because compares bt reference not by value
                Console.Write("false");
            }
        }

    }

}
