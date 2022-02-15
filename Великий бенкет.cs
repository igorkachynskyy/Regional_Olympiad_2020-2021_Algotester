using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Banket
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ').Select(m => Int32.Parse(m)).ToList();
            var s1 = Console.ReadLine().Split(' ').Select(m => Int32.Parse(m)).ToList();
            int count = 0;
            if(s1[0] - s[0] < 0)
            {
                count += Math.Abs(s1[0] - s[0]);
                s1[0] = 0;
            }
            else
            {
                s1[0] = s1[0] - s[0];
            }
            if(s1[1] - s[1] < 0)
            {
                count += Math.Abs(s1[1] - s[1]);
                s1[1] = 0;
            }
            else
            {
                s1[1] = s1[1] - s[1];
            }
            if(s1[0] + s1[1] - s[2] < 0)
            {
                count += Math.Abs(s1[0] + s1[1] - s[2]);
            }
            Console.WriteLine(count);

        }
    }
}

