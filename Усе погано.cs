using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');
            int l = Int32.Parse(s[0]);
            int n = Int32.Parse(s[1]);
            var a = new List<string>();
            for(int i =0; i < l; i++)
            {
                var k = Console.ReadLine();
                a.Add(k);
            }
            int ind = 0;
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j].ToString() == "1")
                    {
                        //Console.WriteLine(a[i][j]);
                        ind++;
                        break;
                    }
                }
            }
            if (ind == l)
            {
                Console.WriteLine("YES");
            }
            else
            {
                ind =0;
                for (int i = 0; i < a[0].Length; i++)
                {
                    for (int j = 0; j < a.Count; j++ )
                    {
                        //Console.WriteLine(i + " " + j);
                        if (a[j][i].ToString() == "1")
                        {
                            ind++;
                            break;

                        }
                    }
                }
                if (ind == n)
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
}

