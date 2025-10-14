using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFKargo
{
    public class Employee
    {
        public string Name { get; set; }  // auto-property definition

        public Employee(string empName)
        {
            Name = empName;
        }

        public override string ToString()
        {  return Name; }
    }
}
