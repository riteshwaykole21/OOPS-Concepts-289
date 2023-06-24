using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    public class MethodOverLoading
    {
        public void MethodOne()
        {
            Console.WriteLine("Without Parameter");
        }
        public void MethodOne(int num)
        {
            Console.WriteLine($"With One Parameter : Num = {num}");
        }
        public void MethodOne(int num ,string str)
        {
            Console.WriteLine($"With Two Parameter : Num = {num} , string = {str}");
        }
        public void MethodOne(string str , int num)
        {
            Console.WriteLine($"With Two Parameter : Num = {num} , string = {str}");
        }
        public void MethodOne(string Name, string str)
        {
            Console.WriteLine($"With Two Parameter : string = {Name} , string = {str}");
        }
    }
}
