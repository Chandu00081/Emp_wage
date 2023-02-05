using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int value = r.Next(0, 2);
            if (value == 0)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
        }
    }
}
