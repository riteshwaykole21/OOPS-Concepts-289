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
            Console.WriteLine("3 : Method OverLoading Concepts");
            Console.WriteLine("4 : Method Overriding Concepts");
            Console.WriteLine("5 : Encapsulation Concepts");
            Console.WriteLine("6 : Abstraction Concepts");
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
                case 3:
                    MethodOverLoading method = new MethodOverLoading();
                    method.MethodOne();
                    method.MethodOne(30);
                    method.MethodOne(50,"Concepts");
                    method.MethodOne("Concepts" ,50);
                    method.MethodOne("MethodOverloading","Concepts");
                    break;
                case 4:
                    Dog d = new Dog();
                    d.Eating();
                    break;
                case 5:
                    Account account = new Account();
                    account.SetBalance(100);
                    account.GetBalances();
                    break;
                case 6:
                    Dogs dogs = new Dogs();
                    dogs.AnimalSound();
                    dogs.Sleep();
                    break;
            }
            Console.ReadLine();
        }
    }
}
