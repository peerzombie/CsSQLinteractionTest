using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            rechner r = new rechner(10);
            Console.WriteLine("10 * 10 = " + r.f());
            Console.Read();
        }
    }

    class rechner
    {
        private int variable = 0;

        public rechner(int x)
        {
            variable = x;
        }
        public int f()
        {
            return variable*variable;
        }
    }
}
