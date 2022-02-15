using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ').Select(k=> Int32.Parse(k)).ToList();
            int n = s[0];
            int x = s[1];
            s = Console.ReadLine().Split(' ').Select(k => Int32.Parse(k)).ToList();
            s.Sort(); s.Reverse();
            int count = 0;
            for(int i = 0; i < s.Count; i++)
            {
                if(s[i] < 10)
                {
                    if(10 - s[i] > x)
                    {
                        break;
                    }
                    else
                    {
                        x -= 10 - s[i];
                        count++;
                    }
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

