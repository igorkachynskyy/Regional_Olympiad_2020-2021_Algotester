using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decryption_of_Shames
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = Console.ReadLine();
            int chy = 0;
            string s = "";
            for (int i = 0; i < c.Length; i++)
            {
                int chy1;
                bool isInt = Int32.TryParse(c[i].ToString(), out chy1 );
                if ( isInt == true)
                {
                    if (chy > 0)
                    {
                        chy = Int32.Parse(chy.ToString() + chy1.ToString());
                    }
                    else
                    {
                        chy += chy1;
                    }
                         
                }
                else
                { 
                    s += String.Concat(Enumerable.Repeat(c[i].ToString() , chy));
                    chy = 0;
                }
                
                      
            }
            Console.WriteLine(s);
        }
    }
}

