using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Zap
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ').Select(m => Int32.Parse(m)).ToList();
            int n = s[0];
            int k = s[1];
            int x = s[2];
            s = Console.ReadLine().Split(' ').Select(m => Int32.Parse(m)).ToList();
            s.Sort();
            s.Reverse();
            s.RemoveRange(0, x);
            if(s[0] > k && s[1] > k)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}

