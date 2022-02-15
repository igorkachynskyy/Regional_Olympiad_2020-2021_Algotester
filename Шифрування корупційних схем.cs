using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm_RLE
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            string c = "";
            int sum = 1;
            int ind = 0;
            for(int i = 1; i < s.Length; i++)
            {
                if(s[i].ToString() == s[ind].ToString())
                {
                    sum++;
                }
                else
                {
                    c += sum + s[ind].ToString();
                    ind = i;
                    sum = 1;
                }
            }
            c += sum + s[ind].ToString();
            Console.WriteLine(c);
        }
    }
}

