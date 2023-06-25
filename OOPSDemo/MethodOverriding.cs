using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    public class Animal
    {
        public virtual void Eating()
        {
            Console.WriteLine("eat");
        }
    }
    public class Dog:Animal
    {
        public override void Eating()
        {
            Console.WriteLine("Eating bread");
        }
    }
}
