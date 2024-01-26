using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class MyClass
    {
        
        
            private double value1;
            private double value2;
            public static int count;

            public MyClass(double val1, double val2)
            {
                value1 = val1;
                value2 = val2;
                count++;
            }

            public MyClass()
                : this(2.0, 2.0)
            {
            }

            static MyClass()
            {
                count = 0;
            }

            public double Value1
            {
                get { return value1; }
                set { value1 = value; }
            }

            public double Value2
            {
                get { return value2; }
                set { value2 = value; }
            }

            public void DisplayValues()
            {
                Console.WriteLine($"Value1: {value1}, Value2: {value2}");
            }
        }
    }

