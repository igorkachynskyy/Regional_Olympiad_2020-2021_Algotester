using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');
            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);
            int k = Int32.Parse(s[2]);
            int sum = a;
            for (int i = 0; i < k;i++ )
            {
                sum += b;
            }
            Console.WriteLine(sum);

        }
    }
}

