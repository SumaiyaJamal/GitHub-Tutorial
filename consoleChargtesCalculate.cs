using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParking
{
    abstract class Charges
    {
        public abstract int calx(int h);
    }

    class parkingCharge : Charges
    {
        public override int calx(int h)
        {
            int val1, val2, ch;
            int c = h - 16;
            if (c > 0)
            {
                val1 = 197;
                val2 = c * 184;
                ch = val1 + val2;
            }
            else
            {
                val1 = 197;
                ch = val1;
            }
            return ch;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int hour;
            Console.WriteLine("Enter Number of hours you want to park a car ");
            input = Console.ReadLine();
            hour = int.Parse(input);
            parkingCharge car = new parkingCharge();
            int v = car.calx(hour);
            Console.WriteLine("charges is {0}",v);
            Console.ReadKey();
        }
    }
}
