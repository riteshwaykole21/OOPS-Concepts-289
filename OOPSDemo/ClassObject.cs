using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    public class ClassObject
    {
        public void Methods()
        {
            Console.WriteLine("Enter First Number");
            int First = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int Second = Convert.ToInt32(Console.ReadLine());
            int Sum = First + Second;
            Console.WriteLine($"The Sum of Two Number is {Sum}");
        }
    }
}
