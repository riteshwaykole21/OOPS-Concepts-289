using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    public abstract class Animals
    {
        public abstract void AnimalSound();
        public void Sleep()
        {
            Console.WriteLine("Animals sleep at Night");
        }
    }
    public class Dogs:Animals
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Dod Says buu buu");
        }
    }
}
