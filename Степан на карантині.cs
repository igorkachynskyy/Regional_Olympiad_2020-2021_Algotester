using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepan_on_the_carantine
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');
            var n = Int32.Parse(s[0].ToString());
            var k = Int32.Parse(s[1].ToString());
            var a = Console.ReadLine().Split(' ').Select(m => Int32.Parse(m)).ToList();
            int sum = 0;
            for(int i = 0; i<n; i++)
            {
                if(a[i]> k)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

