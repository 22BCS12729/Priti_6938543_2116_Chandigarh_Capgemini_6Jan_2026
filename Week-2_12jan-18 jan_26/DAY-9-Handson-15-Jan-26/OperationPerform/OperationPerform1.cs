using System;
using System.Collections.Generic;
using System.Text;

namespace OperationPerform
{
    internal class OperationPerform1
    {
        public static int Calculate(int x, int y, int z)
        {
            if (x < 0 || y < 0)
            {
                return -1;
            }

            switch (z)
            {
                case 1:
                    return x + y;
                case 2:
                    return x - y;
                case 3:
                    return x * y;
                case 4:
                    return x / y;
                default:
                    return 0;
            }
        }

    }
}
