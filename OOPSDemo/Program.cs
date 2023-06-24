using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in OOPS Concepts");
            Console.WriteLine("1 : Class And Object");
            Console.WriteLine("2 : Inheritance Concept");
            Console.WriteLine("Enter A Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    ClassObject classObject = new ClassObject();
                    classObject.Methods();
                    break;
                case 2:
                    LastName last = new LastName();
                    last.Info("Ritesh");
                    last.Infoo("Waykole");
                    break;
            }
            Console.ReadLine();
        }
    }
}
