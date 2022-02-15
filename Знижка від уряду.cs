using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount_from_goverment
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');
            int a = Int32.Parse(s[0].ToString());
            int b = Int32.Parse(s[1].ToString());
            Console.WriteLine(a * 2 - b);
        }
    }
}

