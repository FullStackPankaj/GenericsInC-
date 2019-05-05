using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
   public class OpEqualsViaInterface
    {
        public static void OpEqualsTestMethod<T>(T s, T t)  where T : IEquatable<T> , IComparable<T>
        {
            if (s.Equals(t))
            {
                Console.Write("true");
            }
            else
            {
                // goes here because compares bt reference not by value
                Console.Write("false");
            }
        }
    }
}
