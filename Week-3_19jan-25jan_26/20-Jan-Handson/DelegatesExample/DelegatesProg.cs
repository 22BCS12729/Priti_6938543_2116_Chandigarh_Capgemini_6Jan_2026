using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesExample
{
    internal class DelegatesProg
    {
        public delegate void Math(int x, int y);    

        class MultiCalass
        {
            public void add(int x,int y) {
                Console.WriteLine("Add:" + (x + y));
            }

            public void sub(int x,int y)
            {
                Console.WriteLine("Sub:"+(x - y));
            }
            public void mul(int x, int y)
            {
                Console.WriteLine("Mul:" + (x*y));
            }
            public void div(int x, int y)
            {
                Console.WriteLine("Div:" + (x/y));
            }
        }
        static void Main()

        {
        MultiCalass obj = new MultiCalass();
        Math m = new Math(obj.add);
        m += obj.sub;
            m += obj.mul;
            m += obj.div;
            m(100, 50);
        Console.WriteLine();
            m -= obj.div;
            m(625, 25);
        Console.ReadLine();

        }

     }
}
