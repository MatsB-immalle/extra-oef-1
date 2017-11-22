
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace extra_oef
{
    class Program
    {
        static void Main(string[] args)
        {



            int letterZ = 0x5A;
            string s = "";
            

            for(int x = 0; x<26; x++)
            {
                s += Convert.ToChar(letterZ - x);
                
            }
            Console.WriteLine(s);


        }
    }
}
