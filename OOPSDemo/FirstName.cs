using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    public class FirstName
    {
        public void Info(string name)
        {
            Console.WriteLine($"My First Name is {name}");
        }
    }
    public class LastName : FirstName
    {
        public void Infoo(string lastname)
        {
            Console.WriteLine($"My Last Name is {lastname}");
        }
    }
}
