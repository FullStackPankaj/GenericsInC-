using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Employee
    {
        public Employee(string s, int i)
        {
            this.Name = s;
            this.ID = i;
        }
        public string Name { get; set; }
        public int ID { get; set; }
    }
}
