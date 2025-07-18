using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //Video01
    //What can be created in Struct
    //1.Methods
    //2.Attributes(Variables=Field)
    //3.Property
    //4.Events
    internal struct PointDemo
    {
        public int X;
        public int Y;
        //Constructor: is a special method
        //            1.Its name by struct name
        //            2.Has no return type
        //public Point()
        //{

        //}
        //.Net 5.0 C#9.0
        //.Net 6.0 C#10.0

        public PointDemo()
        {
            X = 12;
            Y = 12;
        }
        public PointDemo(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void PrintPoint()
        {
            Console.WriteLine($"({X},{Y})");
        }
        public override string ToString()
        {
            return $"({X} , {Y})";
        }
    }
}
