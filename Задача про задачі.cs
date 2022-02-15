using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_about_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ').Select(k => Int32.Parse(k)).ToList();
            s.Sort();
            if( s[0] + s[1] <= 47)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

