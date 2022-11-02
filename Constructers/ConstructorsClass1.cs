using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructers
{
    public class ConstructorsClass1
    {
        int x;
        int y;


        public ConstructorsClass1()
        {
            x = 1;
            y = 2;

        }
        public void Method()
        {
            int Z = x + y;
            Console.WriteLine("z is :" + Z);


        }
    }
}
